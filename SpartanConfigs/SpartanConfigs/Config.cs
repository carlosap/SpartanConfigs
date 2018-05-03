using System.Collections.Generic;
using System.IO;
using static System.Environment;
namespace SpartanConfigs
{
    public partial class Config
    {

        public static string AppName { get; set; } = "SpartanWeb";
        public static int AppPortNumber { get; set; } = 9000;
        public static string AppFolder { get; set; }
        public static string AppSettings { get; set; }
        public static string AppPath { get; set; } = Directory.GetCurrentDirectory();
        public static string UserProfile { get; set; }
        public static string Version { get; set; } = "2.0.1";
        public static string HostingEnvironment { get; set; }
        public static string EncryptKey { get; set; }
        public static List<string> RemovePhrases = new List<string>()
        {
            " at ",
            " on ",
            " - ",
            ", "
        };
    }
}
