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
    public ItemBase(string itemName, int itemLevel, EnumItemType itemType) : base()
    {
      this.ItemName = itemName;
      this.ItemLevel = itemLevel;
      this.ItemType = itemType;
    }
    public string ItemName { get; set; }
    public int ItemLevel { get; set; }
    public EnumItemType ItemType { get; set; }

    public long ItemOwnerId { get; set; }
    public long ItemZoneId { get; set; }

    public decimal DropPercentage { get; set; }

    public bool IncoudeInventoryCount { get; set; }
    public bool NotTemplate { get; set; } = true;
    public virtual IItemBase GeneralBaseIten()
    {
      return null;
    }
  }
}
