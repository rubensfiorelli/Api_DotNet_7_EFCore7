using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProSummit.Data.Migrations
{
    /// <inheritdoc />
    public partial class Buildatualizando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address_ZipCode",
                table: "SummitCustomer",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address_ZipCode",
                table: "SummitCustomer");
        }
    }
}
