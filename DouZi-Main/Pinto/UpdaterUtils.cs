using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PintoNS.UI;
using System;
using System.Net;
using System.Net.Cache;
using System.Threading.Tasks;

namespace PintoNS
{
    public static class UpdaterUtils
    {
        public const string UPDATE_URL = "https://github.com/PintoIM/Pinto/raw/main/version.json";

        public static async Task<JObject> GetVersionInformation()
        {
            try
            {
                WebClient webClient = new WebClient
                {
                    CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore),
                };
                webClient.Headers["User-Agent"] = "PintoClient";

                string responseRaw = await Task.Factory.StartNew(() =>
                {
                    return webClient.DownloadString(UPDATE_URL);
                });
                JObject response = JsonConvert.DeserializeObject<JObject>(responseRaw);

                return response;
            }
            catch (Exception ex)
            {
                Program.Console.WriteMessage($"Unable to download version information: {ex}", DouZiResources.ConsoleTypes.UPDATER);
                return null;
            }
        }

        public static async Task<bool> IsLatest()
        {
            Program.Console.WriteMessage($"Checking for updates...", DouZiResources.ConsoleTypes.UPDATER);
            try
            {
                JObject information = await GetVersionInformation();
                return Program.VERSION_STRING.Equals(information["latest"].Value<string>(),
                    StringComparison.InvariantCultureIgnoreCase);
            }
            catch (Exception ex)
            {
                Program.Console.WriteMessage($"Unable to check for updates: {ex}", DouZiResources.ConsoleTypes.UPDATER);
                MsgBox.Show(null,
                    "Unable to check for updates!" +
                    " Check the console for more information," +
                    " you can also perform a re-check by going into the \"Help\" menu",
                    "Error",
                    MsgBoxIconType.ERROR);
                return true;
            }
        }

        public static async Task<byte[]> GetUpdateFile()
        {
            Program.Console.WriteMessage($"Downloading update file...", DouZiResources.ConsoleTypes.UPDATER);
            try
            {
                JObject information = await GetVersionInformation();
                string updateURL = information["update_url"].Value<string>();

                WebClient webClient = new WebClient();
                webClient.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
                webClient.Headers["User-Agent"] = "PintoClient";

                byte[] file = await webClient.DownloadDataTaskAsync(updateURL);
                Program.Console.WriteMessage($"Downloaded update file", DouZiResources.ConsoleTypes.UPDATER);

                return file;
            }
            catch (Exception ex)
            {
                Program.Console.WriteMessage($"Unable to download the update file: {ex}", DouZiResources.ConsoleTypes.UPDATER);
                MsgBox.Show(null,
                    "Unable to download the update file!" +
                    " Check the console for more information," +
                    " you can perform a re-check by going into the \"Help\" menu",
                    "Error",
                    MsgBoxIconType.ERROR);
                return null;
            }
        }
    }
}