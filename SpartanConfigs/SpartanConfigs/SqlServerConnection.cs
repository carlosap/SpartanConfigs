using System;
using System.Threading.Tasks;

namespace SpartanConfigs
{
    public partial class Config
    {
        public partial class DataServer
        {
            public class SqlServerConnection
            {
                public static string DevConnectionString { get; set; }
                public static string StagingConnectionString { get; set; }
                public static string ConnectionString { get; set; }
                public static int TimeOut { get; set; } = 20;
                public static async Task<int> GetTimeOut() => await Task.Run(() => TimeOut);
                public static string GetConnectionString()
                {
                        string results = string.Empty;

                            string strEnv = HostingEnvironment;
                            switch (strEnv)
                            {
                                case "Development":
                                    results = DevConnectionString;
                                    break;
                                case "Staging":
                                    results = StagingConnectionString;
                                    break;
                                default:
                                    results = ConnectionString;
                                    break;
                            }
                        

                        return results;

                }

            }
        }

    }
}
