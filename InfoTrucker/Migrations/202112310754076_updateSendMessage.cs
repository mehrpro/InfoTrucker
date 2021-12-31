namespace InfoTrucker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSendMessage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SendMessages", "ReciverNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SendMessages", "ReciverNumber");
        }
    }
}
