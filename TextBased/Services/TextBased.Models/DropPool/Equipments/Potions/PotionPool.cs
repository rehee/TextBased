using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBased.Common.Item.Base;
using TextBased.Common.Pool;
using TextBased.Item.ConsumableItem.Portions;

namespace TextBased.Models.DropPool
{
  public static partial class Pool
  {
    public static PoolSet<PotionHP> PotionPool { get; set; } = new PoolSet<PotionHP>();

    public static void InitPotionPool()
    {
      PotionPool.InitOrResrt(new List<PotionHP>()
      {
        new PotionHP()
        {
          Id=1,
          Title = "小药水",
          ItemName = "小药水",
          Quanty = 1,
          Amount = 0.15m,
          InitCoolDown = 15,
          DropPercentage = 0m,

        },
        new PotionHP()
        {
          Id=2,
          Title = "中药水",
          ItemName = "中药水",
          Quanty = 1,
          Amount = 0.15m,
          InitCoolDown = 15,
          DropPercentage = 0m,
        },
        new PotionHP()
        {
          Id=3,
          Title = "大药水",
          ItemName = "大药水",
          Quanty = 1,
          Amount = 0.15m,
          InitCoolDown = 15,
          DropPercentage = 0m,
        }
      });
    }
  }
}
