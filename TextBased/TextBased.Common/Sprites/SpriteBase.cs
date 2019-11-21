using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TextBased.Common.Sprites
{
  public class SpriteBase : ITarget
  {
    public string Name { get; set; }
    public BigInteger MaxHp { get; set; }
    public BigInteger CurrentHp { get; set; }
    public bool IsTargetAble { get; set; }

  }
}
