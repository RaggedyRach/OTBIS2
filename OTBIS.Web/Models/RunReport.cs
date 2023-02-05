using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;


namespace OTBIS.Web.Models
{
    public class RunReport
    {
        public int RunReportId { get; set; }

        public int DomainId { get; set; }
        public string? DomainName { get; set; }

        public int? DepartmentId { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }

        public int? ItemTypeId { get; set;} 
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? nominalCodeId { get; set; }

        public int? sellingPriceId { get; set; }

        public int? paymentTypeId { get; set; }
        public int? TillId { get; set; }

        public int? ClerkId { get; set; }







    }
}
