using Microsoft.EntityFrameworkCore;
using OTBIS.Web.Data;
using OTBIS.Web.Models;
using OTBIS.Web.Data.Production;
using OTBIS.Web.Services;
//using System.Data.Entity;
using OTBIS.Web.Models.ReportObjects;
using System.Xml.Linq;
using Radzen;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net.Http;
using Microsoft.JSInterop;

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

        {
            bool exist = false;

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
            int newReportId = reportRan.RunReportId;
            ReportCounter rp = new ReportCounter();

            rp.RunReportId = newReportId;
            rp.Count = 1;

            _StagingDbcontext.ReportCounters.Add(rp);
            await _StagingDbcontext.SaveChangesAsync();
        }

        #endregion

        #region myreports list
        public async Task<List<ReportCounter>> MyMostUsed(int userId)
        {

            try
            {
                var reportInCounterList = await (from rr in _StagingDbcontext.RunReports
                                                 join rc in _StagingDbcontext.ReportCounters
                                                 on rr.RunReportId equals rc.RunReportId
                                                 where rr.UserId == userId
                                                 select rc).Take(10).ToListAsync();
                return reportInCounterList;
            }
            catch (Exception ex)
            {

                ex.ToString();
            }

            return null;


        }
        #endregion

        #region myreports list
        public async Task<List<ReportDetails>> MyReportsList(List<ReportCounter> MyMostUsed, int UserId)
        {
          //  ReportDetails rd = new ReportDetails();
            List<ReportDetails> rdList = new List<ReportDetails>();
            //username from sessiom
            var report = new RunReport();
            var ReportList = new List<RunReport>();
            foreach (var r in MyMostUsed)

            {

                report = await (from runR in _StagingDbcontext.RunReports
                                where runR.RunReportId == r.RunReportId
                                select runR).FirstAsync();
                ReportList.Add(report);
            }

            foreach (var r in ReportList)
            {
                ReportDetails rd = new ReportDetails();
                rd.RunReportsId = r.RunReportId;
                rd.ReportCount = (from i in MyMostUsed
                                  where i.RunReportId == r.RunReportId
                                  select i.Count).FirstOrDefault();

                rd.UserName = "Rachael";

                if (r.NumberToCompare != null)
                {
                    rd.NumberToCompare = r.NumberToCompare;

                }
                if (r.CompareOnId != null)
                {
                    rd.CompareOnName = await (from i in _StagingDbcontext.ComparedOns
                                              where i.ComparedOnId == r.CompareOnId
                                              select i.ComparedOnName).FirstOrDefaultAsync();
                }
                rd.StartDate = r.StartDate;
                rd.EndDate = r.EndDate;
                if (r.StartDate2 != null)
                {
                    rd.StartDate2 = r.StartDate2;
                }
                if (r.StartDate3 != null)
                {
                    rd.StartDate3 = r.StartDate3;
                }

                rd.DomainName = await (from i in _StagingDbcontext.Domains
                                       where i.DomainId == r.DomainId
                                       select i.DomainName).FirstOrDefaultAsync();

                if (r.DomainId2 != 0)
                {
                    rd.Domain2Name = await (from i in _StagingDbcontext.Domains
                                            where i.DomainId == r.DomainId2
                                            select i.DomainName).FirstOrDefaultAsync();
                }
                if (r.DomainId3 != 0)
                {
                    rd.Domain3Name = await (from i in _StagingDbcontext.Domains
                                            where i.DomainId == r.DomainId3
                                            select i.DomainName).FirstOrDefaultAsync();
                }
                if (r.DepartmentId != 0)
                {
                    rd.DepartmentName = await (from i in _StagingDbcontext.Departments
                                               where i.DepartmentId == r.DepartmentId
                                               select i.DepartmentName).FirstOrDefaultAsync();
                }
                if (r.DepartmentId2 != 0)
                {
                    rd.DepartmentName2 = await (from i in _StagingDbcontext.Departments
                                                where i.DepartmentId == r.DepartmentId2
                                                select i.DepartmentName).FirstOrDefaultAsync();
                }
                if (r.DepartmentId3 != 0)
                {
                    rd.DepartmentName3 = await (from i in _StagingDbcontext.Departments
                                                where i.DepartmentId == r.DepartmentId3
                                                select i.DepartmentName).FirstOrDefaultAsync();
                }
                if (r.CategoryId != 0)
                {
                    rd.CategoryName = await (from i in _StagingDbcontext.Categories
                                             where i.CategoryId == r.CategoryId
                                             select i.CategoryName).FirstOrDefaultAsync();
                }
                if (r.CategoryId2 != 0)
                {
                    rd.CategoryName2 = await (from i in _StagingDbcontext.Categories
                                              where i.CategoryId == r.CategoryId2
                                              select i.CategoryName).FirstOrDefaultAsync();
                }
                if (r.CategoryId3 != 0)
                {
                    rd.CategoryName3 = await (from i in _StagingDbcontext.Categories
                                              where i.CategoryId == r.CategoryId3
                                              select i.CategoryName).FirstOrDefaultAsync();
                }
                if (r.SubCategoryId != 0)
                {
                    rd.SubCategoryNameId = await (from i in _StagingDbcontext.SubCategories
                                                  where i.SubCategoryId == r.SubCategoryId
                                                  select i.SubCategoryName).FirstOrDefaultAsync();
                }
                if (r.SubCategoryId2 != 0)
                {
                    rd.SubCategoryName2 = await (from i in _StagingDbcontext.SubCategories
                                                 where i.SubCategoryId == r.SubCategoryId2
                                                 select i.SubCategoryName).FirstOrDefaultAsync();
                }
                if (r.SubCategoryId != 0)
                {
                    rd.SubCategoryName3 = await (from i in _StagingDbcontext.SubCategories
                                                 where i.SubCategoryId == r.SubCategoryId3
                                                 select i.SubCategoryName).FirstOrDefaultAsync();
                }
                if (r.ItemTypeId != 0)
                {
                    rd.ItemTypeName = await (from i in _StagingDbcontext.Items
                                             where i.ItemId == r.ItemTypeId
                                             select i.ItemDescription).FirstOrDefaultAsync();
                }
                if (r.ItemTypeId2 != 0)
                {
                    rd.ItemTypeName2 = await (from i in _StagingDbcontext.Items
                                              where i.ItemId == r.ItemTypeId2
                                              select i.ItemDescription).FirstOrDefaultAsync();
                }
                if (r.ItemTypeId3 != 0)
                {
                    rd.ItemTypeName3 = await (from i in _StagingDbcontext.Items
                                              where i.ItemId == r.ItemTypeId
                                              select i.ItemDescription).FirstOrDefaultAsync();
                }
                if (r.paymentTypeId != 0)
                {
                    rd.PaymentTypeName = await (from i in _StagingDbcontext.PaymentTypes
                                                where i.PaymentTypeId == r.paymentTypeId
                                                select i.PaymentTypeDescription).FirstOrDefaultAsync();
                }
                if (r.paymentTypeId2 != 0)
                {
                    rd.PaymentTypeName2 = await (from i in _StagingDbcontext.PaymentTypes
                                                 where i.PaymentTypeId == r.paymentTypeId2
                                                 select i.PaymentTypeDescription).FirstOrDefaultAsync();
                }
                if (r.paymentTypeId3 != 0)
                {
                    rd.PaymentTypeName3 = await (from i in _StagingDbcontext.PaymentTypes
                                                 where i.PaymentTypeId == r.paymentTypeId3
                                                 select i.PaymentTypeDescription).FirstOrDefaultAsync();
                }
                if (r.nominalCodeId != 0)
                {
                    rd.NominalCodeName = await (from i in _StagingDbcontext.NominalCodes
                                                where i.NominalCodeId == r.nominalCodeId
                                                select i.NominalCodeDescription).FirstOrDefaultAsync();
                }
                if (r.nominalCodeId2 != 0)
                {
                    rd.NominalCodeName2 = await (from i in _StagingDbcontext.NominalCodes
                                                 where i.NominalCodeId == r.nominalCodeId2
                                                 select i.NominalCodeDescription).FirstOrDefaultAsync();
                }
                if (r.nominalCodeId3 != 0)
                {
                    rd.NominalCodeName3 = await (from i in _StagingDbcontext.NominalCodes
                                                 where i.NominalCodeId == r.nominalCodeId3
                                                 select i.NominalCodeDescription).FirstOrDefaultAsync();
                }
                if (r.discountId != 0)
                {
                    rd.DiscountName = await (from i in _StagingDbcontext.Discounts
                                             where i.DiscountId == r.discountId
                                             select i.DiscountDescription).FirstOrDefaultAsync();
                }
                if (r.discountId2 != 0)
                {
                    rd.DiscountName2 = await (from i in _StagingDbcontext.Discounts
                                              where i.DiscountId == r.discountId2
                                              select i.DiscountDescription).FirstOrDefaultAsync();
                }
                if (r.discountId3 != 0)
                {
                    rd.DiscountName3 = await (from i in _StagingDbcontext.Discounts
                                              where i.DiscountId == r.discountId3
                                              select i.DiscountDescription).FirstOrDefaultAsync();
                }
                if (r.TillId != 0)
                {
                    rd.TillName = await (from i in _StagingDbcontext.Tills
                                         where i.TillId == r.TillId
                                         select i.Name).FirstOrDefaultAsync();
                }
                if (r.TillId2 != 0)
                {
                    rd.TillName2 = await (from i in _StagingDbcontext.Tills
                                          where i.TillId == r.TillId2
                                          select i.Name).FirstOrDefaultAsync();
                }
                if (r.TillId3 != 0)
                {
                    rd.TillName3 = await (from i in _StagingDbcontext.Tills
                                          where i.TillId == r.TillId3
                                          select i.Name).FirstOrDefaultAsync();
                }
                if (r.ClerkId != 0)
                {
                    rd.ClerkName = await (from i in _StagingDbcontext.Clerks
                                          where i.ClerkId == r.ClerkId
                                          select i.ClerkName).FirstOrDefaultAsync();
                }
                if (r.ClerkId2 != 0)
                {
                    rd.ClerkName2 = await (from i in _StagingDbcontext.Clerks
                                           where i.ClerkId == r.ClerkId2
                                           select i.ClerkName).FirstOrDefaultAsync();
                }
                if (r.ClerkId3 != 0)
                {
                    rd.ClerkName3 = await (from i in _StagingDbcontext.Clerks
                                           where i.ClerkId == r.ClerkId3
                                           select i.ClerkName).FirstOrDefaultAsync();
                }

                //_StagingDbcontext.ReportDetails.Add(rd);
                //await _StagingDbcontext.SaveChangesAsync();
                rdList.Add(rd);

            }// end of foreach
            return rdList;
        }
        #endregion

        #region
        public async void AddMyFavourites(int reportId, string name, int userId)
        {
            ReportFavorite rf = new ReportFavorite();
            rf.RunReportId = reportId;
            rf.Favorite = true;
            rf.ReportName = name;
            rf.UserId = userId;
            _StagingDbcontext.ReportFavorites.Add(rf);
            await _StagingDbcontext.SaveChangesAsync();

        }
        #endregion
        


        //    #region export report
        //    NavigationManager navigationManager;
        //    public async void ExportByDate(string fileName, string type, Radzen.Query query)
        //    {
        //        var url = query != null ? query.ToUrl($"api/ortSampleDb/ExportProductsToExcel/export/sampledb/products/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/sampledb/products/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')";
        //        url = navigationManager.BaseUri + url;
        //        var response = await httpClient.GetAsync(url);
        //        var fileBytes = await response.Content.ReadAsByteArrayAsync();
        //        return fileBytes;
        //    }

        //#endregion
    }
}