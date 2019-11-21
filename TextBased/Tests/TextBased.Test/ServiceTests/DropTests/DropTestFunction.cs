using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextBased.Item.ConsumableItem.Portions;
using TextBased.Models.DropPool;

namespace TextBased.Test.ServiceTests.DropTests
{
  [TestClass]
  public class DropTestFunction
  {
    [TestMethod]
    public void DropTest()
    {
      Pool.Init();
      var Items = DropFunction.DropItem();
      Assert.AreEqual(6, Items.Count);
    }
    [TestMethod]
    public void DropPotion()
    {
      Pool.Init();
      var Items = Pool.PotionPool.Values.FirstOrDefault() as PotionHP;
      var newItem = Items.GeneralBaseIten() as PotionHPItem;
      Assert.AreEqual(Items.Amount, newItem.Amount);
      Items.Amount = 1m;
      Assert.AreEqual(Items.Amount, newItem.Amount);
    }

  }
}
