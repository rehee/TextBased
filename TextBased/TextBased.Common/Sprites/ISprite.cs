using System;
using System.Collections.Generic;
using System.Text;

namespace TextBased.Common.Sprites
{
  public interface ISprite : ITarget, IAbility, IPanelProperty
  {
    bool IsNpc { get; set; }
    ISprite CreateSpriteInstance<T>() where T : ISprite, new();

    long BluePointId { get; set; }
  }
}
