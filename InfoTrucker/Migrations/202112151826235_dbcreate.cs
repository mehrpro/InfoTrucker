namespace InfoTrucker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 20),
                        UserPassword = c.String(nullable: false, maxLength: 100),
                        FullName = c.String(nullable: false, maxLength: 200),
                        Editor = c.String(nullable: false, maxLength: 10),
                        LimetedCompany = c.Boolean(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Cleams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID_FK = c.Int(nullable: false),
                        GroupID_FK = c.Int(nullable: false),
                        MenuItemID_FK = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MenuGroups", t => t.GroupID_FK)
                .ForeignKey("dbo.MenuItems", t => t.MenuItemID_FK)
                .ForeignKey("dbo.ApplicationUsers", t => t.UserID_FK)
                .Index(t => t.UserID_FK)
                .Index(t => t.GroupID_FK)
                .Index(t => t.MenuItemID_FK);
            
            CreateTable(
                "dbo.MenuGroups",
                c => new
                    {
                        GroupID = c.Int(nullable: false, identity: true),
                        MenuGroupTitle = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.GroupID);
            
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        GroupID_FK = c.Int(nullable: false),
                        ItemTitel = c.String(nullable: false, maxLength: 150),
                        Description = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.ItemID)
                .ForeignKey("dbo.MenuGroups", t => t.GroupID_FK)
                .Index(t => t.GroupID_FK);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FName = c.String(nullable: false, maxLength: 150),
                        LName = c.String(nullable: false, maxLength: 250),
                        FatherName = c.String(maxLength: 100),
                        Tavalod = c.DateTime(nullable: false),
                        CodeMelei = c.String(nullable: false),
                        Takalof = c.Byte(nullable: false),
                        SerialShenasnameh = c.String(maxLength: 15),
                        Shenasnameh = c.String(maxLength: 11),
                        MahelTavalod = c.String(maxLength: 100),
                        Hoshmand = c.String(maxLength: 20),
                        Sh_Bimeh = c.String(maxLength: 20),
                        Sh_Goyahinameh = c.String(maxLength: 20),
                        HoshmandNavgan = c.String(maxLength: 20),
                        Sh_Plak = c.String(maxLength: 10),
                        Kamion = c.String(maxLength: 10),
                        Sh_Sokht = c.String(maxLength: 20),
                        Tel = c.String(maxLength: 11),
                        Mobile1 = c.String(maxLength: 11),
                        Mobile2 = c.String(maxLength: 11),
                        CodePosti = c.String(maxLength: 10, fixedLength: true),
                        Address = c.String(nullable: false, maxLength: 250),
                        IsActive = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        DateRegister = c.DateTime(nullable: false),
                        UserID_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.ApplicationUsers", t => t.UserID_FK)
                .Index(t => t.UserID_FK);
            
            CreateTable(
                "dbo.PublicTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Group = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "UserID_FK", "dbo.ApplicationUsers");
            DropForeignKey("dbo.Cleams", "UserID_FK", "dbo.ApplicationUsers");
            DropForeignKey("dbo.MenuItems", "GroupID_FK", "dbo.MenuGroups");
            DropForeignKey("dbo.Cleams", "MenuItemID_FK", "dbo.MenuItems");
            DropForeignKey("dbo.Cleams", "GroupID_FK", "dbo.MenuGroups");
            DropIndex("dbo.People", new[] { "UserID_FK" });
            DropIndex("dbo.MenuItems", new[] { "GroupID_FK" });
            DropIndex("dbo.Cleams", new[] { "MenuItemID_FK" });
            DropIndex("dbo.Cleams", new[] { "GroupID_FK" });
            DropIndex("dbo.Cleams", new[] { "UserID_FK" });
            DropTable("dbo.PublicTypes");
            DropTable("dbo.People");
            DropTable("dbo.MenuItems");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Cleams");
            DropTable("dbo.ApplicationUsers");
        }
    }
}
