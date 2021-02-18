using CoinGecko.Client.Clients;
using CoinGecko.Client.Filters;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoinGecko.Client.Test
{
    public class SimpleClientTest
    {
        private readonly SimpleClient simpleClient;
        public SimpleClientTest()
        {
            simpleClient = new SimpleClient(new HttpClient());
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test_Simple_Price_Returns_Data()
        {
            var ids = new [] {
                "algorand"
            };
            var currencies = new[]
            {
                "usd"
            };
            var filter = new SimplePriceFilter(ids, currencies);
            var resultAsDictionary = await simpleClient.GetSimplePriceAsDictionary(filter);
            var resultAsList= await simpleClient.GetSimplePriceAsEnumerable(filter);
            Assert.Pass();
        }
    }
}