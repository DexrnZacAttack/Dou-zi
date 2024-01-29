using PintoNS.Forms;
using PintoNS.Networking.Packets;
using System;
using System.IO;
using System.Media;
using System.Text.RegularExpressions;

namespace PintoNS.DouZiResources
{
    public class MessageHandler
    {
        public void HandleMessage(PacketMessage packet, MainForm instance)
        {
            instance.Invoke(
                new Action(() =>
                {
                    MessageForm messageForm = instance
                        .GetMessageFormFromReceiverName(packet.ContactName);

                    if (messageForm == null)
                    {
                        Program.Console.WriteMessage($"Unable to" +
                            $" get a message form for {packet.ContactName}!", ConsoleTypes.NETWORKING);
                        return;
                    }

                    try
                    {
                        // Dexrn -------------------------------------
                        // TODO: Seperate this into it's own method/whatever.
                        // This is meant to be for sending chunked base64 encoded data, hopefully for image sharing in the future
                        // since the server doesn't support images.
                        if (Program.base64IsMultipleMessages && packet.Message.TrimStart().StartsWith("Base64ChunkEnd"))
                        {
                            handleBase64EndChunk(packet, messageForm, instance);
                        }
                        else if (packet.Message.TrimStart().StartsWith("Base64Chunk") ||
                            packet.Message == "Base64Chunk")
                        {
                            handleBase64Chunk(packet, messageForm, instance);
                        }
                        else
                        {
                            handleMSG(packet, messageForm, instance);
                        }
                    }
                    catch (Exception) { }
                }));
        }

        public void writeExtraStuff(MessageForm messageForm, PacketMessage packet, MainForm instance)
        {
            messageForm.WriteFeatureMessage(
                $"\n{packet.Sender}",
                packet.Sender == instance.LocalUser.Name
                    ? MessageForm.MsgSelfSenderColor
                    : MessageForm.MsgOtherSenderColor,
                false
            );

            messageForm.WriteFeatureMessage($" - ", MessageForm.MsgSeparatorColor, false);
            messageForm.WriteFeatureMessage(
                $"{DateTime.Now.ToString("HH:mm:ss")}",
                MessageForm.MsgTimeColor,
                false
            );
            messageForm.WriteFeatureMessage($":", MessageForm.MsgSeparatorColor);
        }

        public void sendMessage(MessageForm messageForm, string message, MainForm instance, PacketMessage packet, int messageType = 0)
        {
            if (packet.Sender.Trim().Length > 0)
            {
                switch (messageType)
                {
                    case 0:
                        writeExtraStuff(messageForm, packet, instance);
                        messageForm.WriteFeatureMessage(message, MessageForm.MsgContentColor, false);
                        break;

                    case 1:
                        writeExtraStuff(messageForm, packet, instance);
                        messageForm.WriteFeatureMessage(message, MessageForm.MsgContentColor, false);
                        break;

                    case 2:
                        writeExtraStuff(messageForm, packet, instance);
                        messageForm.WriteFeatureMessage($"Sent Base64 Chunk {Program.chunksCount}", MessageForm.MsgInfoColor, false);
                        break;

                    case 3:
                        writeExtraStuff(messageForm, packet, instance);
                        messageForm.WriteFeatureMessage($"Sent Base64 Chunk {Program.chunksCount}, File name is \"{Program.fileName}\"", MessageForm.MsgInfoColor, false);
                        break;

                    case 4:
                        writeExtraStuff(messageForm, packet, instance);
                        messageForm.WriteFeatureMessage($"Sent file! File name is \"{Program.fileName}\"", MessageForm.MsgInfoColor, false);
                        break;

                    default:
                        writeExtraStuff(messageForm, packet, instance);
                        messageForm.WriteFeatureMessage(message, MessageForm.MsgContentColor, false);
                        break;
                }

                messageForm.HasBeenInactive = true;

                if (Settings.doNotShowMessageBodyPreview == false)
                {
                    instance.PopupController.CreatePopup($"New message!", $"Received a " +
                        $"new message from {packet.ContactName}!");
                }
                else
                {
                    if (Program.decodedString != null && packet.Message.TrimStart().StartsWith("Base64") && packet.Sender != instance.LocalUser.Name)
                        instance.PopupController.CreatePopup($"{Program.decodedString}", $"Received a " +
                            $"new message from {packet.ContactName}!");
                    else if (packet.Sender != instance.LocalUser.Name)
                        instance.PopupController.CreatePopup($"{packet.Message}", $"Received a " +
                            $"new message from {packet.ContactName}!");
                    new SoundPlayer() { Stream = Sounds.IM }.Play();
                }
            }
        }

        private string StripFilePathCharacters(string str)
        {
            // Dexrn: Shitty way to do this, probably.
            return str.Replace("/", "\\")
                .Replace(":", "")
                .Replace("<", "")
                .Replace(">", "")
                .Replace("|", "")
                .Replace("?", "")
                .Replace("*", "")
                .Replace("\"", "");
        }

        private void handleMSG(PacketMessage packet, MessageForm messageForm, MainForm instance)
        {
            try
            {
                if (packet.Message.TrimStart().StartsWith("Base64"))
                {
                    Program.data = Convert.FromBase64String(packet.Message.TrimStart().Replace("Base64", ""));
                    Program.decodedString = System.Text.Encoding.UTF8.GetString(Program.data);
                    sendMessage(messageForm, Program.decodedString, instance, packet, 1);
                }
                else
                {
                    sendMessage(messageForm, packet.Message, instance, packet, 0);
                }
            }
            catch
            {
                messageForm.WriteFeatureMessage(
                    $"Invalid Base64 encoded data: {packet.Message}",
                    MessageForm.MsgErrorColor
                );
            }
        }

        private void handleBase64Chunk(PacketMessage packet, MessageForm messageForm, MainForm instance)
        {
            Program.chunksCount++;

            if (packet.Message.Contains("fileName="))
            {
                string pattern = @"fileName=""([^""]*)""";
                Match match = Regex.Match(packet.Message, pattern);
                if (match.Success)
                {
                    Program.fileNameUnstripped = match.Groups[1].Value;
                    Program.fileName = StripFilePathCharacters(Program.fileNameUnstripped);
                    sendMessage(messageForm, null, instance, packet, 3);
                }
            }
            else
            {
                sendMessage(messageForm, null, instance, packet, 2);
            }

            Program.base64IsMultipleMessages = true;

            if (
                 packet.Message.Replace("Base64ChunkEnd", "")
                     .Replace("Base64Chunk", "")
                     .Replace(" ", "")
                     .EndsWith("=")
             )
            {
                string cleanedMessage = System.Text.RegularExpressions.Regex.Replace(
                    packet.Message.Replace("Base64ChunkEnd", "").Replace("Base64Chunk", "").Replace(" ", ""),
                    @"fileName=""[^""]*""",
                    ""
                );

                Program.entireBase64MSG += cleanedMessage + "+";
            }
            else
            {
                // Dexrn: IG don't add + if no padding at the end.
                // Remove fileName attribute and its value
                string cleanedMessage = System.Text.RegularExpressions.Regex.Replace(
                    packet.Message.Replace("Base64ChunkEnd", "").Replace("Base64Chunk", "").Replace(" ", ""),
                    @"fileName=""[^""]*""",
                    ""
                );

                Program.entireBase64MSG += cleanedMessage;
            }
        }

        private void handleBase64EndChunk(PacketMessage packet, MessageForm messageForm, MainForm instance)
        {
            Program.chunksCount++;
            // Dexrn: There's probably some bug here, so lets add a try catch so that the program doesnt explode.
            // TODO: If bug found, fuck.
            try
            {
                sendMessage(messageForm, null, instance, packet, 2);
            }
            catch (Exception ex)
            {
                Program.Console.WriteMessage(ex.ToString(), ConsoleTypes.MESSAGING);
            }
            Program.entireBase64MSG += packet.Message.Replace("Base64ChunkEnd", "")
                .Replace("Base64Chunk", "")
                .Replace(" ", "");

            // Dexrn: padding is bad here, remove it.
            string cleanedBase64 = Program.entireBase64MSG.Replace("=", "");

            // then we readd it since it's all one string now.
            int padding = cleanedBase64.Length % 4;
            if (padding > 0)
            {
                cleanedBase64 += new string('=', 4 - padding);
            }

            try
            {
                Program.data = Convert.FromBase64String(cleanedBase64);
                Program.decodedString = System.Text.Encoding.UTF8.GetString(Program.data);
                string filePath =
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.UserProfile
                    )
                    + "\\Downloads\\Pinto!\\"
                    + Program.fileName;

                File.WriteAllBytes(filePath, Program.data);
                sendMessage(messageForm, null, instance, packet, 4);
                NotificationHandler.sendUWPNotification($"{packet.ContactName} sent you a file!", $"{Program.fileName}");
            }
            catch (Exception ex)
            {
                messageForm.WriteFeatureMessage(
                    $"Exception occured while decoding Base64 data! Check console for more details.",
                    MessageForm.MsgErrorColor
                );
                Program.Console.WriteMessage(
                    $"Exception occured while decoding Base64 data: {ex.ToString()}", ConsoleTypes.MESSAGING
                );
                Program.Console.WriteMessage(Program.entireBase64MSG, ConsoleTypes.MESSAGING);
            }
            Program.entireBase64MSG = null;
            Program.fileNameUnstripped = null;
            Program.fileName = null;
            Program.chunksCount = 0;
            Program.data = null;
            Program.decodedString = null;
            Program.base64IsMultipleMessages = false;
        }
    }
}