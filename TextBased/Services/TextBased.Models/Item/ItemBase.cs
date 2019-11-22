using SDHC.Common.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBased.Common.Enums;
using TextBased.Common.Item.Base;

namespace TextBased.Models.Item
{
  public abstract class ItemBase : BaseModel, IItemBase
  {
    public string ItemName { get; set; }
    public int ItemLevel { get; set; }
    public EnumItemType ItemType { get; set; }

    public long ItemOwnerId { get; set; }
    public long ItemZoneId { get; set; }

    public decimal DropPercentage { get; set; }

    public bool IncoudeInventoryCount { get; set; }
    public bool IsBluePrint { get; set; } = false;
    public long BluePrintId { get; set; }

    public virtual IItemBase GeneralBaseIten<T>() where T : IItemBase, new()
    {
      var result = new T()
      {
        BluePrintId = this.Id,
        IsBluePrint = true,
        ItemName = ItemName,
        ItemLevel = ItemLevel,
        ItemType = ItemType,
        IncoudeInventoryCount = IncoudeInventoryCount
      };
      return result;
    }
    public virtual IItemBase GeneralBaseIten()
    {
      return null;
    }
  }
}
