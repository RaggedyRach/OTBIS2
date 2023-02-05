using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OTBIS.Web.Data
{
    public class ArenaEventSummaryPriceLevel
    {
        public int ArenaEventSummaryPriceLevelId{ get; set; }
        public string PriceLevelName { get; set; }

        public int NetCapacity { get; set; }

        public int TotalTickets { get; set; }
        public decimal TotalFaceValue { get; set; }
        public decimal PercentDistributed { get; set; }
        public decimal PercentNetCapacity { get; set; }
        public decimal RetailAvailibiltyPercent { get; set; }


    }
}
