﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OTBIS.Web.Data;

#nullable disable

namespace OTBIS.Web.Migrations
{
    [DbContext(typeof(StagingDbContext))]
    [Migration("20230115143407_ReportUpdate")]
    partial class ReportUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OTBIS.Web.Data.Production.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<decimal?>("ActualValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Actual_Adult")
                        .HasColumnType("int");

                    b.Property<int?>("Actual_Child")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Actual_Visit_Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Booked_Adult")
                        .HasColumnType("int");

                    b.Property<int?>("Booked_Child")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BookingRef")
                        .HasColumnType("int");

                    b.Property<decimal?>("BookingValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("Booking_ETA")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Booking_Visit_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DomainId")
                        .HasColumnType("int");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("First_Payment_Received")
                        .HasColumnType("datetime2");

                    b.Property<int>("ResTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ResourceNameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TicketTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("tillId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.CategorySubCategory", b =>
                {
                    b.Property<int>("CategorySubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategorySubCategoryId"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("CategorySubCategoryId");

                    b.ToTable("CategorySubCategories");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.Clerk", b =>
                {
                    b.Property<int>("ClerkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClerkId"), 1L, 1);

                    b.Property<string>("ClerkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DomainId")
                        .HasColumnType("int");

                    b.HasKey("ClerkId");

                    b.ToTable("Clerks");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.DepartmentCategory", b =>
                {
                    b.Property<int>("DepartmentCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentCategoryId"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentCategoryId");

                    b.ToTable("DepartmentCategories");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.Discount", b =>
                {
                    b.Property<int>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiscountId"), 1L, 1);

                    b.Property<string>("DiscountDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Domainid")
                        .HasColumnType("int");

                    b.Property<decimal?>("ValuePercent")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("DiscountId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.Domain", b =>
                {
                    b.Property<int>("DomainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DomainId"), 1L, 1);

                    b.Property<string>("DomainName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DomainId");

                    b.ToTable("Domains");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.DomainDepartment", b =>
                {
                    b.Property<int>("DomainDepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DomainDepartmentId"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DomainId")
                        .HasColumnType("int");

                    b.HasKey("DomainDepartmentId");

                    b.ToTable("DomainDepartments");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DomainId")
                        .HasColumnType("int");

                    b.Property<string>("ItemDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ItemValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("StockOnHand")
                        .HasColumnType("int");

                    b.Property<int?>("nominal")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.ItemCostPrice", b =>
                {
                    b.Property<int>("ItemCostPriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemCostPriceId"), 1L, 1);

                    b.Property<decimal>("Cost_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCurrent")
                        .HasColumnType("bit");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("ItemCostPriceId");

                    b.ToTable("ItemCostPrices");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.ItemSellPrice", b =>
                {
                    b.Property<int>("ItemSellPriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemSellPriceId"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCurrent")
                        .HasColumnType("bit");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<decimal>("Selling_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VatCodeId")
                        .HasColumnType("int");

                    b.HasKey("ItemSellPriceId");

                    b.ToTable("ItemSellPrices");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.ItemSubCat", b =>
                {
                    b.Property<int>("ItemSubCatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemSubCatId"), 1L, 1);

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("ItemSubCatId");

                    b.ToTable("ItemSubCats");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.NominalCode", b =>
                {
                    b.Property<int>("NominalCodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NominalCodeId"), 1L, 1);

                    b.Property<string>("NominalCodeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NominalCodeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NominalCodeId");

                    b.ToTable("NominalCodes");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.PaymentType", b =>
                {
                    b.Property<int>("PaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentTypeId"), 1L, 1);

                    b.Property<string>("PaymentTypeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentTypeId");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.ProductionCarPark", b =>
                {
                    b.Property<int>("ProductionCarParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductionCarParkId"), 1L, 1);

                    b.Property<DateTime>("EntryDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExitDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LaneEntryStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LaneExitStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MediaType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberPlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PNLaneEntryStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParkingNode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParkingNodeLaneExit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PaymentDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentDeviceParkingNode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiptId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StayTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("TicketNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("ProductionCarParkId");

                    b.ToTable("ProductionCarParks");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.ResourceName", b =>
                {
                    b.Property<int>("ResourceNameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourceNameId"), 1L, 1);

                    b.Property<int?>("NominalCodeId")
                        .HasColumnType("int");

                    b.Property<string>("ResourceNameDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ResourceNameValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ResourceNameId");

                    b.ToTable("ResourceNames");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.ResType", b =>
                {
                    b.Property<int>("ResTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResTypeId"), 1L, 1);

                    b.Property<string>("ResTypeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ResTypeValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ResTypeId");

                    b.ToTable("ResTypes");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"), 1L, 1);

                    b.Property<string>("StatusDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCategoryId"), 1L, 1);

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.TicketType", b =>
                {
                    b.Property<int>("TicketTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketTypeId"), 1L, 1);

                    b.Property<int?>("NominalCodeId")
                        .HasColumnType("int");

                    b.Property<string>("TicketTypeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TicketTypeValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TicketTypeId");

                    b.ToTable("TicketTypes");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.Till", b =>
                {
                    b.Property<int>("TillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TillId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TillId");

                    b.ToTable("Tills");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"), 1L, 1);

                    b.Property<int?>("AreaId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ClerkId")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("DicountId")
                        .HasColumnType("int");

                    b.Property<decimal?>("DiscountValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Net_Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PaymentTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("Sales_Ref")
                        .HasColumnType("int");

                    b.Property<decimal?>("Selling_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Session_Num")
                        .HasColumnType("int");

                    b.Property<int?>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("TillId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TransactionDateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("TransactionTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Vat_Amount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.TransactionItem", b =>
                {
                    b.Property<int>("TransactionItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionItemId"), 1L, 1);

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QuantitySold")
                        .HasColumnType("int");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("TransactionItemId");

                    b.ToTable("TransactionItems");
                });

            modelBuilder.Entity("OTBIS.Web.Data.Production.VatCode", b =>
                {
                    b.Property<int>("VatCodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VatCodeId"), 1L, 1);

                    b.Property<string>("VatCodeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("VatCodePercentage")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("VatCodeId");

                    b.ToTable("VatCodes");
                });

            modelBuilder.Entity("OTBIS.Web.Models.ComparedOn", b =>
                {
                    b.Property<int>("ComparedOnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComparedOnId"), 1L, 1);

                    b.Property<string>("ComparedOnName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComparedOnId");

                    b.ToTable("ComparedOns");
                });

            modelBuilder.Entity("OTBIS.Web.Models.Logging", b =>
                {
                    b.Property<int>("LoggingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoggingID"), 1L, 1);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoggingType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoggingID");

                    b.ToTable("Loggings");
                });
#pragma warning restore 612, 618
        }
    }
}
