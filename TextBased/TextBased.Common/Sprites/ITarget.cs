using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TextBased.Common.Sprites
{
  public interface ITarget
  {
    string Name { get; set; }
    BigInteger MaxHp { get; set; }
    BigInteger CurrentHp { get; set; }
    bool IsTargetAble { get; set; }
  }
}
