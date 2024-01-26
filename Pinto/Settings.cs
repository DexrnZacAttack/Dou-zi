﻿using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PintoNS
{
    [AttributeUsage(AttributeTargets.Field)]
    public class OptionsDisplayAttribute : Attribute
    {
        public string DisplayName;
        public string Category;
        public string HelpInfo;
        public bool Hidden;
        public int NumMin = int.MinValue;
        public int NumMax = int.MaxValue;
    }

    public static class Settings
    {
        #region General
        [OptionsDisplay(
            DisplayName = "Automatically check for updates on start-up",
            Category = "General",
            HelpInfo = "When you start Pinto!, it will automatically check for updates,"
                + " if this option is disabled, Pinto! will not check for updates on start-up,"
                + " you can still manually check for update by going to Help > Check for Updates\n"
                + "It is recommended that you keep this option enabled"
        )]
        public static bool AutoCheckForUpdates = true;

        [OptionsDisplay(
            DisplayName = "Automatically show the start page",
            Category = "General",
            HelpInfo = "When you login, Pinto! automatically shows you the start page,"
                + " if this option is disabled, the contacts page will be shown instead"
        )]
        public static bool AutoStartPage = true;

        [OptionsDisplay(
            DisplayName = "Do not ask for confirmation when exiting",
            Category = "General",
            HelpInfo = "When this option is enabled, Pinto! will not ask you for confirmation when you try to exit"
        )]
        public static bool NoExitPrompt = false;

        [OptionsDisplay(
            DisplayName = "Do not gracefully exit",
            Category = "General",
            HelpInfo = "When Pinto! exits, it plays a sound and then terminates,"
                + " if this option is enabled, Pinto! will instantly exit"
        )]
        public static bool NoGracefulExit = false;

        [OptionsDisplay(
            DisplayName = "Do not minimize to the system tray when attempting to close",
            Category = "General",
            HelpInfo = "When this is disabled,"
                + " Pinto! minimizes to the system tray when you try to close it,"
                + " and exitting can be performed by going to \"File > Exit\" or from the system tray,"
                + " when this is enabled Pinto! will immediately exit when you try to close it"
        )]
        public static bool NoMinimizeToSysTray = false;

        [OptionsDisplay(
            DisplayName = "Do not load scripts (restart required)",
            Category = "General",
            HelpInfo = "When this is enabled,"
                + " Pinto! will no longer load your scripts."
                + " A restart is required for this option to take effect."
        )]
        public static bool NoLoadScripts = false;

        [OptionsDisplay(
            DisplayName = "Use popup notifications instead of UWP (restart recommended)",
            Category = "General",
            HelpInfo = "When this is enabled,"
                + " Pinto! will no longer use UWP notifications, instead opting to use the original Popup notifications."
                + " A restart is required for this option to fully take effect."
        )]
        public static bool doNotUseUWPNotifications = false;

        #endregion
        #region Privacy
        [OptionsDisplay(
            DisplayName = "Do not show that I am typing to others",
            Category = "Privacy",
            HelpInfo = "When this option is enabled, the typing indicator won't be sent to people you are chatting with"
        )]
        public static bool NoTypingIndicator = false;

        [OptionsDisplay(
            DisplayName = "Do not show message body in notifications",
            Category = "Privacy",
            HelpInfo = "When this option is enabled, the message body in the notification will be replaced with \"New Message\""
        )]
        public static bool doNotShowMessageBodyPreview = false;
        #endregion
        #region Hidden
        [OptionsDisplay(Hidden = true)]
        public static bool DoNotShowSysTrayNotice = false;
        #endregion

        public static void Export(string file)
        {
            Type type = typeof(Settings);
            JObject obj = new JObject();

            foreach (FieldInfo field in type.GetFields())
            {
                obj[field.Name] = new JValue(field.GetValue(null));
            }

            File.WriteAllText(file, obj.ToString(Formatting.Indented));
        }

        public static void Import(string file)
        {
            Type type = typeof(Settings);
            if (!File.Exists(file))
                Export(file);
            JObject obj = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(file));

            foreach (JProperty property in obj.Children())
            {
                FieldInfo field = type.GetField(property.Name);
                if (field == null)
                    continue;
                field.SetValue(null, property.Value.ToObject(field.FieldType));
            }
        }
    }
}
