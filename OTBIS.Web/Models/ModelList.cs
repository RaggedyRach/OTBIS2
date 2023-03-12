using OTBIS.Web.Models.ReportObjects;

namespace OTBIS.Web.Models
{
    public class ModelList
    {

        public List<TransByDate>? transByDatesList { get; set; } 

        public List<TransByMonth>?  transByMonthList { get; set;}

        public List<TransByDept>? transByDeptList { get;set; }

        public List<TransByCat>? transByCatList { get; set; }
        public List<TransBySubCat>? transBySubCatList { get; set; }
        public List<TransByItem>? transByItemList { get; set; }

        public List<TransByTill>? transByTillList { get; set; }
        public string series { get; set; }
       

    }
}
