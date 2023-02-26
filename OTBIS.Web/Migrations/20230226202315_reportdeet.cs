using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTBIS.Web.Migrations
{
    public partial class reportdeet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportDetails",
                columns: table => new
                {
                    ReportDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RunReportsId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberToCompare = table.Column<int>(type: "int", nullable: false),
                    CompareOnName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domain2Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domain3Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentName3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryName3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryNameId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryName3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemTypeName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemTypeName3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate3 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate3 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentTypeName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NominalCodeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NominalCodeName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NominalCodeName3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentTypeName3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellingPriceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountName2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountName3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TillName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TillName3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClerkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClerkName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClerkName3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportDetails", x => x.ReportDetailsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportDetails");
        }
    }
}
