using CoinGecko.Client.Extensions;

namespace CoinGecko.Client.Filters
{
    public abstract class BaseFilter
    {
        public virtual string ConvertToQueryString(object filterObject)
        {
            return filterObject.ToQueryString();
        }
    }
}
