using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace System
{
  public static partial class U
  {
    public static decimal GetRandomKey(int from = 0, int to = 1000)
    {
      Random ran = new Random();
      decimal n = ran.Next(from, to) / to;
      return n;
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
        return null;
      }
      if (values <= 0)
      {
        return values2;
      }
      return null;
    }
    public static Value GetNearValue<Value>(this IDictionary<decimal, Value> input, decimal key)
    {
      var nearly = input.Keys.GetNearKey(key);
      if (!nearly.HasValue)
        return default(Value);
      return input[nearly.Value];
    }

    public static BigInteger CalculateBigDecimal(this BigInteger input, decimal times)
    {
      var temp = (int)times * 1000;
      return input * temp / 1000;
    }
  }
}
