using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class Change004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Gender_GenderId",
                schema: "dbo",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender",
                table: "Gender");

            migrationBuilder.RenameTable(
                name: "Gender",
                newName: "Genders",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Genders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                schema: "dbo",
                table: "Genders",
                column: "Id");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Man" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Woman" });

            migrationBuilder.CreateIndex(
                name: "IX_Genders_Name",
                schema: "dbo",
                table: "Genders",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Genders_GenderId",
                schema: "dbo",
                table: "Persons",
                column: "GenderId",
                principalSchema: "dbo",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Genders_GenderId",
                schema: "dbo",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                schema: "dbo",
                table: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_Genders_Name",
                schema: "dbo",
                table: "Genders");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Genders",
                schema: "dbo",
                newName: "Gender");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Gender",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender",
                table: "Gender",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Gender_GenderId",
                schema: "dbo",
                table: "Persons",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
