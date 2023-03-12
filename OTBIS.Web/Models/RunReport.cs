using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;


namespace OTBIS.Web.Models
{
    public class RunReport
    {
        [Key]
        public int RunReportId { get; set; }

        public int? UserId { get; set; }
        public int NumberToCompare { get; set; }

        public int CompareOnId { get; set; }

        public int GroupById { get; set; }
        public int DomainId { get; set; }

        public int? DomainId2 { get; set; }

        public int? DomainId3 { get; set; }

        public int? DepartmentId { get; set; }
        public int? DepartmentId2 { get; set; }
        public int? DepartmentId3 { get; set; }
        public int? CategoryId { get; set; }
        public int? CategoryId2 { get; set; }
        public int? CategoryId3 { get; set; }
        public int? SubCategoryId { get; set; }
        public int? SubCategoryId2 { get; set; }
        public int? SubCategoryId3 { get; set; }
        public int? ItemTypeId { get; set;}
        public int? ItemTypeId2 { get; set; }
        public int? ItemTypeId3 { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StartDate2 { get; set; }
        public DateTime? StartDate3 { get; set; }
        
        public DateTime? EndDate { get; set; }
        public DateTime? EndDate2 { get; set; }
        public DateTime? EndDate3 { get; set; }
        public int? paymentTypeId { get; set; }
        public int? paymentTypeId2 { get; set; }
        public int? nominalCodeId { get; set; }
        public int? nominalCodeId2 { get; set; }
        public int? nominalCodeId3 { get; set; }

        public int? paymentTypeId3 { get; set; }
        public int? sellingPriceId { get; set; }

        public int? discountId { get; set; }
        public int? discountId2 { get; set; }
        public int? discountId3 { get; set; }
        public int? TillId { get; set; }
        public int? TillId2 { get; set; }
        public int? TillId3 { get; set; }

        public int? ClerkId { get; set; }
        public int? ClerkId2 { get; set; }
        public int? ClerkId3 { get; set; }
        






    }
}
