using CSScriptLibrary;
using Microsoft.Toolkit.Uwp.Notifications;
using PintoNS.DouZiResources;
using PintoNS.Forms;
using PintoNS.Scripting;
using PintoNS.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Windows.UI.Notifications;

namespace PintoNS
{
    public static class Program
    {
        // Constants
        public static ConsoleForm Console;
        public static bool doNotShowNotification = false;
        public static bool hasServerInfo = false;
        public static byte PROTOCOL_VERSION = 11;
        public static string VERSION_STRING = "b1.2";

        // Dexrn ====================
        // Networking ---------------
        public static string entireBase64MSG = null;

        public static string fileNameUnstripped = null;
        public static string fileName = null;
        public static int chunksCount = 0;
        public static byte[] data = null;
        public static string decodedString = null;
        public static bool base64IsMultipleMessages = false;

        // Extra ---------------
        public static string VERSION_STRING_NOSPOOF = "b1.2";
        public static byte PROTOCOL_VERSION_NOSPOOF = 11;
        public static bool ignoreNonAlphaChars = false;
        public static bool ignoreRateLimit = false;
        public static DouZiResources.RPC discordRPC;
        public static bool hasSpoofedVersion = false;
        public static bool hasSpoofedPVN = false;
        public static string ServerID = "";
        public static string ServerSoftware = "";
        public static string Status = null;
        // ==========================

        // Data paths
        public static readonly string DataFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Pinto!"
        );

        public static readonly string SettingsFile = Path.Combine(DataFolder, "settings.json");
        public static readonly List<IPintoScript> Scripts = new List<IPintoScript>();

        // Main variables
        public static MainForm MainFrm;

        public static bool RunningOnLegacyPlatform;
        public static bool RunningUnderMono;

        public static bool IsNotWindows10
        {
            get { return Environment.OSVersion.Version < new Version(10, 0); }
        }

        [STAThread]
        private static void Main()
        {
            discordRPC = new DouZiResources.RPC();
            bool createdNew;
            Mutex mutex = new Mutex(true, "PintoIM/Pinto", out createdNew);

            if (!createdNew)
            {
                MessageBox.Show(
                    "Only one instance of Pinto! can run at the same time",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Enable visual styles
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Unhandled exception handler
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            // Setup console
            Console = new ConsoleForm();
            Console.Show();
            discordRPC.StartRPC();

            // Detect what runtime we are being ran under
            try
            {
                string wineVer = PInvoke.GetWineVersion();
                Console.WriteMessage($"Running under wine ({wineVer})", ConsoleTypes.GENERAL);
            }
            catch
            {
                Console.WriteMessage("Not running under wine", ConsoleTypes.GENERAL);
            }

            RunningUnderMono = Type.GetType("Mono.Runtime") != null;
            if (RunningUnderMono)
                Console.WriteMessage("Running under mono", ConsoleTypes.GENERAL);
            else
                Console.WriteMessage("Not running under mono", ConsoleTypes.GENERAL);

            if (!RunningUnderMono)
            {
                // Enable TLS 1.0, 1.1, 1.2
                Version version = NETFrameworkVersion.GetVersion();
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol =
                    version.Minor < 5
                        ? SecurityProtocolType.Tls
                        :
                        // 768 = TLS 1.1
                        // 3072 = TLS 1.2
                        // These are not available in a .NET 4.0 runtime, but available in a .NET 4.5
                        SecurityProtocolType.Tls
                            | (SecurityProtocolType)768
                            | (SecurityProtocolType)3072;
                Console.WriteMessage($".NET Framework runtime version: {version}", ConsoleTypes.GENERAL);
                Console.WriteMessage(
                    $"Security protocol: {ServicePointManager.SecurityProtocol}"
                , 0);
            }
            else
            {
                Console.WriteMessage(
                    ".NET Framework runtime version: N/A (running on mono)"
                , 0);
                Console.WriteMessage($"Security protocol: N/A (running on mono)", ConsoleTypes.GENERAL);
            }

            // Print the operating system information
            Console.WriteMessage(
                $"Operating system: {Environment.OSVersion.Platform}"
                    + $" ({Environment.OSVersion.VersionString})"
            , 0);

            if (Environment.OSVersion.Version.Major < 6)
            {
                RunningOnLegacyPlatform = true;
                Console.WriteMessage($"Running on a legacy platform (<= Windows XP)", ConsoleTypes.GENERAL);
            }

            if (!Directory.Exists(DataFolder))
                Directory.CreateDirectory(DataFolder);
            if (!Directory.Exists(Path.Combine(DataFolder, "chats")))
                Directory.CreateDirectory(Path.Combine(DataFolder, "chats"));
            if (!Directory.Exists(Path.Combine(DataFolder, "scripts")))
                Directory.CreateDirectory(Path.Combine(DataFolder, "scripts"));
            if (!Directory.Exists(Path.Combine(DataFolder, "scripts", "settings")))
                Directory.CreateDirectory(Path.Combine(DataFolder, "scripts", "settings"));

            // Load the settings
            Console.WriteMessage("Loading the settings", ConsoleTypes.GENERAL);
            Settings.Import(SettingsFile);

            // Create the main form
            MainFrm = new MainForm();
            MainFrm.Focus();

            if (!Settings.NoLoadScripts)
                // Loads all the scripts
                LoadScripts(MainFrm);
            else
                Console.WriteMessage("Loading of scripts is disabled!", DouZiResources.ConsoleTypes.SCRIPTING);

            // Start Pinto!
            Application.Run(MainFrm);
        }

        public static void LoadScripts(MainForm mainForm)
        {
            Console.WriteMessage("Loading scripts...", DouZiResources.ConsoleTypes.SCRIPTING);
            string[] scripts = Directory.GetFiles(Path.Combine(DataFolder, "scripts"), "*.cs");
            bool failedToLoad = false;

            foreach (string script in scripts)
            {
                try
                {
                    Console.WriteMessage($"Loading script {script}", DouZiResources.ConsoleTypes.SCRIPTING);

                    // Warning	CS0618	'CSScript.Load(string)' is obsolete: 'This method has been renamed to better align with Mono and Roslyn based CS-Script evaluators. Use LoadFile instead.'
                    Assembly scriptAsm = CSScript.LoadFile(script);
                    IPintoScript scriptInstance = scriptAsm
                        .CreateObject("PintoScript", mainForm)
                        .AlignToInterface<IPintoScript>();
                    PintoScriptInfo scriptInfo = scriptInstance.GetScriptInfo();

                    scriptInstance.OnLoad();
                    Console.WriteMessage(
                        $"Loaded {scriptInfo.Name}"
                            + $" v{scriptInfo.Version} by {scriptInfo.Author}", DouZiResources.ConsoleTypes.SCRIPTING
                    );

                    Scripts.Add(scriptInstance);
                }
                catch (Exception ex)
                {
                    Console.WriteMessage($"Failed to load the script {script}: {ex}", DouZiResources.ConsoleTypes.SCRIPTING);
                    failedToLoad = true;
                }
            }

            if (failedToLoad)
            {
                MsgBox.Show(
                    mainForm,
                    "Some of your scripts have failed to load. Check the console for more information",
                    "Script Loading Failure",
                    MsgBoxIconType.ERROR
                );
            }
        }

        public static Icon GetFormIcon() => Logo.LOGO_ICO;

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            UnhandledExceptionHandler(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(
            object sender,
            UnhandledExceptionEventArgs e
        )
        {
            UnhandledExceptionHandler(e.ExceptionObject);
        }

        private static void UnhandledExceptionHandler(object ex)
        {
            FatalErrorForm fatalErrorForm = new FatalErrorForm();
            fatalErrorForm.rtxtLog.Text = $"{ex}";
            fatalErrorForm.ShowDialog();
            Environment.Exit(0);
        }

        public static IEnumerable<string> SplitStringIntoChunks(string str, int chunkSize)
        {
            for (int i = 0; i < str.Length; i += chunkSize)
                yield return str.Substring(i, Math.Min(chunkSize, str.Length - i));
        }

        public static string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        public static TValue GetValueOrDefault<TKey, TValue>(
            this IDictionary<TKey, TValue> dict,
            TKey key,
            TValue @default
        )
        {
            return dict.TryGetValue(key, out var value) ? value : @default;
        }
    }
}