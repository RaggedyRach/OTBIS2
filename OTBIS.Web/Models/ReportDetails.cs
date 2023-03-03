using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;


namespace OTBIS.Web.Models
{
    public class ReportDetails
    {
        public int ReportDetailsId { get; set; }

        public int RunReportsId { get; set; }

        public int ReportCount { get; set; }

        public string UserName { get; set; }
        public int NumberToCompare { get; set; }

        public string CompareOnName { get; set; }
        public string DomainName { get; set; }

        public string? Domain2Name { get; set; }

        public string? Domain3Name { get; set; }

        public string? DepartmentName { get; set; }
        public string? DepartmentName2 { get; set; }
        public string? DepartmentName3 { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryName2 { get; set; }
        public string? CategoryName3 { get; set; }
        public string? SubCategoryNameId { get; set; }
        public string? SubCategoryName2 { get; set; }
        public string? SubCategoryName3 { get; set; }
        public string? ItemTypeName { get; set;}
        public string? ItemTypeName2{ get; set; }
        public string? ItemTypeName3 { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StartDate2 { get; set; }
        public DateTime? StartDate3 { get; set; }
        
        public DateTime? EndDate { get; set; }
        public DateTime? EndDate2 { get; set; }
        public DateTime? EndDate3 { get; set; }
        public string? PaymentTypeName { get; set; }
        public string? PaymentTypeName2{ get; set; }
        public string? NominalCodeName { get; set; }
        public string? NominalCodeName2 { get; set; }
        public string? NominalCodeName3 { get; set; }

        public string? PaymentTypeName3 { get; set; }
        public string? SellingPriceName { get; set; }

        public string DiscountName { get; set; }
        public string DiscountName2{ get; set; }
        public string DiscountName3 { get; set; }
        public string? TillName { get; set; }
        public string? TillName2 { get; set; }
        public string? TillName3 { get; set; }

        public string? ClerkName { get; set; }
        public string? ClerkName2 { get; set; }
        public string? ClerkName3 { get; set; }
        

    }
}
