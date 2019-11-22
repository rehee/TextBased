using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBased.Common.Item.Base;
using TextBased.Models.DropPool;

namespace TextBased
{
  public static class DropFunction
  {
    public static List<IItemBase> GetDropItemBase(decimal noDropAbove = 0m)
    {
      var result = new List<IItemBase>();
      for (var i = 0; i < Basics.MaxItemDropPerTime; i++)
      {
        var checkDropRate = U.GetRandomKey();
        if (noDropAbove > checkDropRate)
        {
          break;
        }
        var itemPoll = U.GetRandomItem(Pool.PoolList);
        if (itemPoll == null)
          continue;
        var items = itemPoll.GetRandomItem(U.GetRandomKey());
        if (items == null)
        {
          continue;
        }
        result.Add(items);
      }
      return result;
    }
  }
}
