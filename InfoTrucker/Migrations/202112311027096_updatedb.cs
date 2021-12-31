namespace InfoTrucker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MessageGroupSubjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Subject = c.String(nullable: false, maxLength: 250),
                        CreateTime = c.DateTime(nullable: false),
                        WsdlString = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.SendMessages", "MessageSubjectID_FK", c => c.Int(nullable: false));
            CreateIndex("dbo.SendMessages", "MessageSubjectID_FK");
            AddForeignKey("dbo.SendMessages", "MessageSubjectID_FK", "dbo.MessageGroupSubjects", "ID");
            DropColumn("dbo.SendMessages", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SendMessages", "Title", c => c.String(maxLength: 250));
            DropForeignKey("dbo.SendMessages", "MessageSubjectID_FK", "dbo.MessageGroupSubjects");
            DropIndex("dbo.SendMessages", new[] { "MessageSubjectID_FK" });
            DropColumn("dbo.SendMessages", "MessageSubjectID_FK");
            DropTable("dbo.MessageGroupSubjects");
        }
    }
}
