namespace CoinGecko.Client.Filters
{
    public class SimplePriceFilter : BaseFilter
    {
        public SimplePriceFilter(string[] ids = null, string[] vsCurrencies = null, bool? includeMarketCap = null, bool? include24hrVol = null, bool? include24hrChange = null, bool? includeLastUpdatedAt = null)
        {
            Ids = ids;
            Vs_Currencies = vsCurrencies;
            Include_24Hr_Change = include24hrChange;
            Include_Last_Updated_At = includeLastUpdatedAt;
            Include_Market_Cap = includeMarketCap;
            Include_24Hr_Vol = include24hrVol;
        }

        public string[] Ids { get; }

        public string[] Vs_Currencies { get; }
        public bool? Include_24Hr_Change { get; }
        public bool? Include_Last_Updated_At { get; }
        public bool? Include_Market_Cap { get; }
        public bool? Include_24Hr_Vol { get; }
    }
}
