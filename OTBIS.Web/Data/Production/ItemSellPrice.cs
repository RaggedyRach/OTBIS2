using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data.Production
{
    public class ItemSellPrice
    {
        public int ItemSellPriceId { get; set; }

        public decimal Selling_Price { get; set; }

        public int ItemId { get; set; }
        public int VatCodeId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsCurrent { get; set; }
    }
}
