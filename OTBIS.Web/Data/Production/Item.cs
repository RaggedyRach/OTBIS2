using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data.Production
{
    public class Item
    {
        public int ItemId { get; set; }

        public string ItemDescription { get; set; }

        public decimal? ItemValue { get; set; }

        public int DepartmentId { get; set; }

        public int? CategoryId { get; set; }

        public int DomainId { get; set; }

        public int? nominal { get; set;}    

        public int? StockOnHand { get; set; }
    }
}
