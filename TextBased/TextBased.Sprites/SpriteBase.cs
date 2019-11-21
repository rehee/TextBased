using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using TextBased.Common.Sprites;
using TextBased.Item.ConsumableItem;

namespace TextBased.Sprites
{
  public class SpriteBase : ITarget
  {
    public string Name { get; set; }
    public BigInteger MaxHp { get; set; }
    public BigInteger CurrentHp { get; set; }
    public bool IsTargetAble { get; set; }

    public ITarget Target { get; private set; }
    public virtual void GetTarget(ITarget target)
    {
      this.Target = target;
    }

    public IDictionary<int, ConsumableBase> ConsumableSlots { get; set; }


  }
}
