using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class revizePortfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectUrl",
                table: "Portfolios",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SmallImageUrl2",
                table: "Portfolios",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectUrl",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "SmallImageUrl2",
                table: "Portfolios");
        }
    }
}
