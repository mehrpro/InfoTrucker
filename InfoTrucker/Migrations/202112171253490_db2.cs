namespace InfoTrucker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Address", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Address", c => c.String(nullable: false, maxLength: 250));
        }
    }
}
