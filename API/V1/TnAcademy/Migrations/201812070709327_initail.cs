namespace TnAcademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Title", c => c.String());
            AddColumn("dbo.Teachers", "Adress", c => c.String());
            AddColumn("dbo.Teachers", "Website", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Website");
            DropColumn("dbo.Teachers", "Adress");
            DropColumn("dbo.Teachers", "Title");
        }
    }
}
