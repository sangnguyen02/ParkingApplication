namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nts9 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FixWorkers", "coefficients", c => c.Single());
            AlterColumn("dbo.KeepWorkers", "coefficients", c => c.Single());
            DropColumn("dbo.Directors", "coefficients");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Directors", "coefficients", c => c.Single(nullable: false));
            AlterColumn("dbo.KeepWorkers", "coefficients", c => c.Single(nullable: false));
            AlterColumn("dbo.FixWorkers", "coefficients", c => c.Single(nullable: false));
        }
    }
}
