using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonsApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationPersonWithCountries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_persons_Country_Id",
                table: "persons",
                column: "Country_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_persons_countries_Country_Id",
                table: "persons",
                column: "Country_Id",
                principalTable: "countries",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_persons_countries_Country_Id",
                table: "persons");

            migrationBuilder.DropIndex(
                name: "IX_persons_Country_Id",
                table: "persons");
        }
    }
}
