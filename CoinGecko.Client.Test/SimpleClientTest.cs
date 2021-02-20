using CoinGecko.Client.Clients;
using CoinGecko.Client.Filters;
using NUnit.Framework;
using System.Linq;
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

            var filter = new SimplePriceFilter(ids, currencies, true);
            var resultAsDictionary = await simpleClient.GetSimplePriceAsDictionary(filter);

            Assert.IsTrue(resultAsDictionary.Count == 1);
            Assert.IsNotNull(resultAsDictionary);
            Assert.IsTrue(resultAsDictionary.FirstOrDefault().Key == "algorand");
            Assert.IsNotNull(resultAsDictionary.FirstOrDefault().Value);
            Assert.IsTrue(resultAsDictionary.FirstOrDefault().Value.FirstOrDefault().Key == "usd");
            Assert.IsNotNull(resultAsDictionary.FirstOrDefault().Value.FirstOrDefault().Value);

            var resultAsList= await simpleClient.GetSimplePriceAsList(filter);

            Assert.IsTrue(resultAsList.Count == 1);
            Assert.IsNotNull(resultAsList);
            Assert.IsTrue(resultAsList.FirstOrDefault().Name == "algorand");
            Assert.IsNotNull(resultAsList.FirstOrDefault().CurrencyEquivalent);
            Assert.IsTrue(resultAsList.FirstOrDefault().CurrencyEquivalent.FirstOrDefault().Name == "usd");
            Assert.IsNotNull(resultAsList.FirstOrDefault().CurrencyEquivalent.FirstOrDefault().Value);
        }
    }
}