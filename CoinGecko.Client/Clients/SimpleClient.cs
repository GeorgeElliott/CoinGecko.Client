using CoinGecko.Client.Clients.Interfaces;
using CoinGecko.Client.Extensions;
using CoinGecko.Client.Filters;
using CoinGecko.Client.Models;
using CoinGecko.Client.Response;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoinGecko.Client.Clients
{
    public class SimpleClient : BaseHttpClient, ISimpleClient
    {
        private readonly string baseRoute = "simple";

        public SimpleClient(HttpClient client) : base(client)
        {
        }

        public async Task<IList<SimplePrice>> GetSimplePriceAsList(SimplePriceFilter filter = null)
        {
            var response = await GetSimplePriceAsDictionary(filter);
            return response.DictionaryToSimplePriceList();
        }

        public async Task<SimplePriceResponse> GetSimplePriceAsDictionary(SimplePriceFilter filter = null)
        {
            var apiUrl = $"{baseRoute}/price";
            if (filter != null)
                apiUrl += $"?{filter.ConvertToQueryString(filter)}";
            return await GetAsync<SimplePriceResponse>(apiUrl);
        }
    }
}
