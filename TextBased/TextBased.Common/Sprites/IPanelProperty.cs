using System;
using System.Collections.Generic;
using System.Text;

namespace TextBased.Common.Sprites
{
  public interface IPanelProperty
  {
    long AttackMin { get; set; }
    long AttackMax { get; set; }
    long Armor { get; set; }
    long DamageReduce { get; set; }

    decimal CriticalRate { get; set; }
    decimal CriticalMultiple { get; set; }

  }
}
