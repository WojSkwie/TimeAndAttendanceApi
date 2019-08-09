namespace TimeAndAttendanceApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using TimeAndAttendanceApi.Models;

    public partial class AddedValuesOfContractTypes : DbMigration
    {
        public override void Up()
        {
            Sql($"INSERT INTO ContractTypes (Id, Name) VALUES ({EContractType.civilContract}, 'Civil Contract')");
            Sql($"INSERT INTO ContractTypes (Id, Name) VALUES ({EContractType.employmentContract}, 'Employment Contract')");
            Sql($"INSERT INTO ContractTypes (Id, Name) VALUES ({EContractType.b2b}, 'B2B')");
            Sql($"INSERT INTO ContractTypes (Id, Name) VALUES ({EContractType.commissionContract}, 'Commission Contract')");
        }
        
        public override void Down()
        {
            Sql($"DELETE FROM ContractTypes WHERE Id BETWEEN {EContractType.civilContract} and {EContractType.commissionContract}");
        }
    }
}
