using CoinGecko.Client.Models;
using CoinGecko.Client.Response;
using System.Collections.Generic;
using System.Linq;

namespace CoinGecko.Client.Extensions
{
    public static class MappingExtensions
    {
        public static IList<SimplePrice> DictionaryToSimplePriceList(this SimplePriceResponse simplePrices)
        {
            return simplePrices.Select(x => new SimplePrice
            {
                Name = x.Key,
                CurrencyEquivalent = x.Value.Select(f => new CurrencyEquivalent
                {
                    Name = f.Key,
                    Value = f.Value
                }).ToList()
            }).ToList();
        }
    }
}
