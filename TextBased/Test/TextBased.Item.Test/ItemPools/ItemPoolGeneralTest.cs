using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextBased.Item.Base;
using System.Linq;

namespace TextBased.Item.Test.ItemPools
{
  /// <summary>
  /// Summary description for ItemPoolGeneralTest
  /// </summary>
  [TestClass]
  public class ItemPoolGeneralTest
  {
    public ItemPoolGeneralTest()
    {
      //
      // TODO: Add constructor logic here
      //
    }

    private TestContext testContextInstance;

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext
    {
      get
      {
        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

    #region Additional test attributes
    //
    // You can use the following additional attributes as you write your tests:
    //
    // Use ClassInitialize to run code before running the first test in the class
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // Use ClassCleanup to run code after all tests in a class have run
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    // Use TestInitialize to run code before running each test 
    // [TestInitialize()]
    // public void MyTestInitialize() { }
    //
    // Use TestCleanup to run code after each test has run
    // [TestCleanup()]
    // public void MyTestCleanup() { }
    //
    #endregion

    [TestMethod]
    public void TestGenerate()
    {
      var keys = new List<decimal>()
      {
        0.16m,0.2m,0.3m,0.4m,0.5m,0.6m,0.7m,0.8m
      };
      var expectValue = keys.Select(b => ItemPool.PotionBaseList.GetNearValue(b)).ToList().Select(b => b != null ? b() : null).ToList();
      var actual = keys.Select(b => ItemPool.DropItem(0.5m, b)).ToList();
      for (var i = 0; i < keys.Count; i++)
      {
        if (expectValue != null)
        {
          continue;
        }
        Assert.AreEqual(expectValue[i].ItemName, actual[i].ItemName);
      }
    }
  }
}
