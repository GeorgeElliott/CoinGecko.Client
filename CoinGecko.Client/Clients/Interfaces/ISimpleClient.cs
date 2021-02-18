using CoinGecko.Client.Filters;
using CoinGecko.Client.Models;
using CoinGecko.Client.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoinGecko.Client.Clients.Interfaces
{
    public interface ISimpleClient
    {
        Task<SimplePriceResponse> GetSimplePriceAsDictionary(SimplePriceFilter filter = null);
        Task<IEnumerable<SimplePrice>> GetSimplePriceAsEnumerable(SimplePriceFilter filter = null);
    }
}