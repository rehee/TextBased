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
      Basics.MaxItemDropPerTime = 99;
      var Items = DropFunction.GetDropItemBase();
      Assert.AreNotEqual(7, Items.Count);
    }


  }
}
