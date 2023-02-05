﻿using Microsoft.AspNetCore.Mvc;

namespace OTBIS.Web.Models.ReportObjects
{
    public class TransByDate
    {

        public int TransByDateId { get; set; }

        public int DomainId { get; set; }

        public DateTime? TransDate { get; set; }

        public int? TransCount { get; set; }

        public decimal? Net_Value { get; set; }

        public decimal? Vat_Value { get; set; }

        public decimal? Gross_Value { get; set; }

        public decimal? Gross_Sale_Value { get; set; }

        public decimal? Discount_Value { get; set; }



    }
}
