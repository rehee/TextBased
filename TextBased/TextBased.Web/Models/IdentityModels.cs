using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SDHC.Common.Entity.Models;
using TextBased.Item.ConsumableItem.Portions;
using TextBased.Models.Item.Equipments.Weapons;

namespace TextBased.Web.Models
{
  public class ApplicationUser : SDHCUser
  {
    
  }

  public class ApplicationDbContext : IdentityDbContext<SDHCUser>, IContent
  {
    public ApplicationDbContext()
        : base("DefaultConnection", throwIfV1Schema: false)
    {
    }

    public IDbSet<BaseContent> Contents { get; set; }
    public IDbSet<BaseSelect> Selects { get; set; }
    public DbSet<ApplicationUser> MyUsers { get; set; }
    public DbSet<SCHCContent> SCHCContents { get; set; }

    public DbSet<PotionHP> PotionHPs { get; set; }
    public DbSet<PotionHPItem> PotionsHPItem { get; set; }
    public DbSet<WeaponAxeBluePrint> WeaponAxeBluePrints { get; set; }
    public DbSet<WeaponClubBluePrint> WeaponClubBluePrints { get; set; }
    public DbSet<WeaponSwordBluePrint> WeaponSwordBluePrints { get; set; }
    


    public static ApplicationDbContext Create()
    {
      return new ApplicationDbContext();
    }
  }
}