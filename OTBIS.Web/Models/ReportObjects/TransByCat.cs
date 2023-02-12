using System;

namespace OTBIS.Web.Models.ReportObjects
{
    public class TransByCat
    {

        public int TransByCattId { get; set; }

        public int CategoryId { get; set; }   

        public string Category { get; set; }

        public int? TransCount { get; set; }

        public decimal? Net_Value { get; set; }

        public decimal? Vat_Value { get; set; }

        public decimal? Gross_Value { get; set; }

        public decimal? Gross_Sale_Value { get; set; }

        public decimal? Discount_Value { get; set; }


    }


}
