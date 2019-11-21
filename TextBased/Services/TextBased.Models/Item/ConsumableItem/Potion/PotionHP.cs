using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextBased.Common.Item.Base;
using TextBased.Common.Sprites;
using TextBased.Models.DropPool;

namespace TextBased.Item.ConsumableItem.Portions
{
  public class PotionHP : PotionBase
  {
    public PotionHP(string ItemName, int Quanty, decimal Amount, int InitCoolDown) :
      base(ItemName, Quanty, Amount, InitCoolDown)
    {
    }
    public override void Consume(int consumeNumber = 1, ITarget self = null, ITarget target = null)
    {
      base.Consume(consumeNumber, target);
      //if (CoolDown > 0)
      //{
      //  return;
      //}
      if (target.CurrentHp >= target.MaxHp)
      {
        return;
      }
      var recoverHp = target.MaxHp.CalculateBigDecimal(Amount);
      var tempHp = target.CurrentHp + recoverHp;
      if (tempHp >= target.MaxHp)
      {
        target.CurrentHp = target.MaxHp;
      }
      target.CurrentHp = tempHp;
      ResetPotionCollDown(InitCoolDown);
    }
    public override IItemBase GeneralBaseIten()
    {
      return new PotionHPItem(ItemName, Quanty, Amount, InitCoolDown)
      {
      };
    }
  }
  public class PotionHPItem : PotionHP
  {
    public PotionHPItem(string ItemName, int Quanty, decimal Amount, int InitCoolDown) :
      base(ItemName, Quanty, Amount, InitCoolDown)
    {
      NotTemplate = true;
    }
    public override decimal Amount
    {
      get
      {
        var poolItem = Pool.PotionPool.Values.Where(b => b.ItemName == ItemName).FirstOrDefault();
        if (poolItem != null)
        {
          return (poolItem as PotionHP).Amount;
        }
        return base.Amount;
      }
    }
  }
}
