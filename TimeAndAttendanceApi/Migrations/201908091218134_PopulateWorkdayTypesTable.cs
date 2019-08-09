namespace TimeAndAttendanceApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using TimeAndAttendanceApi.Models;

    public partial class PopulateWorkdayTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT dbo.WorkdayTypes ON");
            Sql($"INSERT INTO dbo.WorkdayTypes (Id, Name, SalaryCoefficient) VALUES ({(int)EWorkdayType.normal}, 'Normal workday', 1.0)");
            Sql($"INSERT INTO dbo.WorkdayTypes (Id, Name, SalaryCoefficient) VALUES ({(int)EWorkdayType.vacation}, 'Vacation leave', 1.0)");
            Sql($"INSERT INTO dbo.WorkdayTypes (Id, Name, SalaryCoefficient) VALUES ({(int)EWorkdayType.onRequest}, 'Leave on request', 1.0)");
            Sql($"INSERT INTO dbo.WorkdayTypes (Id, Name, SalaryCoefficient) VALUES ({(int)EWorkdayType.sickLeave}, 'Sick leave', 0.8)");
            Sql("SET IDENTITY_INSERT dbo.WorkdayTypes OFF");
        }
        
        public override void Down()
        {
            Sql($"DELETE FROM dbo.WorkdayTypes WHERE Id BETWEEN {(int)EWorkdayType.normal} and {(int)EWorkdayType.sickLeave}");
        }
    }
}
