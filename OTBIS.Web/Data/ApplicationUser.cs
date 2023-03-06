using Microsoft.AspNetCore.Identity;

namespace OTBIS.Web.Data
{
    public class ApplicationUser : IdentityUser
    {
       
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string department { get; set; }
        public string mobilePhone { get; set; }
        public bool status { get; set; }
        public string jobTitle { get; set; }
    }
}
