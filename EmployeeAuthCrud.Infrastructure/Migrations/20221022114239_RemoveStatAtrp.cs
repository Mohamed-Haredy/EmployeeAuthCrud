using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAuthCrud.Infrastructure.Migrations
{
    public partial class RemoveStatAtrp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "clientid",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "createby",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "createdate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "isremoved",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "note",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "updatedby",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "updateddate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "clientid",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "createby",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "createdate",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "isremoved",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "note",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "updatedby",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "updateddate",
                table: "Countries");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "Employees",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "createby",
                table: "Employees",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "isremoved",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "note",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "updatedby",
                table: "Employees",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updateddate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "clientid",
                table: "Countries",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "createby",
                table: "Countries",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdate",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "isremoved",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "note",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "updatedby",
                table: "Countries",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updateddate",
                table: "Countries",
                type: "datetime2",
                nullable: true);
        }
    }
}
