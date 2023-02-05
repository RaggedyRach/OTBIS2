using OTBIS.Web.Models.ReportObjects;

namespace OTBIS.Web.Models
{
    public class ModelList
    {

        public List<TransByDate> transByDatesList { get; set; } 

        public List<TransByMonth>  transByMonthList { get; set;}

        public List<TransByDept> transByDeptList { get;set; }
    }
}
