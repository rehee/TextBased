using SDHC.Common.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBased.Common.Enums;
using TextBased.Common.Item.Base;

namespace TextBased.Models.Item
{
  public abstract class ItemBase : BaseModel, IItemBase
  {
    [InputType(SortOrder = -1)]
    public string ItemName { get; set; }
    [InputType(SortOrder = -2)]
    public virtual int ItemLevel { get; set; }

    [HideEdit]
    public EnumItemType ItemType { get; set; }
    [HideEdit]
    public long ItemOwnerId { get; set; }
    [HideEdit]
    public long ItemZoneId { get; set; }

    [InputType(SortOrder = -3, EditorType = EnumInputType.Text)]
    public decimal DropPercentage { get; set; }
    [HideEdit]
    public bool IncoudeInventoryCount { get; set; }
    [HideEdit]
    public bool IsBluePrint { get; set; } = true;
    [HideEdit]
    public long BluePrintId { get; set; }

    [NotMapped]
    [HideEdit]
    public long BaseId
    {
      get
      {
        return this.Id;
      }
    }

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
