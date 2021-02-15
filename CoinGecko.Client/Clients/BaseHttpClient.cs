using CoinGecko.Client.Extensions;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoinGecko.Client.Clients
{
    public class BaseHttpClient
    {
        private readonly HttpClient client;

        public BaseHttpClient(HttpClient client)
        {
            this.client = client;
        }

        public async Task<T> GetAsync<T>(string url)
        {
            try
            {
                var response = await client.GetAsync(new Uri(url));
                response.EnsureSuccessStatusCode();
                return await response.Content.GetJsonResult<T>();
            }
            catch (Exception exception)
            {
                throw new HttpRequestException(exception.Message);
            }
        }
    }
}
