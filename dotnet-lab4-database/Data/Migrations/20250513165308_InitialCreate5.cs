using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_lab4_database.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RateCount",
                table: "DbAlbum",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RateCount",
                table: "DbAlbum");
        }
    }
}
