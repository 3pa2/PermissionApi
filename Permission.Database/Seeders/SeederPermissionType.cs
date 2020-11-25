using Microsoft.EntityFrameworkCore.Migrations;
using Permission.Database.Seeders.Contracts;
using System;

namespace Permission.Database.Seeders
{
    public class SeederPermissionType : ISeeder
    {
        string diseaseId = "EDC61DF8-061E-478F-9B69-7F58721A604C";
        string diligenceId = "8D4B9C02-94EB-411F-AA52-A673EEFA79A9";

        public void Seed(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO PermissionTypes (Id,Description) VALUES ('{Guid.Parse(diseaseId)}','Disease')");
            migrationBuilder.Sql($"INSERT INTO PermissionTypes (Id,Description) VALUES ('{Guid.Parse(diligenceId)}','Diligence')");
        }
    }
}
