using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class Change003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Persons",
                schema: "dbo.Content",
                newName: "Persons",
                newSchema: "dbo");

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                schema: "dbo",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_GenderId",
                schema: "dbo",
                table: "Persons",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Gender_GenderId",
                schema: "dbo",
                table: "Persons",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Gender_GenderId",
                schema: "dbo",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropIndex(
                name: "IX_Persons_GenderId",
                schema: "dbo",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "GenderId",
                schema: "dbo",
                table: "Persons");

            migrationBuilder.EnsureSchema(
                name: "dbo.Content");

            migrationBuilder.RenameTable(
                name: "Persons",
                schema: "dbo",
                newName: "Persons",
                newSchema: "dbo.Content");
        }
    }
}
