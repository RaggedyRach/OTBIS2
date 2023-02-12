using System;

namespace OTBIS.Web.Models.ReportObjects
{
    public class TransByItem
    {

        public int TransByItemId { get; set; }

        public int ItemId { get; set; }   

        public string Item { get; set; }

        public int? TransCount { get; set; }

        public decimal? Net_Value { get; set; }

        public decimal? Vat_Value { get; set; }

        public decimal? Gross_Value { get; set; }

        public decimal? Gross_Sale_Value { get; set; }

        public decimal? Discount_Value { get; set; }

        public string Domain { get; set; }

        public string Department { get; set; }

        public string Category { get; set; }

        public string SubCategory { get; set; }

        

    }

}



