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
    public static PoolSet<WeaponSwordBluePrint> WeaponSwordBluePrintPool { get; set; } = new PoolSet<WeaponSwordBluePrint>();

    public static void InitWeaponSwordBluePrintPool()
    {
      WeaponSwordBluePrintPool.InitOrResrt(new List<WeaponSwordBluePrint>()
      {
        new WeaponSwordBluePrint()
        {
          Id=11,
          Title = "短剑",
          ItemName = "短剑",
          AttackMin = 1,
          AttackMax = 6,
          DropPercentage = 0m,

        },
        new WeaponSwordBluePrint()
        {
          Id=12,
          Title = "长剑",
          ItemName = "长剑",
          AttackMin = 2,
          AttackMax = 8,
          DropPercentage = 0m,

        },
        new WeaponSwordBluePrint()
        {
          Id=13,
          Title = "双手剑",
          ItemName = "双手剑",
          AttackMin = 4,
          AttackMax = 12,
          DropPercentage = 0m,

        }
      });
    }
  }
}
