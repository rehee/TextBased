using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBased.Common.Enums;
using TextBased.Common.Item.Base;
using TextBased.Common.Item.Base.ConsumableItem;
using TextBased.Common.Sprites;

namespace TextBased.Models.Item.ConsumableItem
{
  public abstract class ConsumableItemBase : ItemBase, IConsumableItem
  {
    public ConsumableItemBase(string ItemName, int ItemLevel, int Quanty) :
      base(ItemName, ItemLevel, EnumItemType.Consumable)
    {
      this.Quanty = Quanty;
    }
    public int Quanty { get; private set; }

    public virtual void Consume(int consumeNumber = 1, ITarget self = null, ITarget target = null)
    {

    }


  }
}
