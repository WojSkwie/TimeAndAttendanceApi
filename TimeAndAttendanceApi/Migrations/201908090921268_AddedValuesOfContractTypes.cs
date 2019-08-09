namespace TimeAndAttendanceApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using TimeAndAttendanceApi.Models;

    public partial class AddedValuesOfContractTypes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT dbo.ContractTypes ON");
            Sql($"INSERT INTO dbo.ContractTypes (Id, Name) VALUES ({(int)EContractType.civilContract}, 'Civil Contract')");
            Sql($"INSERT INTO dbo.ContractTypes (Id, Name) VALUES ({(int)EContractType.employmentContract}, 'Employment Contract')");
            Sql($"INSERT INTO dbo.ContractTypes (Id, Name) VALUES ({(int)EContractType.b2b}, 'B2B')");
            Sql($"INSERT INTO dbo.ContractTypes (Id, Name) VALUES ({(int)EContractType.commissionContract}, 'Commission Contract')");
            Sql("SET IDENTITY_INSERT dbo.ContractTypes OFF");
        }
        
        public override void Down()
        {
            Sql($"DELETE FROM dbo.ContractTypes WHERE Id BETWEEN {EContractType.civilContract} and {EContractType.commissionContract}");
        }
    }
}
