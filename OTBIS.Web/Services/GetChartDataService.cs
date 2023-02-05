using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OTBIS.Web.Data;
using OTBIS.Web;
using OTBIS.Web.Data.Production;
using System.Runtime.CompilerServices;
using OTBIS.Web.Models;
using OTBIS.Web.Models.ChartArrays;
using OTBIS.Web.Models.ReportObjects;
using Microsoft.Data.SqlClient.Server;
using Radzen;
using OTBIS.Web.Models.ChartArrays;

namespace OTBIS.Web.Services
{
    public class GetChartDataService
    {
        #region Property
        private readonly StagingDbContext _stagingDbContext;

        #endregion

        #region Constructor
        public GetChartDataService(StagingDbContext stagingDbContext)
        {
            _stagingDbContext = stagingDbContext;

        }
        #endregion

        #region Get List of All Transactions by Date Range grp by day of the week
        //public async Task<TransNetByDay[]> GetAllTransByDateRangeGrpByDayofWeekAsync(DateTime startDate, DateTime endDate, DayOfWeek dayOfWeek)
        //{
        //string error;
        //try
        //{



        //var Test = await (from d in _stagingDbContext.Transactions
        //                  where d.TransactionDateTime.Value.DayOfWeek.Equals(1)
        //                  select d
        //                     ).ToListAsync();
        //}
        //catch(Exception ex)
        //{
        //    error = ex.Message.ToString();
        //}



        //var bookings = from b in this.db.Bookings
        //               where EntityFunctions.DiffDays(firstSunday, b.StartDateTime) % 7 == 1
        //               select b;


        //var groupJoin = await (from d in _stagingDbContext.Transactions
        //                       where d.TransactionDateTime >= startDate
        //                        && d.TransactionDateTime <= endDate
        //                       select d                                
        //                       ).ToListAsync();

        //var updatedData =  (from i in groupJoin
        //                   where i.TransactionDateTime.Value.DayOfWeek == dayOfWeek
        //                   group i by new { i.TransactionDateTime.Value.Date } into g
        //                   select new TransNetByDay()
        //                   {
        //                       TransactionDateTime = g.Key.Date,
        //                       Net_Amount = g.Sum(i => i.Net_Amount)
        //                   }).ToArray();






        //return updatedData;
        //}

        #endregion

        #region Get Tasks by dept gr by cat (dept, srt date, end date)
        public async Task<TransNetByCat[]> TransactionByDeptGrpByCatAsync(DateTime startDate, DateTime endDate, int deptid)
        {
            var groupJoin = await (from d in _stagingDbContext.Transactions
                                   join j in _stagingDbContext.Categories on d.CategoryId equals j.CategoryId
                                   where d.DepartmentId == deptid && d.TransactionDateTime >= startDate && d.TransactionDateTime <= endDate
                                   group d by new { j.CategoryName } into g
                                   select new TransNetByCat()
                                   {
                                       CategoryName = g.Key.CategoryName,
                                       Net_Amount = g.Sum(i => i.Net_Amount)
                                   }).ToArrayAsync();
            return groupJoin;
        }

        #endregion

        #region Get Tasks by cat (dept, cat, srt date, end date)
        public async Task<List<Transaction>> TransactionByCatAsync(DateTime startDate, DateTime endDate, int deptid, int catid)
        {
            var data = await (from i in _stagingDbContext.Transactions
                              where i.TransactionDateTime >= startDate && i.TransactionDateTime <= endDate
                              && deptid == i.DepartmentId
                              && catid == i.CategoryId

                              select i).ToListAsync();
            // var data = groupTransofSubCatByDate(trns);
            return data;
        }

        #endregion

        #region Get Tasks by subcatagory (dept, cat, subcat x 2, srt date end date
        public async Task<TransBySubCat1[]> TransactionBySubCatAsync(DateTime startDate, DateTime endDate, int deptid, int catid, int subcatid1)
        {
            var groupJoin = await (from d in _stagingDbContext.Transactions
                                   join j in _stagingDbContext.Categories on d.CategoryId equals j.CategoryId
                                   join i in _stagingDbContext.SubCategories on d.SubCategoryId equals i.SubCategoryId
                                   where d.DepartmentId == deptid && d.SubCategoryId == subcatid1
                                   && j.CategoryId == catid
                                   && d.TransactionDateTime >= startDate && d.TransactionDateTime <= endDate
                                   group d by new { d.TransactionDateTime } into g
                                   select new TransBySubCat1()
                                   {
                                       TransactionDateTime = g.Key.TransactionDateTime,
                                       Net_Amount = g.Sum(i => i.Net_Amount)
                                   }).ToArrayAsync();

            return groupJoin;
        }

        #endregion
        #region
        public TransBySubCat1[] orderTransofSubCatByDate(TransBySubCat1[] subCatListTrans)
        {

            List<TransBySubCat1> test = new List<TransBySubCat1>();


            var query = subCatListTrans.GroupBy(o => new { TransactionDateTime = o.TransactionDateTime.Value.Date })
                .Select(s => new TransBySubCat1() { TransactionDateTime = s.Key.TransactionDateTime, Net_Amount = s.Sum(o => o.Net_Amount), })
                .OrderBy(o => o.TransactionDateTime).ToArray();

            return query;
        }
        #endregion
     
    }
}
