using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoinGecko.Client.Extensions
{
    public static class ClientExtensions
    {
        public static async Task<T> GetJsonResult<T>(this HttpContent response) => JsonConvert.DeserializeObject<T>(await response.ReadAsStringAsync());
    }
}
