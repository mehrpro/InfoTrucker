namespace InfoTrucker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSmsMessage2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SendMessages", "Title", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SendMessages", "Title");
        }
    }
}
