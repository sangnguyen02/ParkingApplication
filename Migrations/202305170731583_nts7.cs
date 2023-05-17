namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nts7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Salaries", "role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Salaries", "role");
        }
    }
}
