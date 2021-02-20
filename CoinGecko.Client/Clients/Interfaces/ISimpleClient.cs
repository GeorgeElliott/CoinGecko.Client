using CoinGecko.Client.Filters;
using CoinGecko.Client.Models;
using CoinGecko.Client.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoinGecko.Client.Clients.Interfaces
{
    public interface ISimpleClient
    {
        Task<IList<SimplePrice>> GetSimplePriceAsList(SimplePriceFilter filter = null);
        Task<SimplePriceResponse> GetSimplePriceAsDictionary(SimplePriceFilter filter = null);
        Task<IList<string>> GetSimpleSupportVsCurrenciesAsList();
    }
}