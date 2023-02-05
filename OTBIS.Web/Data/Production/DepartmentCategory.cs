using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data.Production
{
    public class DepartmentCategory
    {
        public int DepartmentCategoryId { get; set; }
        public int? DepartmentId { get; set; }

        public int? CategoryId { get; set; }

    }
}
