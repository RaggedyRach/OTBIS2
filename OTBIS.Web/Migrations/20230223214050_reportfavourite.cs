using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTBIS.Web.Migrations
{
    public partial class reportfavourite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFavourite",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "RunReports");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFavourite",
                table: "RunReports",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RunReports",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
