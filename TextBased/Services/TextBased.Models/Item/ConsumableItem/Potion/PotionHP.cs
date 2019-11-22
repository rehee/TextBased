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
    public PotionHP() : base()
    {
      Quanty = 1;
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
    public override IItemBase GeneralBaseIten<T>()
    {
      var hpPotion = base.GeneralBaseIten<PotionHPItem>();
      return hpPotion;
    }
    public override IItemBase GeneralBaseIten()
    {
      return GeneralBaseIten<PotionHPItem>();
    }
  }
  public class PotionHPItem : PotionHP
  {

  }
}
