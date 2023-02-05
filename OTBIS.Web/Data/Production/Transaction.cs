using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data.Production
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime?  TransactionDateTime { get; set; }

        public int? TillId { get; set; }

        public int? ClerkId { get; set; }

        public int? DepartmentId { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public int? AreaId { get; set; }

        public int? PaymentTypeId { get; set; }
           
        public int? DicountId { get; set; }
        public decimal? Selling_Price { get; set;}
        public decimal? Vat_Amount { get; set; }

        public decimal? Net_Amount  { get; set; }    
        public decimal? DiscountValue { get; set; }

        public decimal? TransactionTotal { get; set; }
        public string Currency { get; set; }

        public int? Sales_Ref { get; set; }

        public int? Session_Num { get; set; }

        public int? ItemId {  get; set; }   
    }
}
