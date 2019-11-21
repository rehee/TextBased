using System;
using System.Collections.Generic;
using System.Text;
using TextBased.Common.Enums;
using TextBased.Common.Sprites;
using TextBased.Item.Base;
namespace TextBased.Item.ConsumableItem
{
  public abstract class ConsumableBase : ItemBase, ICunsumable
  {
    public ConsumableBase(int ItemLevel, string ItemName, int Quanty) :
      base(ItemLevel, ItemName, EnumItemType.Consumable)
    {
      this.Quanty = Quanty;
    }
    public int Quanty { get; private set; }

    public virtual ConsumableBase DupeItem()
    {
      return null;
    }
    public virtual void Consume(int consumeNumber = 1, ITarget target = null)
    {

    }
  }
}
