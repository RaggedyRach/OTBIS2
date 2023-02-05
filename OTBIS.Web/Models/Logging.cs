using System.ComponentModel.DataAnnotations;

namespace OTBIS.Web.Models
{
    public class Logging
    {
        [Key]
        public int LoggingID { get; set; }
        public string LoggingType { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
