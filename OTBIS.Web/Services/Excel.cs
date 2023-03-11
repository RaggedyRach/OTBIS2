using Microsoft.JSInterop;
using OTBIS.Web.Models.ReportObjects;
using OTBIS.Web;

namespace OTBIS.Web.Services
{
    public class Excel
    {
        #region
        public async Task ExportReportTBD(IJSRuntime js,
                                        TransByDate[] data,
                                        string filename = "export.xlsx")
        {
            var report = new XLS();
            var XlSStream = report.Edition(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XlSStream);
     
        }
        #endregion
       
        #region
        public async Task ExportReportTBM(IJSRuntime js,
                                        TransByMonth[] data,
                                        string filename = "export.xlsx")
        {
            var report = new XLS();
            var XlSStream = report.EditionMonth(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XlSStream);

        }
        #endregion

        #region
        public async Task ExportReportTBDept(IJSRuntime js,
                                        TransByDept[] data,
                                        string filename = "export.xlsx")
        {
            var report = new XLS();
            var XlSStream = report.EditionDept(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XlSStream);

        }
        #endregion

        #region
        public async Task ExportReportTBCat(IJSRuntime js,
                                        TransByCat[] data,
                                        string filename = "export.xlsx")
        {
            var report = new XLS();
            var XlSStream = report.EditionCat(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XlSStream);

        }
        #endregion


        #region
        public async Task ExportReportTBSubCat(IJSRuntime js,
                                        TransBySubCat[] data,
                                        string filename = "export.xlsx")
        {
            var report = new XLS();
            var XlSStream = report.EditionSubCat(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XlSStream);

        }
        #endregion
        #region
        public async Task ExportReportTBItem(IJSRuntime js,
                                        TransByItem[] data,
                                        string filename = "export.xlsx")
        {
            var report = new XLS();
            var XlSStream = report.EditionItem(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XlSStream);

        }
        #endregion

    }
}
