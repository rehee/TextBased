using System;
using System.Collections.Generic;
using System.Text;
using TextBased.Common.Sprites;

namespace TextBased.Item.Base
{
  public interface ICunsumable
  {
    void Consume(int consumeNumber = 1, ITarget target = null);
  }
}
