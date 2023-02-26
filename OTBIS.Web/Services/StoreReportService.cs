using Microsoft.EntityFrameworkCore;
using OTBIS.Web.Data;
using OTBIS.Web.Models;
using OTBIS.Web.Data.Production;
using OTBIS.Web.Services;
using System.Data.Entity;
using OTBIS.Web.Models.ReportObjects;
using System.Xml.Linq;
using Radzen;

namespace OTBIS.Web.Services
{
    public class StoreReportService
    {

        #region Property
        private readonly StagingDbcontext _StagingDbcontext;

        #endregion

        #region Constructor
        public StoreReportService(StagingDbcontext StagingContext)
        {
            _StagingDbcontext = StagingContext;
            _StagingDbcontext.Database.SetCommandTimeout(180);
        }
        #endregion

        #region gets id of report in db 
        public async Task<bool> CheckDatabaseForReport(RunReport reportRan)

        { bool exist = false;
            
            try
            {
                await foreach (RunReport r in _StagingDbcontext.RunReports)
                {
                    exist = System.Object.ReferenceEquals(r, reportRan);
                   
                    //var report = await (from i in _StagingDbcontext.RunReports
                    //                    where i.Equals(reportRan)
                    //                    select i).FirstOrDefaultAsync();
                }
                exist = false;

            }
            catch (Exception ex)
            {
                exist = false;
                ex.ToString();
            }
            

            return exist;
        }

        #endregion
        #region gets id of report in db 
        public async Task<int> CheckDatabaseForReportId(RunReport reportRan)

        {
            

              var reportId = await (from i in _StagingDbcontext.RunReports
                                        where i.Equals(reportRan)
                                        select i.RunReportId).FirstOrDefaultAsync();
                
            
                return reportId;
        }

        #endregion
        #region update Count
        public async void UpdateReportCount(int reportId)
        {
            ReportCounter report = await (from i in _StagingDbcontext.ReportCounters
                                          where i.RunReportId.Equals(reportId)
                                          select i).FirstOrDefaultAsync();

            report.Count = report.Count++;
            await _StagingDbcontext.SaveChangesAsync();
        }

        #endregion

        #region put report into database
        public async void PutReportIntoDatabse(RunReport reportRan)
        {
            //string error;
            //RunReport rr;
            //rr.NumberToCompare = reportRan.NumberToCompare;
            //rr.CompareOnId = reportRan.CompareOnId;
            //rr.UserId = reportRan.UserId;

            
            //_StagingDbcontext.RunReports.Add(rr);
            //await _StagingDbcontext.SaveChangesAsync();
            //bool exist;
            int newReportId = reportRan.RunReportId;
            //newReportId =  await (from i in _StagingDbcontext.RunReports
            //                      where i.RunReportId.Equals(reportRan.RunReportId)
            //                      select i.RunReportId).FirstOrDefaultAsync();

            //foreach (RunReport r in _StagingDbcontext.RunReports)
            //{
            //    exist = System.Object.ReferenceEquals(r, reportRan);
            //    if (exist)
            //    {
            //        newReportId = r.RunReportId;
            //        break;
            //    }
            //    else
            //    {
            //              error = "no match";
            //    }

        //}

            ReportCounter rp = new ReportCounter();

            rp.RunReportId = newReportId;
            rp.Count = 1;

            _StagingDbcontext.ReportCounters.Add(rp);
            await _StagingDbcontext.SaveChangesAsync();



        }

        #endregion

        #region myreports list
        public async void MyReportsList(int userId)
        {

            var report = await (from rr in _StagingDbcontext.RunReports
                                join rc in _StagingDbcontext.ReportCounters
                                on rr.RunReportId equals rc.RunReportId
                                where rr.UserId == userId
                                select rc).Take(10).ToListAsync();

                               

        }
        #endregion
    }
}
