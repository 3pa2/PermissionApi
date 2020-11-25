using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Permission.Database.Migrations
{
    public partial class initDbScript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 11, 24, 22, 37, 48, 465, DateTimeKind.Local).AddTicks(2619)),
                    UpdatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermissionTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 11, 24, 22, 37, 48, 449, DateTimeKind.Local).AddTicks(120)),
                    UpdatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RequestDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 11, 24, 22, 37, 48, 467, DateTimeKind.Local).AddTicks(6138)),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    PermissionTypeId = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 11, 24, 22, 37, 48, 467, DateTimeKind.Local).AddTicks(6705)),
                    UpdatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permissions_PermissionTypes_PermissionTypeId",
                        column: x => x.PermissionTypeId,
                        principalTable: "PermissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_EmployeeId",
                table: "Permissions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermissionTypeId",
                table: "Permissions",
                column: "PermissionTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "PermissionTypes");
        }
    }
}
