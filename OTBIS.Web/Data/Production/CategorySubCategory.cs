using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data.Production
{
    public class CategorySubCategory    {

        public int CategorySubCategoryId { get; set; }
        public int SubCategoryId { get; set; }

        public int? CategoryId { get; set; }
    }
}
