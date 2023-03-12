using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTBIS.Web.Migrations
{
    public partial class grpByRunReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupById",
                table: "RunReports",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupById",
                table: "RunReports");
        }
    }
}
