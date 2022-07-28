using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class Change002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo.Content",
                table: "Persons",
                columns: new[] { "Id", "Birth", "Death", "FirstName", "LastName", "MiddleName" },
                values: new object[] { 1, new DateTime(1596, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1645, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Михаил", "Романов", "Федорович" });

            migrationBuilder.InsertData(
                schema: "dbo.Content",
                table: "Persons",
                columns: new[] { "Id", "Birth", "Death", "FirstName", "LastName", "MiddleName" },
                values: new object[] { 2, new DateTime(1629, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1676, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Алексей", "Романов", "Михайлович" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo.Content",
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo.Content",
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
