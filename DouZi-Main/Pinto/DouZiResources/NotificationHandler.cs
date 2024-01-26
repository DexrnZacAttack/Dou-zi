using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;

namespace PintoNS.DouZiResources
{
    internal class NotificationHandler
    {
        public static void sendUWPNotification(
        string body,
        string title = "Pinto!",
        string icon = null,
        bool isMessage = false
        )
        {
            // Dexrn ------------------------
            // There's probably a better way of doing this.
            // I plan on using isMessage for showing an input box if it is true.
            // although I'll have to figure out how to use it.
            try
            {
                Microsoft.Toolkit.Uwp.Notifications.ToastActivationType activationType = 0;
                string message = "";
                var toastNotifier = ToastNotificationManagerCompat.CreateToastNotifier();
                var history = ToastNotificationManagerCompat.History;

                if (history != null)
                {
                    foreach (var notification in history.GetHistory())
                    {
                        history.Clear();
                    }
                }

                var NotificationBuild = new ToastContentBuilder();
                if (isMessage == true)
                {
                    NotificationBuild.AddInputTextBox("PintoReply", "", "Reply");
                    NotificationBuild.AddButton("PintoReply", "Send", activationType, message);
                    ToastNotificationManagerCompat.OnActivated += notificationButtonClicked;
                }

                switch (icon)
                {
                    case "Connected":
                        break;

                    default:
                        break;
                }

                NotificationBuild.AddText($"{title}").AddText($"{body}");

                var content = NotificationBuild.Content;
                var xmlDoc = new Windows.Data.Xml.Dom.XmlDocument();
                xmlDoc.LoadXml(content.GetContent());

                var actualNotification = new ToastNotification(xmlDoc);
                toastNotifier.Show(actualNotification);
            }
            catch
            {
                Program.MainFrm.PopupController.CreatePopup(
                    body,
                    title
                );
            }
        }

        // Dexrn: WTF does "e" mean?
        public static void notificationButtonClicked(ToastNotificationActivatedEventArgsCompat e)
        {
            if (e?.Argument == "PintoReply")
            {
                // Dexrn: after all those confusing hoops and shit this is finally what happens when you click the button.
                string message = e.UserInput["PintoReply"].ToString();
                Program.Console.WriteMessage(message, 0);
            }
        }
    }
}
