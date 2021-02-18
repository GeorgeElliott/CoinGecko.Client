namespace CoinGecko.Client.Filters
{
    public class SimplePriceFilter : BaseFilter
    {
        public SimplePriceFilter(string[] ids = null, string[] currencies = null)
        {
            Ids = ids;
            Vs_Currencies = currencies;
        }

        public string[] Ids { get; }

        public string[] Vs_Currencies { get; }
    }
}
