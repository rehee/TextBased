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
    public static List<IItemBase> DropItem(decimal noDropRate = 0m)
    {
      var result = new List<IItemBase>();
      for (var i = 0; i < Basics.MaxItemDropPerTime; i++)
      {
        var isNoDrop = U.GetRandomKey();
        if (noDropRate > isNoDrop)
        {
          break;
        }
        var itemPoll = U.GetRandomItem(Pool.DropPool);
        var item = itemPoll.GetNearValue(U.GetRandomKey());
        result.Add(item);
      }
      return result;
    }
  }
}
