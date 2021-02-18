using CoinGecko.Client.Filters;
using System.Threading.Tasks;

namespace CoinGecko.Client.Clients.Interfaces
{
    public interface IBaseHttpClient
    {
        Task<TResponse> GetAsync<TResponse>(string url);
        Task<TResponse> GetAsync<TResponse, TFilter>(string url, TFilter filter = null) where TFilter : BaseFilter;
    }
}