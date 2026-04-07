using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonsApp.Migrations
{
    /// <inheritdoc />
    public partial class AddNotNullToCountryIdinPersons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_persons_countries_Country_Id",
                table: "persons");

            migrationBuilder.AlterColumn<string>(
                name: "Country_Id",
                table: "persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_persons_countries_Country_Id",
                table: "persons",
                column: "Country_Id",
                principalTable: "countries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_persons_countries_Country_Id",
                table: "persons");

            migrationBuilder.AlterColumn<string>(
                name: "Country_Id",
                table: "persons",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_persons_countries_Country_Id",
                table: "persons",
                column: "Country_Id",
                principalTable: "countries",
                principalColumn: "id");
        }
    }
}
