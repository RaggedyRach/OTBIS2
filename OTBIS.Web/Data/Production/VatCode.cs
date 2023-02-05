using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data.Production
{
    public class VatCode
    {
        public int VatCodeId { get; set; }
        public string VatCodeName { get; set; }

        public decimal? VatCodePercentage { get; set; }
    }
}
