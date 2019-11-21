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
    public static Dictionary<decimal, IItemBase> PotionPool { get; set; }

    public static List<Dictionary<decimal, IItemBase>> DropPool { get; set; } = new List<Dictionary<decimal, IItemBase>>()
    {
      PotionPool
    };


    public static void Init()
    {
      PotionPool = new Dictionary<decimal, IItemBase>()
      {
        [0.30m] = new PotionHP("小药水", 1, 0.30m, 15),
        [0.60m] = new PotionHP("中药水", 1, 0.60m, 30),
        [0.90m] = new PotionHP("大药水", 1, 0.90m, 45),
      };
    }
  }
}
