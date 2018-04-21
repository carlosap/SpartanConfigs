namespace SpartanConfigs
{
    public partial class Config
    {
        public class Email
        {
            public class SendGrid
            {
                public static bool Enabled = true;
                public static string EmailSupport { get; set; } = string.Empty;
                public static string Key { get; set; }
                public static string FromName { get; set; } = "Spartan Systems";
                public static string FromEmail { get; set; } = "spartansolution@donotreply.com";
                public static string Subject { get; set; } = "Notifications";
            }
        }
    }
}
