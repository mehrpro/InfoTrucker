namespace InfoTrucker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "CodeMelei", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.People", "SerialShenasnameh", c => c.String(maxLength: 20));
            AlterColumn("dbo.People", "Sh_Plak", c => c.String(maxLength: 50));
            AlterColumn("dbo.People", "Kamion", c => c.String(maxLength: 50));
            AlterColumn("dbo.People", "CodePosti", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "CodePosti", c => c.String(maxLength: 10, fixedLength: true));
            AlterColumn("dbo.People", "Kamion", c => c.String(maxLength: 10));
            AlterColumn("dbo.People", "Sh_Plak", c => c.String(maxLength: 10));
            AlterColumn("dbo.People", "SerialShenasnameh", c => c.String(maxLength: 15));
            AlterColumn("dbo.People", "CodeMelei", c => c.String(nullable: false));
        }
    }
}
