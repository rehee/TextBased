using System;
using System.Collections.Generic;
using System.Text;
using TextBased.Item.Base;
using TextBased.Item.ConsumableItem.Portions;

namespace TextBased.Item
{
  public static partial class ItemPool
  {
    public static IDictionary<Decimal, Func<ItemBase>> PotionBaseList { get; set; } = new Dictionary<Decimal, Func<ItemBase>>()
    {
      [0.15m] = () => new PotionHP("微型生命药水", 1, 0.15m, 10),
      [0.25m] = () => new PotionHP("小型生命药水", 1, 0.30m, 20),
      [0.35m] = () => new PotionHP("中型生命药水", 1, 0.45m, 30),
      [0.45m] = () => new PotionHP("大型生命药水", 1, 0.60m, 40),
      [0.65m] = () => new PotionHP("巨型生命药水", 1, 0.75m, 50),
      [0.75m] = () => new PotionHP("最大生命药水", 1, 1.00m, 60),
    };
  }
}
