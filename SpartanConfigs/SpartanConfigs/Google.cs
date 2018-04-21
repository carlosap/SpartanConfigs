using System.Collections.Generic;

namespace SpartanConfigs
{
    public partial class Config
    {
        public class Google
        {
            public class API
            {
                public static bool Enabled = true;
                public static string Key { get; set; }
                public static string AutoCompleteUrl { get; set; }
                public static string PlaceDetailUrl { get; set; }
                public static string DistanceMatrix { get; set; }
                public static string Near { get; set; }
                public static int RadiusInMeter { get; set; } = 1000;

            }
        }
    }
}
