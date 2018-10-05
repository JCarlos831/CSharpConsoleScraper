namespace ConsoleScraper
{
    public static class Config
    {
        public static string BaseURL =
            "https://login.yahoo.com/?.intl=us&.lang=en-US&.src=finance&authMechanism=primary&done=https%3A%2F%2Ffinance.yahoo.com%2F&eid=100&add=1";
        
        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "testFinance@yahoo.com";
                public static string Password = "3eggWhites6Almonds";
            }

            public static class Invalid
            {
                public static class Username
                {
                    public static string FourCharacters = "Asdf";
                }

                public static class Password
                {
                    
                }
            }
        }
    }
}