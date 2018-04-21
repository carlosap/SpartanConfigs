namespace SpartanConfigs
{
    public partial class Config
    {
        public class Cache
        {
            public static class Disk
            {
                public static bool Enable = false;
                public static int MaxSizeInMb = 300;
                public static bool EnableEncryption = false;
                public static string DevDirectory = "DataSource";
                public static string StagingDirectory = "c:\\temp\\DiskCache";
                public static string Directory = "D:\\home\\LogFiles\\DiskCache";
            }

            public class Memory
            {
                public static bool Enable = true;
            }
        }
    }
}
