using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTBIS.Web.Migrations
{
    public partial class comparedOntbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Num2Compares");

            migrationBuilder.CreateTable(
                name: "ComparedOns",
                columns: table => new
                {
                    ComparedOnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComparedOnName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComparedOns", x => x.ComparedOnId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComparedOns");

            migrationBuilder.CreateTable(
                name: "Num2Compares",
                columns: table => new
                {
                    Num2CompareId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComparedOn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfComparison = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Num2Compares", x => x.Num2CompareId);
                });
        }
    }
}
