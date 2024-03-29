﻿using System;
using System.Collections.Generic;
using System.Text;
using TextBased.Common.Enums.Equips;
using TextBased.Common.Item.Base;

namespace TextBased.Common.Item.Equipments
{
  public interface IWeapon : IEquipment
  {
    EnumWeapon WeaponType { get; set; }
  }
}
