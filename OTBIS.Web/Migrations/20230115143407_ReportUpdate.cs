using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTBIS.Web.Migrations
{
    public partial class ReportUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    //migrationBuilder.DropColumn(
        //    //    name: "TillNumber",
        //    //    table: "Tills");

        //    migrationBuilder.DropColumn(
        //        name: "CategoryId",
        //        table: "SubCategories");

        //    migrationBuilder.AddColumn<int>(
        //        name: "CategoryId",
        //        table: "Transactions",
        //        type: "int",
        //        nullable: true);

        //    migrationBuilder.AddColumn<int>(
        //        name: "SubCategoryId",
        //        table: "Transactions",
        //        type: "int",
        //        nullable: true);

        //    migrationBuilder.AddColumn<int>(
        //        name: "Domainid",
        //        table: "Discounts",
        //        type: "int",
        //        nullable: true);

        //    migrationBuilder.AlterColumn<int>(
        //        name: "DepartmentId",
        //        table: "DepartmentCategories",
        //        type: "int",
        //        nullable: true,
        //        oldClrType: typeof(int),
        //        oldType: "int");

        //    migrationBuilder.AlterColumn<int>(
        //        name: "CategoryId",
        //        table: "DepartmentCategories",
        //        type: "int",
        //        nullable: true,
        //        oldClrType: typeof(int),
        //        oldType: "int");

        //    migrationBuilder.CreateTable(
        //        name: "CategorySubCategories",
        //        columns: table => new
        //        {
        //            CategorySubCategoryId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            SubCategoryId = table.Column<int>(type: "int", nullable: false),
        //            CategoryId = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CategorySubCategories", x => x.CategorySubCategoryId);
        //        });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
    //        migrationBuilder.DropTable(
    //            name: "CategorySubCategories");

    //        migrationBuilder.DropColumn(
    //            name: "CategoryId",
    //            table: "Transactions");

    //        migrationBuilder.DropColumn(
    //            name: "SubCategoryId",
    //            table: "Transactions");

    //        migrationBuilder.DropColumn(
    //            name: "Domainid",
    //            table: "Discounts");

    //        //migrationBuilder.AddColumn<int>(
    //        //    name: "TillNumber",
    //        //    table: "Tills",
    //        //    type: "int",
    //        //    nullable: true);

    //        migrationBuilder.AddColumn<int>(
    //            name: "CategoryId",
    //            table: "SubCategories",
    //            type: "int",
    //            nullable: true);

    //        migrationBuilder.AlterColumn<int>(
    //            name: "DepartmentId",
    //            table: "DepartmentCategories",
    //            type: "int",
    //            nullable: false,
    //            defaultValue: 0,
    //            oldClrType: typeof(int),
    //            oldType: "int",
    //            oldNullable: true);

    //        migrationBuilder.AlterColumn<int>(
    //            name: "CategoryId",
    //            table: "DepartmentCategories",
    //            type: "int",
    //            nullable: false,
    //            defaultValue: 0,
    //            oldClrType: typeof(int),
    //            oldType: "int",
    //            oldNullable: true);
        }
    }
}
