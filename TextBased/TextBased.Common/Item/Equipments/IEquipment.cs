using System;
using System.Collections.Generic;
using System.Text;
using TextBased.Common.Enums.Equips;
using TextBased.Common.Item.Base;
using TextBased.Common.Sprites;

namespace TextBased.Common.Item.Equipments
{
  public interface IEquipment : IItemBase, IAbility, IPanelProperty
  {
    EnumEquipType EquipType { get; set; }
  }
}
