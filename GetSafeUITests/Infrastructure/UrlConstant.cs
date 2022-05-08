namespace GetSafeUITests.Infrastructure
{
    internal static class UrlConstant
    {
        private const string Protocol = "https://";
        private const string Start = "start.";
        private const string HelloGetSafe = "hellogetsafe.com/";
        private const string Lang = "en-de/";
        private const string Flows = "flows/";
        public static string StartHelloGetSafe => Protocol + Start + HelloGetSafe + Lang + Flows;

        public static class Liability
        {
            public static string Main => StartHelloGetSafe + "liability/";
            public static string Family => Main + "liability_family";
            public static string Zip => Main + "liability_zip";
            public static string Deductibles => Main + "liability_deductibles";
            public static string PrevOwner => Main + "liability_previously_owned";
            public static string Drone => Main + "liability_drone";
            public static string QuoteStep => Main + "liability_quote_step";
        }
    }
}