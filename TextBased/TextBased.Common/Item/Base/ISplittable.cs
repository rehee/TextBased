using System;
using System.Collections.Generic;
using System.Text;

namespace TextBased.Common.Item.Base
{
  public interface ISplittable
  {
    ISplittable Split(ISplittable from, ref ISplittable to, int splitAmount);
  }
}
