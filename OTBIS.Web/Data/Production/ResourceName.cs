using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data.Production
{
    public class ResourceName
    {
        public int ResourceNameId { get; set; }
        public string ResourceNameDescription { get; set; }

        public decimal? ResourceNameValue { get; set; }

        public int? NominalCodeId { get; set; }
    }
}
