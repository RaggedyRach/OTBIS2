using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTBIS.Web.Migrations
{
    public partial class runTableEfit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DomainName",
                table: "RunReports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId2",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId3",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClerkId2",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClerkId3",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompareOnId",
                table: "RunReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId2",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId3",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DomainId2",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DomainId3",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate2",
                table: "RunReports",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate3",
                table: "RunReports",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemTypeId2",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemTypeId3",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberToCompare",
                table: "RunReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate2",
                table: "RunReports",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate3",
                table: "RunReports",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId2",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId3",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TillId2",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TillId3",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "discountId",
                table: "RunReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "discountId2",
                table: "RunReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "discountId3",
                table: "RunReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nominalCodeId2",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "nominalCodeId3",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "paymentTypeId2",
                table: "RunReports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "paymentTypeId3",
                table: "RunReports",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId2",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "CategoryId3",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "ClerkId2",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "ClerkId3",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "CompareOnId",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "DepartmentId2",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "DepartmentId3",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "DomainId2",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "DomainId3",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "EndDate2",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "EndDate3",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "ItemTypeId2",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "ItemTypeId3",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "NumberToCompare",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "StartDate2",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "StartDate3",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "SubCategoryId2",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "SubCategoryId3",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "TillId2",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "TillId3",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "discountId",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "discountId2",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "discountId3",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "nominalCodeId2",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "nominalCodeId3",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "paymentTypeId2",
                table: "RunReports");

            migrationBuilder.DropColumn(
                name: "paymentTypeId3",
                table: "RunReports");

            migrationBuilder.AlterColumn<string>(
                name: "DomainName",
                table: "RunReports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
