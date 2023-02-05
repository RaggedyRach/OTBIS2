using Microsoft.EntityFrameworkCore;
using OTBIS.Web.Data.Production;

namespace OTBIS.Web.Data.Interfaces
{
    public interface ICatagoryService
    {
        List<Category> Catagories { get; set; }
        Task GetCatagories();
    }
}
