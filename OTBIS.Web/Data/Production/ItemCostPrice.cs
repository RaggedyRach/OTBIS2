using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data.Production
{
    public class ItemCostPrice
    {

        public int ItemCostPriceId { get; set; }

        public decimal  Cost_Price { get; set; }

        public int? SupplierId { get; set; }

        public int ItemId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsCurrent { get; set; }
    }
}
