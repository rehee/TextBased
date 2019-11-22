using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBased.Common.Enums.Equips;
using TextBased.Common.Item.Base;
using TextBased.Common.Item.Equipments;

namespace TextBased.Models.Item.Equipments
{
  public abstract class EquipmentBase : ItemBase, IEquipment
  {
    public EnumEquipType EquipType { get; set; }
    public int Power { get; set; }
    public int Critical { get; set; }
    public int Stamin { get; set; }
    public int Will { get; set; }
    public long AttackMin { get; set; }
    public long AttackMax { get; set; }
    public long Armor { get; set; }
    public long DamageReduce { get; set; }
    public decimal CriticalRate { get; set; }
    public decimal CriticalMultiple { get; set; }

    public override IItemBase GeneralBaseIten<T>()
    {
      var item = base.GeneralBaseIten<T>() as EquipmentBase;
      item.Power = Power;
      item.EquipType = EquipType;
      item.Critical = Critical;
      item.Stamin = Stamin;
      item.Will = Will;
      item.AttackMin = AttackMin;
      item.AttackMax = AttackMax;
      item.Armor = Armor;
      item.DamageReduce = DamageReduce;
      item.CriticalRate = CriticalRate;
      item.CriticalMultiple = CriticalMultiple;

      return item;
    }
  }
}
