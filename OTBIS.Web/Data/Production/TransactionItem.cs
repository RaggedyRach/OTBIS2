using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data.Production
{
    public class TransactionItem
    {
        public int TransactionItemId { get; set; }

        public int ItemId { get; set; }

        public decimal ItemPrice { get; set; }
        public int TransactionId { get; set; }

        public int QuantitySold { get; set; }
    }
}
