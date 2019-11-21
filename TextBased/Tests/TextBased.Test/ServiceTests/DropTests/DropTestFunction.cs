using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
      var Items = Pool.PotionPool.Values.FirstOrDefault();
      var newItem = Items.GeneralBaseIten();
      Console.WriteLine("");
    }

  }
}
