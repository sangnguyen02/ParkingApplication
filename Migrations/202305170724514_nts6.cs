namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nts6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        salaryID = c.Int(nullable: false, identity: true),
                        BasicSalary = c.Single(),
                    })
                .PrimaryKey(t => t.salaryID);
            
            AddColumn("dbo.FixWorkers", "coefficients", c => c.Single(nullable: false));
            AddColumn("dbo.FixWorkers", "salaryID", c => c.Int());
            AddColumn("dbo.FixWorkers", "totalSalary", c => c.Single());
            AddColumn("dbo.KeepWorkers", "coefficients", c => c.Single(nullable: false));
            AddColumn("dbo.KeepWorkers", "salaryID", c => c.Int());
            AddColumn("dbo.KeepWorkers", "totalSalary", c => c.Single());
            AddColumn("dbo.Managers", "coefficients", c => c.Single(nullable: false));
            AddColumn("dbo.Managers", "salaryID", c => c.Int());
            AddColumn("dbo.Managers", "totalSalary", c => c.Single());
            AddColumn("dbo.Directors", "coefficients", c => c.Single(nullable: false));
            CreateIndex("dbo.Managers", "salaryID");
            CreateIndex("dbo.FixWorkers", "salaryID");
            CreateIndex("dbo.KeepWorkers", "salaryID");
            AddForeignKey("dbo.Managers", "salaryID", "dbo.Salaries", "salaryID");
            AddForeignKey("dbo.FixWorkers", "salaryID", "dbo.Salaries", "salaryID");
            AddForeignKey("dbo.KeepWorkers", "salaryID", "dbo.Salaries", "salaryID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KeepWorkers", "salaryID", "dbo.Salaries");
            DropForeignKey("dbo.FixWorkers", "salaryID", "dbo.Salaries");
            DropForeignKey("dbo.Managers", "salaryID", "dbo.Salaries");
            DropIndex("dbo.KeepWorkers", new[] { "salaryID" });
            DropIndex("dbo.FixWorkers", new[] { "salaryID" });
            DropIndex("dbo.Managers", new[] { "salaryID" });
            DropColumn("dbo.Directors", "coefficients");
            DropColumn("dbo.Managers", "totalSalary");
            DropColumn("dbo.Managers", "salaryID");
            DropColumn("dbo.Managers", "coefficients");
            DropColumn("dbo.KeepWorkers", "totalSalary");
            DropColumn("dbo.KeepWorkers", "salaryID");
            DropColumn("dbo.KeepWorkers", "coefficients");
            DropColumn("dbo.FixWorkers", "totalSalary");
            DropColumn("dbo.FixWorkers", "salaryID");
            DropColumn("dbo.FixWorkers", "coefficients");
            DropTable("dbo.Salaries");
        }
    }
}
