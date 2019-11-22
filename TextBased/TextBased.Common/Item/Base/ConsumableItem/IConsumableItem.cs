using System;
using System.Collections.Generic;
using System.Text;
using TextBased.Common.Sprites;

namespace TextBased.Common.Item.Base.ConsumableItem
{
  public interface IConsumableItem
  {
    int Quanty { get; set; }
    void Consume(int consumeNumber = 1, ITarget self = null, ITarget target = null);
  }
}
