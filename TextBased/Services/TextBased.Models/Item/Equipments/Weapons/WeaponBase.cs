using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBased.Common.Enums.Equips;
using TextBased.Common.Item.Base;
using TextBased.Common.Item.Equipments;

namespace TextBased.Models.Item.Equipments.Weapons
{
  public abstract class WeaponBase : EquipmentBase, IWeapon
  {
    public EnumWeapon WeaponType { get; set; }
    public override IItemBase GeneralBaseIten<T>()
    {
      var item = base.GeneralBaseIten<T>() as WeaponBase;
      item.WeaponType = WeaponType;
      return item;
    }
  }
}
