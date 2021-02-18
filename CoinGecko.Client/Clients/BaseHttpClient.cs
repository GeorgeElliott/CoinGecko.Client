using CoinGecko.Client.Clients.Interfaces;
using CoinGecko.Client.Extensions;
using CoinGecko.Client.Filters;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoinGecko.Client.Clients
{
    public class BaseHttpClient : IBaseHttpClient
    {
        private readonly HttpClient client;

        public BaseHttpClient(HttpClient client)
        {
            this.client = client;
            // TODO: Move URL to settings
            this.client.BaseAddress = new Uri("https://api.coingecko.com/api/v3/");
        }

        public async Task<TResponse> GetAsync<TResponse, TFilter>(string url, TFilter filter = null)
            where TFilter : BaseFilter
        {
            try
            {
                if (filter != null)
                    url += $"?{filter.ToQueryString()}";
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.GetJsonResult<TResponse>();
            }
            catch (Exception exception)
            {
                throw new HttpRequestException(exception.Message);
            }
        }

        public async Task<TResponse> GetAsync<TResponse>(string url)
        {
            try
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.GetJsonResult<TResponse>();
            }
            catch (Exception exception)
            {
                throw new HttpRequestException(exception.Message);
            }
        }
    }
}
