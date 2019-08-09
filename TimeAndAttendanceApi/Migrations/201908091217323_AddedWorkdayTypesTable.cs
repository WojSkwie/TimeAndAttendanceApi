namespace TimeAndAttendanceApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWorkdayTypesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkdayTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        SalaryCoefficient = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Workdays", "WorkdayType_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Workdays", "WorkdayType_Id");
            AddForeignKey("dbo.Workdays", "WorkdayType_Id", "dbo.WorkdayTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workdays", "WorkdayType_Id", "dbo.WorkdayTypes");
            DropIndex("dbo.Workdays", new[] { "WorkdayType_Id" });
            DropColumn("dbo.Workdays", "WorkdayType_Id");
            DropTable("dbo.WorkdayTypes");
        }
    }
}
