namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nts1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.KeepWorkers", "facilityKeep");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KeepWorkers", "facilityKeep", c => c.String(maxLength: 50));
        }
    }
}
