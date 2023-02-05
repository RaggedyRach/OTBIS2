using System;

namespace OTBIS.Web.Models.ReportObjects
{
    public class TransByDept
    {

        public int TransByDeptId { get; set; }

        public int DepartmentId { get; set; }   

        public string Department { get; set; }

        public int? TransCount { get; set; }

        public decimal? Net_Value { get; set; }

        public decimal? Vat_Value { get; set; }

        public decimal? Gross_Value { get; set; }

        public decimal? Gross_Sale_Value { get; set; }

        public decimal? Discount_Value { get; set; }


    }


}
