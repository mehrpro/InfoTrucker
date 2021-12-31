namespace InfoTrucker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSMSMessage3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SendMessages", "SendGroup", c => c.Boolean(nullable: false));
            AddColumn("dbo.SendMessages", "CheckedStatusFromWenService", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SendMessages", "CheckedStatusFromWenService");
            DropColumn("dbo.SendMessages", "SendGroup");
        }
    }
}
