using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Permission.Database.Migrations
{
    public partial class InitPermissionTypeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            new Seeders.SeederPermissionType().Seed(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
