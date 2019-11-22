using Microsoft.Owin;
using Owin;
using Start;
using System.Web.Hosting;
using TextBased.Web.Models;
using System;
using System.Collections.Generic;
using TextBased.Item.ConsumableItem.Portions;
using TextBased.Models.Item.Equipments.Weapons;

[assembly: OwinStartupAttribute(typeof(TextBased.Web.Startup))]
namespace TextBased.Web
{
  public partial class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      SDHCStartup.Init<ApplicationDbContext, SCHCContent, SDHCBascSelect, ApplicationUser>(
          app, () => ApplicationDbContext.Create(), HostingEnvironment.MapPath("/"));
      ModelManager.ModelMapper = new Dictionary<string, Type>()
      {
        ["PotionHP"] = typeof(PotionHP),
        ["WeaponAxeBluePrints"] = typeof(WeaponAxeBluePrint),
        ["WeaponClubBluePrint"] = typeof(WeaponClubBluePrint),
        ["WeaponSwordBluePrint"] = typeof(WeaponSwordBluePrint)
      };

    }
  }
}
