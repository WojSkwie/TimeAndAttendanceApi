namespace TimeAndAttendanceApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMaxLenghtOfContractTypeName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContractTypes", "Name", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContractTypes", "Name", c => c.String());
        }
    }
}
