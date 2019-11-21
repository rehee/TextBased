using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using TextBased.Common.Enums;

namespace TextBased.Item.ConsumableItem.Portions
{
  public abstract class PotionBase : ConsumableBase
  {
    public PotionBase(string ItemName, int Quanty,decimal Amount, int InitCoolDown) :
      base(1, ItemName, Quanty)
    {
      this.Amount = Amount;
      this.InitCoolDown = InitCoolDown;
    }

    public static int CoolDown { get; private set; }
    public static void ResetPotionCollDown(int time)
    {
      CoolDown = time;
    }
    public decimal Amount { get; private set; }
    public int InitCoolDown { get; private set; }

  }
}
