using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data.Production
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string DiscountDescription { get; set; }

        public decimal? ValuePercent{ get; set; }

        public int? Domainid { get; set; }

    }
}
