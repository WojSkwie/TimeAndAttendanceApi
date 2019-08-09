namespace TimeAndAttendanceApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedContractTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContractTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "ContractType_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "ContractType_Id");
            AddForeignKey("dbo.Employees", "ContractType_Id", "dbo.ContractTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Employees", "ContractType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "ContractType", c => c.Int(nullable: false));
            DropForeignKey("dbo.Employees", "ContractType_Id", "dbo.ContractTypes");
            DropIndex("dbo.Employees", new[] { "ContractType_Id" });
            DropColumn("dbo.Employees", "ContractType_Id");
            DropTable("dbo.ContractTypes");
        }
    }
}
