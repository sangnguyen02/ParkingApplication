namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nts8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Managers", "coefficients", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Managers", "coefficients", c => c.Single(nullable: false));
        }
    }
}
