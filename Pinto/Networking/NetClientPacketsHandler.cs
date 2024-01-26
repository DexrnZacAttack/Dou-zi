﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Interop;
using Org.BouncyCastle.Asn1.Pkcs;
using PintoNS.Contacts;
using PintoNS.DouZiResources;
using PintoNS.Forms;
using PintoNS.Networking.Packets;
using PintoNS.UI;

namespace PintoNS.Networking
{
    internal class NetClientPacketsHandler
    {
        private MainForm instance;
        private NetClientHandler netHandler;

        public NetClientPacketsHandler(MainForm instance, NetClientHandler netHandler)
        {
            this.instance = instance;
            this.netHandler = netHandler;
        }

        public void HandleLoginPacket(PacketLogin packet)
        {
            netHandler.LoggedIn = true;
            instance.Invoke(
                new Action(() =>
                {
                    //UsingPintoForm.SetHasLoggedIn(true);
                    instance.OnLogin();
                })
            );
        }

        public void HandleServerInfoPacket(PacketServerInfo packet)
        {
            netHandler.ServerID = packet.ServerID;
            netHandler.ServerSoftware = packet.ServerSoftware;
            Program.Console.WriteMessage(
                $"The ID of the server is {netHandler.ServerID}", DouZiResources.ConsoleTypes.NETWORKING
            );
            Program.Console.WriteMessage(
                $"Server software: {netHandler.ServerSoftware}", DouZiResources.ConsoleTypes.NETWORKING
            );
        }

        public void HandleLogoutPacket(PacketLogout packet)
        {
            Program.Console.WriteMessage(
                $"Kicked by the server: {packet.Reason.Replace("\n", "\\n")}", DouZiResources.ConsoleTypes.NETWORKING
            );
            netHandler.NetManager.Shutdown($"Kicked by the server");
            instance.Invoke(
                new Action(() =>
                {
                    //UsingPintoForm.SetHasLoggedIn(false);
                    MsgBox.Show(
                        instance,
                        packet.Reason,
                        "Kicked by the server",
                        MsgBoxIconType.WARNING,
                        true
                    );
                })
            );
        }

        public void HandleMessagePacket(PacketMessage packet)
        {
            MessageHandler altMessageHandler = new MessageHandler();
            altMessageHandler.HandleMessage(packet, instance);
        }
        public void HandleNotificationPacket(PacketNotification packet)
        {
            instance.Invoke(
                new Action(() =>
                {
                    switch (packet.Type)
                    {
                        case 0:
                            instance.InWindowPopupController.CreatePopup(
                                packet.Body,
                                false,
                                packet.AutoCloseDelay
                            );
                            break;
                        case 1:
                            instance.InWindowPopupController.CreatePopup(
                                packet.Body,
                                true,
                                packet.AutoCloseDelay
                            );
                            break;
                        case 2:
                            instance.PopupController.CreatePopup(
                                packet.Body,
                                packet.Title,
                                packet.AutoCloseDelay
                            );
                            break;
                    }
                })
            );
        }

        public void HandleAddContactPacket(PacketAddContact packet)
        {
            Program.Console.WriteMessage(
                $"Adding {packet.ContactName} to the contact list...", DouZiResources.ConsoleTypes.CONTACTS
            );
            instance.Invoke(
                new Action(() =>
                {
                    ContactsManager contactsMgr = instance.ContactsMgr;
                    if (contactsMgr == null)
                        return;
                    contactsMgr.AddContact(
                        new Contact()
                        {
                            Name = packet.ContactName,
                            Status = packet.Status,
                            MOTD = packet.MOTD
                        }
                    );
                    instance.UpdateOnlineContacts();
                    LastContacts.AddToLastContacts(packet.ContactName);
                })
            );
        }

        public void HandleRemoveContactPacket(PacketRemoveContact packet)
        {
            Program.Console.WriteMessage(
                $"Removing {packet.ContactName} from the contact list...", DouZiResources.ConsoleTypes.CONTACTS
            );
            instance.Invoke(
                new Action(() =>
                {
                    ContactsManager contactsMgr = instance.ContactsMgr;
                    if (contactsMgr == null)
                        return;
                    contactsMgr.RemoveContact(contactsMgr.GetContact(packet.ContactName));
                    instance.UpdateOnlineContacts();
                    LastContacts.RemoveFromLastContacts(packet.ContactName);
                })
            );
        }

        public void HandleStatusPacket(PacketStatus packet)
        {
            Program.Console.WriteMessage(
                $"Status change: "
                    + $"{(string.IsNullOrWhiteSpace(packet.ContactName) ? "SELF" : packet.ContactName)} -> {packet.Status}", ConsoleTypes.GENERAL
            );

            instance.Invoke(
                new Action(() =>
                {
                    if (string.IsNullOrWhiteSpace(packet.ContactName))
                        instance.OnStatusChange(packet.Status, packet.MOTD);
                    else
                    {
                        Contact contact = instance.ContactsMgr.GetContact(packet.ContactName);

                        if (contact == null)
                        {
                            Program.Console.WriteMessage(
                                $"Received invalid status change"
                                    + $", \"{packet.ContactName}\" is not a valid contact!", ConsoleTypes.GENERAL
                            );
                            return;
                        }

                        if (instance.LocalUser.Status != UserStatus.BUSY)
                        {
                            if (
                                packet.Status == UserStatus.OFFLINE
                                && contact.Status != UserStatus.OFFLINE
                            )
                            {
                                instance.PopupController.CreatePopup(
                                    $"{packet.ContactName} is now offline",
                                    "Status change"
                                );
                                new SoundPlayer() { Stream = Sounds.OFFLINE }.Play();
                            }
                            else if (
                                packet.Status != UserStatus.OFFLINE
                                && contact.Status == UserStatus.OFFLINE
                            )
                            {
                                instance.PopupController.CreatePopup(
                                    $"{packet.ContactName} is now online",
                                    "Status change"
                                );
                                new SoundPlayer() { Stream = Sounds.ONLINE }.Play();
                            }
                        }

                        if (
                            (packet.Status == UserStatus.BUSY && contact.Status != UserStatus.BUSY)
                            || (
                                packet.Status == UserStatus.AWAY
                                && contact.Status != UserStatus.AWAY
                            )
                        )
                        {
                            MessageForm msgForm = instance.GetMessageFormFromReceiverName(
                                packet.ContactName,
                                true
                            );
                            if (msgForm != null)
                                msgForm.InWindowPopupController.CreatePopup(
                                    $"{packet.ContactName} is now {packet.Status.ToString().ToLower()} and may not see your messages",
                                    true
                                );
                        }

                        instance.ContactsMgr.UpdateContact(
                            new Contact()
                            {
                                Name = packet.ContactName,
                                Status = packet.Status,
                                MOTD = packet.MOTD
                            }
                        );
                        instance.UpdateOnlineContacts();
                    }
                })
            );
        }

        public void HandleContactRequestPacket(PacketContactRequest packet)
        {
            Program.Console.WriteMessage(
                $"Received contact request from {packet.ContactName}", DouZiResources.ConsoleTypes.NETWORKING
            );
            if (Settings.doNotUseUWPNotifications == true || Program.IsNotWindows10)
            {
                Program.sendUWPNotification(
                    $"{packet.ContactName} wants to add you to their contact list.",
                    "New contact request!"
                );
            }
            instance.Invoke(
                new Action(() =>
                {
                    MsgBox.Show(
                        instance,
                        $"{packet.ContactName} wants to add you to their contact list. Proceed?",
                        "Contact request",
                        MsgBoxIconType.QUESTION,
                        true,
                        true,
                        (MsgBoxButtonType button) =>
                        {
                            netHandler.RespondContactRequest(
                                packet.ContactName,
                                button == MsgBoxButtonType.YES
                            );
                        }
                    );
                })
            );
        }

        public void HandleClearContactsPacket(PacketClearContacts packet)
        {
            Program.Console.WriteMessage($"Clearing contact list...", DouZiResources.ConsoleTypes.CONTACTS);
            instance.Invoke(
                new Action(() =>
                {
                    instance.ContactsMgr.Clear();
                    instance.UpdateOnlineContacts();
                    LastContacts.ClearLastContacts();
                })
            );
        }

        public void HandleKeepAlivePacket(PacketKeepAlive packet)
        {
            netHandler.SendPacket(new PacketKeepAlive());
        }

        public void HandleTypingPacket(PacketTyping packet)
        {
            instance.Invoke(
                new Action(() =>
                {
                    MessageForm msgForm = instance.GetMessageFormFromReceiverName(
                        packet.ContactName,
                        true
                    );
                    if (msgForm != null)
                        msgForm.SetReceiverTypingState(packet.State);
                })
            );
        }

        public void HandleCallChangeStatusPacket(PacketCallChangeStatus packet)
        {
            instance.Invoke(
                new Action(() =>
                {
                    // TODO: Add this
                })
            );
        }
    }
}
