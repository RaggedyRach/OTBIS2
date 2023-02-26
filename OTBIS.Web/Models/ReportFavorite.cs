namespace OTBIS.Web.Models
{
    public class ReportFavorite
    {
        public int ReportFavoriteId { get; set; }
        public int RunReportId { get; set; }

        public bool Favorite { get; set; } = false;

        public int? UserId { get; set; }
        public string? ReportName { get; set; }  

        public string? ReportDescription { get; set;}

        


        
    }
}
