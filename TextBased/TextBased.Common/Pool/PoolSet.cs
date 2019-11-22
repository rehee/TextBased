using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextBased.Common.Item.Base;

namespace TextBased.Common.Pool
{
  public interface IPoolSet
  {
    IItemBase GetRandomItem(decimal rate);
  }

  public class PoolSet<T> : IPoolSet where T : IItemBase, new()
  {
    public IList<T> ItemPool { get; private set; }
    public IDictionary<decimal, IList<T>> RatePool { get; private set; }
    public PoolSet()
    {
      ItemPool = new List<T>();
      RatePool = new Dictionary<decimal, IList<T>>();
    }

    public void InitOrResrt(IList<T> input)
    {
      try
      {
        ItemPool = input;
        ItemPool.MappingList(RatePool);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    public IList<T> GetSameRateItems(decimal rate)
    {
      return U.GetNearValues<T>(RatePool, rate);
    }
    public IItemBase GetRandomItem(decimal rate)
    {
      var list = GetSameRateItems(rate);
      if (list == null)
        return null;
      return U.GetRandomItem<T>(list);
    }

  }
}
