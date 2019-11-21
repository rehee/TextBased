using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using TextBased.Common.Enums;
using TextBased.Models.Item.ConsumableItem;

namespace TextBased.Item.ConsumableItem.Portions
{
  public abstract class PotionBase : ConsumableItemBase
  {
    public PotionBase(string ItemName, int Quanty, decimal Amount, int InitCoolDown) :
      base(ItemName, 1, Quanty)
    {
      this.Amount = Amount;
      this.InitCoolDown = InitCoolDown;
    }

    public static void ResetPotionCollDown(int time)
    {
      
    }
    public virtual decimal Amount { get; set; }
    public virtual int InitCoolDown { get; set; }

  }
}
