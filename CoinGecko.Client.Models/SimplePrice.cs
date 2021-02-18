using System;
using System.Linq;
using System.Collections.Generic;

namespace CoinGecko.Client.Models
{
    public class SimplePrice
    {
        public string Name { get; set; }
        public IEnumerable<CurrencyEquivalent> FiatPricing { get; set; }

        public IEnumerable<SimplePrice> DictionaryToSimplePriceList(SimplePriceResponse simplePrices)
        {
            return simplePrices.Select(x => new SimplePrice
            {
                Name = x.Key,
                FiatPricing = x.Value.Select(f => new CurrencyEquivalent
                {
                    Name = f.Key,
                    Value = f.Value
                })
            });
        }
    }
}
