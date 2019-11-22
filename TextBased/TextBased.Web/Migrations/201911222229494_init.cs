namespace TextBased.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaseContents",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        Url = c.String(),
                        DisplayOrder = c.Long(nullable: false),
                        CreateTime = c.DateTime(),
                        ParentId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BaseContents", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(),
                        WeChatOpenId = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.PotionHPs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InitCoolDown = c.Int(nullable: false),
                        Quanty = c.Int(nullable: false),
                        Title = c.String(),
                        ItemName = c.String(),
                        ItemLevel = c.Int(nullable: false),
                        ItemType = c.Int(nullable: false),
                        ItemOwnerId = c.Long(nullable: false),
                        ItemZoneId = c.Long(nullable: false),
                        DropPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IncoudeInventoryCount = c.Boolean(nullable: false),
                        IsBluePrint = c.Boolean(nullable: false),
                        BluePrintId = c.Long(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.BaseSelects",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeaponAxeBluePrints",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        WeaponType = c.Int(nullable: false),
                        EquipType = c.Int(nullable: false),
                        Power = c.Int(nullable: false),
                        Critical = c.Int(nullable: false),
                        Stamin = c.Int(nullable: false),
                        Will = c.Int(nullable: false),
                        AttackMin = c.Long(nullable: false),
                        AttackMax = c.Long(nullable: false),
                        Armor = c.Long(nullable: false),
                        DamageReduce = c.Long(nullable: false),
                        CriticalRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CriticalMultiple = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Title = c.String(),
                        ItemName = c.String(),
                        ItemLevel = c.Int(nullable: false),
                        ItemType = c.Int(nullable: false),
                        ItemOwnerId = c.Long(nullable: false),
                        ItemZoneId = c.Long(nullable: false),
                        DropPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IncoudeInventoryCount = c.Boolean(nullable: false),
                        IsBluePrint = c.Boolean(nullable: false),
                        BluePrintId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeaponClubBluePrints",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        WeaponType = c.Int(nullable: false),
                        EquipType = c.Int(nullable: false),
                        Power = c.Int(nullable: false),
                        Critical = c.Int(nullable: false),
                        Stamin = c.Int(nullable: false),
                        Will = c.Int(nullable: false),
                        AttackMin = c.Long(nullable: false),
                        AttackMax = c.Long(nullable: false),
                        Armor = c.Long(nullable: false),
                        DamageReduce = c.Long(nullable: false),
                        CriticalRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CriticalMultiple = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Title = c.String(),
                        ItemName = c.String(),
                        ItemLevel = c.Int(nullable: false),
                        ItemType = c.Int(nullable: false),
                        ItemOwnerId = c.Long(nullable: false),
                        ItemZoneId = c.Long(nullable: false),
                        DropPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IncoudeInventoryCount = c.Boolean(nullable: false),
                        IsBluePrint = c.Boolean(nullable: false),
                        BluePrintId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeaponSwordBluePrints",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        WeaponType = c.Int(nullable: false),
                        EquipType = c.Int(nullable: false),
                        Power = c.Int(nullable: false),
                        Critical = c.Int(nullable: false),
                        Stamin = c.Int(nullable: false),
                        Will = c.Int(nullable: false),
                        AttackMin = c.Long(nullable: false),
                        AttackMax = c.Long(nullable: false),
                        Armor = c.Long(nullable: false),
                        DamageReduce = c.Long(nullable: false),
                        CriticalRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CriticalMultiple = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Title = c.String(),
                        ItemName = c.String(),
                        ItemLevel = c.Int(nullable: false),
                        ItemType = c.Int(nullable: false),
                        ItemOwnerId = c.Long(nullable: false),
                        ItemZoneId = c.Long(nullable: false),
                        DropPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IncoudeInventoryCount = c.Boolean(nullable: false),
                        IsBluePrint = c.Boolean(nullable: false),
                        BluePrintId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.BaseContents", "ParentId", "dbo.BaseContents");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.BaseContents", new[] { "ParentId" });
            DropTable("dbo.WeaponSwordBluePrints");
            DropTable("dbo.WeaponClubBluePrints");
            DropTable("dbo.WeaponAxeBluePrints");
            DropTable("dbo.BaseSelects");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PotionHPs");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.BaseContents");
        }
    }
}
