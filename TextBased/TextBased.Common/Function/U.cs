using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using TextBased.Common.Item.Base;

namespace System
{
  public static partial class U
  {
    public static decimal GetRandomKey(int from = 0, int to = 10000)
    {
      Random ran = new Random(DateTime.Now.Millisecond);
      decimal n = ran.Next(from, to) / (decimal)to;
      return n;
    }

    public static T GetRandomItem<T>(IList<T> input)
    {
      Random ran = new Random(DateTime.Now.Millisecond + 2);
      var length = input.Count;
      int n = ran.Next(0, length * 1000) / 1000;
      if (n == length)
      {
        n = n - 1;
      }
      return input[n];
    }

    public static decimal? GetNearKey(this IEnumerable<decimal> keyCollection, decimal key)
    {

      decimal values = keyCollection.Where(b => b > key).OrderBy(b => b).FirstOrDefault();
      decimal values2 = keyCollection.Where(b => b <= key).OrderByDescending(b => b).FirstOrDefault();
      if (values > 0 && values2 > 0)
      {
        return Math.Min(values, values2);
      }
      if (values <= 0 && values2 <= 0)
      {
        return 0;
      }
      if (values <= 0)
      {
        return values2;
      }
      return 0;
    }
    public static Value GetNearValue<Value>(this IDictionary<decimal, Value> input, decimal key)
    {
      var nearly = input.Keys.GetNearKey(key);
      if (!nearly.HasValue)
        return default(Value);
      return input[nearly.Value];
    }
    public static IList<T> GetNearValues<T>(this IDictionary<decimal, IList<T>> input, decimal key)
    {
      var nearly = input.Keys.GetNearKey(key);
      if (!nearly.HasValue)
        return null;
      return input[nearly.Value];
    }
    public static BigInteger CalculateBigDecimal(this BigInteger input, decimal times)
    {
      var temp = (int)times * 1000;
      return input * temp / 1000;
    }

    public static void MappingList<T>(this IList<T> list, IDictionary<decimal, IList<T>> map) where T : IItemBase
    {
      if (map == null)
        return;
      map.Clear();

      list.GroupBy(b => b.DropPercentage)
        .Select(b => new KeyValuePair<decimal, List<T>>(b.Key, b.ToList()))
        .ToList().
        ForEach(b => map.Add(b.Key, b.Value));
    }
  }
}
