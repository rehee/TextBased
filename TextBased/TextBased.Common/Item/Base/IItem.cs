using System;
using System.Collections.Generic;
using System.Text;
using TextBased.Common.Enums;

namespace TextBased.Common.Item.Base
{
  public interface IItemBase
  {
    string ItemName { get; set; }
    int ItemLevel { get; set; }
    EnumItemType ItemType { get; set; }
    decimal DropPercentage { get; set; }
    bool IsBluePrint { get; set; }
    bool IncoudeInventoryCount { get; set; }
    long BluePrintId { get; set; }
    IItemBase GeneralBaseIten<T>() where T : IItemBase, new();
    IItemBase GeneralBaseIten();
  }

}
