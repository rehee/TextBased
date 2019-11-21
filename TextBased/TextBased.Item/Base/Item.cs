using System;
using System.Collections.Generic;
using System.Text;
using TextBased.Common.Enums;

namespace TextBased.Item.Base
{
  public abstract class ItemBase
  {
    public ItemBase(int ItemLevel, string ItemName, EnumItemType ItemType)
    {
      this.ItemLevel = ItemLevel;
      this.ItemName = ItemName;
      this.ItemType = ItemType;
    }
    public int ItemLevel { get; private set; }
    public string ItemName { get; private set; }
    public EnumItemType ItemType { get; private set; }

  }
}
