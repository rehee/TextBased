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
    public static IList<IPoolSet> PoolList { get; set; } = new List<IPoolSet>()
    {
      PotionPool,WeaponSwordBluePrintPool,WeaponClubBluePrintPool
    };

    public static void Init()
    {
      InitPotionPool();
      InitWeaponSwordBluePrintPool();
      InitWeaponClubBluePrintPool();
    }
  }
}
