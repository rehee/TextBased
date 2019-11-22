using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBased.Common.Enums.Equips;
using TextBased.Common.Item.Base;

namespace TextBased.Models.Item.Equipments.Weapons
{
  public class WeaponSwordBluePrint : WeaponBase
  {
    public WeaponSwordBluePrint()
    {
      this.WeaponType = EnumWeapon.Sword;
    }
    public override IItemBase GeneralBaseIten()
    {
      return this.GeneralBaseIten<WeaponSwordBluePrint>();
    }
  }
}
