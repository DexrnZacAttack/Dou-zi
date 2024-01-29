using DiscordRPC;
using DiscordRPC.Logging;
using PintoNS.Contacts;
using System;

namespace PintoNS.DouZiResources
{
    public class RPC
    {
        public DiscordRpcClient DRPC;

        public void StartRPC()
        {
            try
            {
                DRPC = new DiscordRpcClient("1200961500316192950");
                DRPC.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

                DRPC.OnReady += (sender, e) =>
                {
                    Program.Console.WriteMessage($"Received Ready from user {e.User.Username}", ConsoleTypes.DISCORD);
                };

                DRPC.OnPresenceUpdate += (sender, e) =>
                {
                    Program.Console.WriteMessage($"Received Update! {e.Presence}", ConsoleTypes.DISCORD);
                };
                DRPC.Initialize();
            }
            catch (Exception ex)
            {
                Program.Console.WriteMessage($"Failed to connect to Discord RPC: {ex}", ConsoleTypes.DISCORD);
            }
        }

        public void SetRPC(string details = null, string state = null, string largeImage = "https://raw.githubusercontent.com/DexrnZacAttack/douzi/main/Pinto/Resources/Logo/LOGO.png", string largeImageText = "DouZi", string smallImage = null)
        {
            // Dexrn: The invisible check mostly works, except when the server sets your status (e.g when you log in).
            if (Program.Status != UserStatus.INVISIBLE.ToString())
            {
                RichPresence presence = new RichPresence();
                if (details == "Unset")
                {
                }
                else
    if (details != null)
                {
                    presence.Details = details;
                }

                if (state == "Unset")
                {
                }
                else
                if (state != null)
                {
                    presence.State = state;
                }

                if (largeImage != null)
                {
                    presence.Assets = new DiscordRPC.Assets()
                    {
                        LargeImageKey = largeImage,
                        LargeImageText = largeImageText,
                        SmallImageKey = smallImage
                    };
                }
                else
                {
                    presence.Assets = new DiscordRPC.Assets()
                    {
                        LargeImageKey = largeImage
                    };
                }

                DRPC.SetPresence(presence);
                DRPC.Invoke();
            }
            else
            {
                DRPC.ClearPresence();
            }
        }

        public void UpdateRPC(RPCTypes whatToUpdate, string whatToPut)
        {
            // Dexrn -----------------
            // Usage: UpdateRPC(RPCTypes.Details, "Test"); (I think if whatToPut is null it'll unset it.)
            if (Program.Status != UserStatus.INVISIBLE.ToString())
            {
                DRPC.UpdateLargeAsset("https://raw.githubusercontent.com/DexrnZacAttack/douzi/main/Pinto/Resources/Logo/LOGO.png");
                switch (whatToUpdate)
                {
                    case RPCTypes.Details:
                        DRPC.UpdateDetails(whatToPut);
                        break;

                    case RPCTypes.State:
                        DRPC.UpdateState(whatToPut);
                        break;
                    /*          case RPCTypes.Buttons:
                                    DRPC.UpdateButtons(whatToPut);
                                    break;*/
                    /*          case RPCTypes.StartTime:
                                    DRPC.UpdateStartTime(whatToPut);
                                    break;*/
                    case RPCTypes.LargeImage:
                        DRPC.UpdateLargeAsset(whatToPut);
                        break;

                    case RPCTypes.SmallImage:
                        DRPC.UpdateSmallAsset(whatToPut);
                        break;
                }
            }
            else
            {
                DRPC.ClearPresence();
            }
        }

        public void stopRPC()
        {
            DRPC.Dispose();
        }
    }
}