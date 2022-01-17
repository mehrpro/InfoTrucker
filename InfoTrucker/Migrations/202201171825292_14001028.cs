namespace InfoTrucker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _14001028 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankAccNums",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 150),
                        BankName = c.String(nullable: false, maxLength: 100),
                        AccNumber = c.String(maxLength: 15),
                        AccCart = c.String(maxLength: 19),
                        AccISBN = c.String(maxLength: 26),
                        Editor = c.String(maxLength: 150),
                        CenterID_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Centers", t => t.CenterID_FK)
                .Index(t => t.CenterID_FK);
            
            CreateTable(
                "dbo.Centers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CenterTitle = c.String(nullable: false, maxLength: 300),
                        TokenKey = c.String(nullable: false, maxLength: 450),
                        Description = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cashes",
                c => new
                    {
                        CashID = c.Int(nullable: false, identity: true),
                        QueueID_FK = c.Int(nullable: false),
                        Pos = c.Int(),
                        CashDesk = c.Int(),
                        userID = c.Byte(nullable: false),
                        seriesID_FK = c.Int(nullable: false),
                        CenterID_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CashID)
                .ForeignKey("dbo.Queues", t => t.QueueID_FK)
                .ForeignKey("dbo.Users", t => t.userID)
                .ForeignKey("dbo.SeriesPrices", t => t.seriesID_FK)
                .ForeignKey("dbo.Centers", t => t.CenterID_FK)
                .Index(t => t.QueueID_FK)
                .Index(t => t.userID)
                .Index(t => t.seriesID_FK)
                .Index(t => t.CenterID_FK);
            
            CreateTable(
                "dbo.Queues",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Number = c.Short(nullable: false),
                        GroupCommission = c.Byte(nullable: false),
                        ComosiunID_FK = c.Short(nullable: false),
                        Type_FK = c.Byte(nullable: false),
                        DateTimeRegister = c.DateTime(nullable: false),
                        DriverID_FK = c.Int(nullable: false),
                        Status_FK = c.Byte(nullable: false),
                        SeriesID_FK = c.Int(nullable: false),
                        mandeh = c.Boolean(),
                        CenterID_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Drivers", t => t.DriverID_FK)
                .ForeignKey("dbo.SeriesPrices", t => t.SeriesID_FK)
                .ForeignKey("dbo.LoadTypes", t => t.Type_FK)
                .ForeignKey("dbo.LoadTypes", t => t.Status_FK)
                .ForeignKey("dbo.Commissions", t => t.ComosiunID_FK)
                .ForeignKey("dbo.Centers", t => t.CenterID_FK)
                .Index(t => t.ComosiunID_FK)
                .Index(t => t.Type_FK)
                .Index(t => t.DriverID_FK)
                .Index(t => t.Status_FK)
                .Index(t => t.SeriesID_FK)
                .Index(t => t.CenterID_FK);
            
            CreateTable(
                "dbo.Commissions",
                c => new
                    {
                        CommissionID = c.Short(nullable: false, identity: true),
                        CommissionPrice = c.Int(nullable: false),
                        DataRegister = c.DateTime(nullable: false),
                        enabled = c.Boolean(nullable: false),
                        Groups_FK = c.Byte(nullable: false),
                        GroupID = c.Byte(nullable: false),
                        CenterID_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommissionID)
                .ForeignKey("dbo.LoadTypes", t => t.Groups_FK)
                .ForeignKey("dbo.LoadTypes", t => t.GroupID)
                .ForeignKey("dbo.Centers", t => t.CenterID_FK)
                .Index(t => t.Groups_FK)
                .Index(t => t.GroupID)
                .Index(t => t.CenterID_FK);
            
            CreateTable(
                "dbo.LoadTypes",
                c => new
                    {
                        TypeID = c.Byte(nullable: false),
                        Type = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.TypeID);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(maxLength: 10),
                        SmartCart = c.Int(nullable: false),
                        TagNumber = c.String(nullable: false, maxLength: 15),
                        Tag = c.String(nullable: false, maxLength: 15),
                        editor_FK = c.Byte(),
                        driver_code = c.Int(),
                        GroupID = c.Byte(nullable: false),
                        userID_FK = c.Byte(nullable: false),
                        CenterID_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DriverID)
                .ForeignKey("dbo.Users", t => t.userID_FK)
                .ForeignKey("dbo.LoadTypes", t => t.GroupID)
                .ForeignKey("dbo.Centers", t => t.CenterID_FK)
                .Index(t => t.GroupID)
                .Index(t => t.userID_FK)
                .Index(t => t.CenterID_FK);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userID = c.Byte(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 10),
                        Roul = c.String(maxLength: 10),
                        username = c.String(nullable: false, maxLength: 240),
                        password = c.String(nullable: false, maxLength: 240),
                        CenterID_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.userID)
                .ForeignKey("dbo.Centers", t => t.CenterID_FK)
                .Index(t => t.CenterID_FK);
            
            CreateTable(
                "dbo.SeriesPrices",
                c => new
                    {
                        SereisID = c.Int(nullable: false, identity: true),
                        SeriesName = c.Int(nullable: false),
                        SeriesCount = c.Int(),
                        SeriesDateStart = c.DateTime(nullable: false),
                        SeriesDateEnd = c.DateTime(),
                        Faleh = c.Int(),
                        Packet = c.Int(),
                        Gandom = c.Int(),
                        Clinker = c.Int(),
                        closing = c.Boolean(),
                        Member = c.Short(),
                        Native = c.Short(),
                        Other = c.Short(),
                        enabeled = c.Boolean(),
                        userCreator = c.Byte(nullable: false),
                        CenterID_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SereisID)
                .ForeignKey("dbo.Users", t => t.userCreator)
                .ForeignKey("dbo.Centers", t => t.CenterID_FK)
                .Index(t => t.userCreator)
                .Index(t => t.CenterID_FK);
            
            CreateTable(
                "dbo.PhoneBooks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Fname = c.String(nullable: false, maxLength: 50),
                        LName = c.String(nullable: false, maxLength: 50),
                        Mobile = c.String(nullable: false, maxLength: 10),
                        Mobile2 = c.String(maxLength: 10),
                        Phone = c.String(maxLength: 10),
                        Addres = c.String(maxLength: 150),
                        postalCode = c.String(maxLength: 10),
                        Jobs = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 150),
                        DriverID_FK = c.Int(),
                        CenterID_FK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Centers", t => t.CenterID_FK)
                .Index(t => t.CenterID_FK);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "CenterID_FK", "dbo.Centers");
            DropForeignKey("dbo.SeriesPrices", "CenterID_FK", "dbo.Centers");
            DropForeignKey("dbo.Queues", "CenterID_FK", "dbo.Centers");
            DropForeignKey("dbo.PhoneBooks", "CenterID_FK", "dbo.Centers");
            DropForeignKey("dbo.Drivers", "CenterID_FK", "dbo.Centers");
            DropForeignKey("dbo.Commissions", "CenterID_FK", "dbo.Centers");
            DropForeignKey("dbo.Cashes", "CenterID_FK", "dbo.Centers");
            DropForeignKey("dbo.Queues", "ComosiunID_FK", "dbo.Commissions");
            DropForeignKey("dbo.Queues", "Status_FK", "dbo.LoadTypes");
            DropForeignKey("dbo.Queues", "Type_FK", "dbo.LoadTypes");
            DropForeignKey("dbo.Drivers", "GroupID", "dbo.LoadTypes");
            DropForeignKey("dbo.SeriesPrices", "userCreator", "dbo.Users");
            DropForeignKey("dbo.Queues", "SeriesID_FK", "dbo.SeriesPrices");
            DropForeignKey("dbo.Cashes", "seriesID_FK", "dbo.SeriesPrices");
            DropForeignKey("dbo.Drivers", "userID_FK", "dbo.Users");
            DropForeignKey("dbo.Cashes", "userID", "dbo.Users");
            DropForeignKey("dbo.Queues", "DriverID_FK", "dbo.Drivers");
            DropForeignKey("dbo.Commissions", "GroupID", "dbo.LoadTypes");
            DropForeignKey("dbo.Commissions", "Groups_FK", "dbo.LoadTypes");
            DropForeignKey("dbo.Cashes", "QueueID_FK", "dbo.Queues");
            DropForeignKey("dbo.BankAccNums", "CenterID_FK", "dbo.Centers");
            DropIndex("dbo.PhoneBooks", new[] { "CenterID_FK" });
            DropIndex("dbo.SeriesPrices", new[] { "CenterID_FK" });
            DropIndex("dbo.SeriesPrices", new[] { "userCreator" });
            DropIndex("dbo.Users", new[] { "CenterID_FK" });
            DropIndex("dbo.Drivers", new[] { "CenterID_FK" });
            DropIndex("dbo.Drivers", new[] { "userID_FK" });
            DropIndex("dbo.Drivers", new[] { "GroupID" });
            DropIndex("dbo.Commissions", new[] { "CenterID_FK" });
            DropIndex("dbo.Commissions", new[] { "GroupID" });
            DropIndex("dbo.Commissions", new[] { "Groups_FK" });
            DropIndex("dbo.Queues", new[] { "CenterID_FK" });
            DropIndex("dbo.Queues", new[] { "SeriesID_FK" });
            DropIndex("dbo.Queues", new[] { "Status_FK" });
            DropIndex("dbo.Queues", new[] { "DriverID_FK" });
            DropIndex("dbo.Queues", new[] { "Type_FK" });
            DropIndex("dbo.Queues", new[] { "ComosiunID_FK" });
            DropIndex("dbo.Cashes", new[] { "CenterID_FK" });
            DropIndex("dbo.Cashes", new[] { "seriesID_FK" });
            DropIndex("dbo.Cashes", new[] { "userID" });
            DropIndex("dbo.Cashes", new[] { "QueueID_FK" });
            DropIndex("dbo.BankAccNums", new[] { "CenterID_FK" });
            DropTable("dbo.PhoneBooks");
            DropTable("dbo.SeriesPrices");
            DropTable("dbo.Users");
            DropTable("dbo.Drivers");
            DropTable("dbo.LoadTypes");
            DropTable("dbo.Commissions");
            DropTable("dbo.Queues");
            DropTable("dbo.Cashes");
            DropTable("dbo.Centers");
            DropTable("dbo.BankAccNums");
        }
    }
}
