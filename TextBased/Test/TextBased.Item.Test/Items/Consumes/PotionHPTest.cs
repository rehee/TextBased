using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextBased.Common.Sprites;
using TextBased.Item.ConsumableItem.Portions;

namespace TextBased.Item.Test.Items.Consumes
{
  [TestClass]
  public class PotionHPTest
  {
    [TestMethod]
    public void Potion_HP_Drink()
    {
      var sp = new SpriteBase();
      sp.MaxHp = 100;
      sp.CurrentHp = 1;
      var potionHp = new PotionHP("微型生命药水", 1, 0.15m, 10);
      potionHp.Consume(1, sp);

    }
  }
}
