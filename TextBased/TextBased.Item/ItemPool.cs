using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextBased.Item.Base;
using TextBased.Item.ConsumableItem.Portions;

namespace TextBased.Item
{
  public static partial class ItemPool
  {
    public static IDictionary<decimal, IDictionary<Decimal, Func<ItemBase>>> DropPool { get; set; } = new Dictionary<decimal, IDictionary<Decimal, Func<ItemBase>>>()
    {
      [0.49m] = null,
      [0.5m] = PotionBaseList,
    };

    public static decimal GetRandomKey()
    {
      Random ran = new Random();
      decimal n = ran.Next(0, 1000) / 1000;
      return n;
    }

    public static ItemBase DropItem(decimal key1, decimal key2)
    {

      var pool = DropPool.GetNearValue(key1);
      if (pool == null)
        return null;
      var itemPool = pool.GetNearValue(key2);
      if (itemPool == null)
        return null;
      return itemPool();
    }
  }
}
