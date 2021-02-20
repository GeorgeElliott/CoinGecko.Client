using System.Linq;
using System.Collections.Generic;
using CoinGecko.Client.Response;

namespace CoinGecko.Client.Models
{
    public class SimplePrice
    {
        public string Name { get; set; }
        public IList<CurrencyEquivalent> CurrencyEquivalent { get; set; }

        public IList<SimplePrice> DictionaryToSimplePriceList(SimplePriceResponse simplePrices)
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
