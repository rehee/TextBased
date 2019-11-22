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
      Assert.AreNotEqual(7, Items.Count);
    }
    [TestMethod]
    public void DropPotion()
    {
      Pool.Init();
      var item = Pool.PotionPool.FirstOrDefault();
      var item2 = item.GeneralBaseIten();
      Assert.AreEqual(item.ItemName, item2.ItemName);
    }

  }
}
