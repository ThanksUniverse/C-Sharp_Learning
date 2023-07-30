namespace BlogLast
{
    public static class Configuration
    {
        // Token - JWT (Json Web Token)
        public static string JwtKey = ")r'03&jcj9)>?Gh-F0E-";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "curso-teste-balta";
        public static SmtpConfiguration Smtp = new();

        public class SmtpConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}
