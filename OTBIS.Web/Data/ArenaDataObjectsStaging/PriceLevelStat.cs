using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data
{
    public class PriceLevelStat
    {
        public int PriceLevelStatId { get; set; }
        public string PriceLevel { get; set; }
        public decimal Price { get; set; }

        public int Sold { get; set; }
        public int Comps { get; set; }

        public int Opens { get; set; }

        public int Holds { get; set; }

        public int NetCapacity { get; set; }

        public int SeatCapacity { get; set; }
    }
}
