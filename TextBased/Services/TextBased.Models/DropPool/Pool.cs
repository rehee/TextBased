using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBased.Common.Item.Base;
using TextBased.Item.ConsumableItem.Portions;

namespace TextBased.Models.DropPool
{
  public static partial class Pool
  {
    public static List<IItemBase> PotionPool { get; set; }
    public static Dictionary<decimal, List<IItemBase>> PotionDropPool { get; set; } = new Dictionary<decimal, List<IItemBase>>();

    public static List<Dictionary<decimal, List<IItemBase>>> DropPool { get; set; } = new List<Dictionary<decimal, List<IItemBase>>>()
    {
      PotionDropPool
    };

    public static void Init()
    {
      PotionPool = new List<IItemBase>()
      {
        new PotionHP()
        {
          Id=1,
          Title = "小药水",
          ItemName = "小药水",
          Quanty = 1,
          Amount = 0.15m,
          InitCoolDown = 15,
          DropPercentage = 0.15m,

        },
        new PotionHP()
        {
          Id=2,
          Title = "中药水",
          ItemName = "中药水",
          Quanty = 1,
          Amount = 0.15m,
          InitCoolDown = 15,
          DropPercentage = 0.60m,
        },
        new PotionHP()
        {
          Id=3,
          Title = "大药水",
          ItemName = "大药水",
          Quanty = 1,
          Amount = 0.15m,
          InitCoolDown = 15,
          DropPercentage = 0.75m,
        }
      };
      PotionDropPool.Clear();

      PotionPool.GroupBy(b => b.DropPercentage)
        .Select(b => new KeyValuePair<decimal, List<IItemBase>>(b.Key, b.ToList()))
        .ToList().
        ForEach(b => PotionDropPool.Add(b.Key, b.Value));

    }
  }
}
