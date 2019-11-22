using System;
using System.Collections.Generic;
using System.Text;

namespace TextBased.Common.Sprites
{
  public interface IAbility
  {
    int Power { get; set; }
    int Critical { get; set; }
    int Stamin { get; set; }
    int Will { get; set; }
  }
}
