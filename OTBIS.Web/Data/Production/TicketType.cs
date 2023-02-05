using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data.Production
{
    public class TicketType    {
        public int TicketTypeId { get; set; }
        public string TicketTypeDescription { get; set; }

        public decimal? TicketTypeValue { get; set; }

        public int? NominalCodeId { get; set; }
    }
}
