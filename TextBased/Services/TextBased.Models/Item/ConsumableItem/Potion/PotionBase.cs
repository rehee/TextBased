using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using TextBased.Common.Enums;
using TextBased.Common.Item.Base;
using TextBased.Models.Item.ConsumableItem;

namespace TextBased.Item.ConsumableItem.Portions
{
  public abstract class PotionBase : ConsumableItemBase
  {
    public static void ResetPotionCollDown(int time)
    {
      
    }
    public virtual decimal Amount { get; set; }
    public virtual int InitCoolDown { get; set; }

    public override IItemBase GeneralBaseIten<T>()
    {
      var result = base.GeneralBaseIten<T>() as PotionBase;
      result.Amount = Amount;
      result.InitCoolDown = InitCoolDown;
      return result;
    }

  }
}
