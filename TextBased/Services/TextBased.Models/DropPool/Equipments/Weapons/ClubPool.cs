using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBased.Common.Item.Base;
using TextBased.Common.Pool;
using TextBased.Models.Item.Equipments.Weapons;

namespace TextBased.Models.DropPool
{
  public static partial class Pool
  {
    public static PoolSet<WeaponClubBluePrint> WeaponClubBluePrintPool { get; set; } = new PoolSet<WeaponClubBluePrint>();

    public static void InitWeaponClubBluePrintPool()
    {
      WeaponClubBluePrintPool.InitOrResrt(new List<WeaponClubBluePrint>()
      {
        new WeaponClubBluePrint()
        {
          Id=21,
          Title = "钉头锤",
          ItemName = "钉头锤",
          AttackMin = 1,
          AttackMax = 6,
          DropPercentage = 0m,

        },
        new WeaponClubBluePrint()
        {
          Id=22,
          Title = "流星锤",
          ItemName = "流星锤",
          AttackMin = 2,
          AttackMax = 8,
          DropPercentage = 0m,

        },
        new WeaponClubBluePrint()
        {
          Id=23,
          Title = "碎骨锤",
          ItemName = "碎骨锤",
          AttackMin = 4,
          AttackMax = 12,
          DropPercentage = 0m,

        }
      });
    }
  }
}
