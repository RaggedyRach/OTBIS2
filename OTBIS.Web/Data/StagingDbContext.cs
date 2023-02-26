using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OTBIS.Web.Data.Production;
using OTBIS.Web.Models;

namespace OTBIS.Web.Data
{
    public class StagingDbcontext : DbContext
    {
        public StagingDbcontext(DbContextOptions<StagingDbcontext> options)
          : base(options)
        {

        }

        public DbSet<ComparedOn> ComparedOns {get; set; }
        public DbSet<Domain> Domains { get; set; }

        public DbSet<DomainDepartment> DomainDepartments { get; set; }

        public DbSet<DepartmentCategory> DepartmentCategories { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<CategorySubCategory> CategorySubCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }

        public DbSet<VatCode> VatCodes { get; set; }

        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<NominalCode> NominalCodes { get; set; }

        public DbSet<Till> Tills { get; set; }

        public DbSet<Clerk> Clerks { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<TransactionItem> TransactionItems { get; set; }
        public DbSet<Item> Items { get; set; }

        public DbSet<ItemCostPrice> ItemCostPrices { get; set; }
        public DbSet<ItemSellPrice> ItemSellPrices { get; set; }

        public DbSet<ItemSubCat> ItemSubCats { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Discount> Discounts { get; set; }

        public DbSet<ResType> ResTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }

        public DbSet<ResourceName> ResourceNames { get; set; }
        public DbSet<ProductionCarPark> ProductionCarParks { get; set; }
        
        public DbSet<Logging> Loggings { get; set; }

        public DbSet<RunReport> RunReports { get; set; }

        public DbSet<ReportCounter> ReportCounters { get; set; }

        public DbSet<ReportFavorite> ReportFavorites { get; set; }

    }
    
 }
 
