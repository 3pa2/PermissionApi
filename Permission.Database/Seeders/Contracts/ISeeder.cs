using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permission.Database.Seeders.Contracts
{
    public interface ISeeder 
    {
        public void Seed(MigrationBuilder migrationBuilder);
    }
}
