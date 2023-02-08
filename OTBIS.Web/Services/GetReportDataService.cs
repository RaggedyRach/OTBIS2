using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
using System.Diagnostics;
//using System.Data.Entity.Core.Objects;
//using System.Data.Entity;

namespace OTBIS.Web.Services
{
    public class GetReportDataService
    {
        #region Property
        private readonly StagingDbContext _stagingDbContext;

        #endregion

        #region Constructor
        public GetReportDataService(StagingDbContext stagingDbContext)
        {
            _stagingDbContext = stagingDbContext;

        }
        #endregion

        //#region Get List of All Transactions by Date Range
        //public async Task<ModelList> GetAllTransByDateRangeAsync(DateTime startDate, DateTime endDate)
        //{
        //    int idnum = 0;
        //    var data = await (from i in _stagingDbContext.Transactions
        //                      where i.TransactionDateTime >= startDate && i.TransactionDateTime <= endDate
        //                      group i by new { i.TransactionDateTime.Value.Date } into g
        //                      select new TransByDate()
        //                      {                                  
        //                          TransDate = g.Key.Date,
        //                          TransCount = g.Select(i => i.Sales_Ref).Distinct().Count(),
        //                          Net_Value = g.Sum(i => i.Net_Amount),
        //                          Vat_Value = g.Sum(i => i.Vat_Amount),
        //                          Gross_Value = g.Sum(i => i.Selling_Price),
        //                          Gross_Sale_Value = g.Sum(i => i.TransactionTotal),
        //                          Discount_Value = g.Sum(i => i.DiscountValue),
        //                      }).ToListAsync();

        //    ModelList dataList = new ModelList();
        //    dataList.transByDatesList = data;


        //    return dataList;
        //}

        //#endregion


        #region Get List of All Transactions by Date Range and domian
        public async Task<ModelList> GetAllTransByDomainAndDateAsync(DateTime startDate, DateTime endDate, int domainId)
        {
            var data = await (from i in _stagingDbContext.Transactions
                              join j in _stagingDbContext.DomainDepartments
                              on i.DepartmentId equals j.DepartmentId
                              where j.DomainId.Equals(domainId)
                              && i.TransactionDateTime >= startDate && i.TransactionDateTime <= endDate
                              group i by new { i.TransactionDateTime.Value.Date } into g
                              select new TransByDate()
                              {
                                  TransDate = g.Key.Date,
                                  // DomainId = g.Select(j=>j.AreaId).Distinct(),
                                  TransCount = g.Select(i => i.Sales_Ref).Distinct().Count(),
                                  Net_Value = g.Sum(i => i.Net_Amount),
                                  Vat_Value = g.Sum(i => i.Vat_Amount),
                                  Gross_Value = g.Sum(i => i.Selling_Price),
                                  Gross_Sale_Value = g.Sum(i => i.TransactionTotal),
                                  Discount_Value = g.Sum(i => i.DiscountValue),
                              }).ToListAsync();

            ModelList dataList = new ModelList();
            dataList.transByDatesList = data;


            return dataList;
        }

        #endregion

        #region Get List of All Transactions by Day and domian
        public async Task<ModelList> GetAllTransByDomainByDayAsync(DateTime startDate, DateTime endDate, int domainId, DayOfWeek dayOfWeek)
        {
            //Func<Transaction, bool>isBetween = s => s.TransactionDateTime >= startDate && s.TransactionDateTime <= endDate;



            var data = await (from i in _stagingDbContext.Transactions
                              join j in _stagingDbContext.DomainDepartments
                              on i.DepartmentId equals j.DepartmentId
                              where j.DomainId.Equals(domainId)
                              && i.TransactionDateTime >= startDate && i.TransactionDateTime <= endDate
                              group i by new { i.TransactionDateTime.Value.Date } into g
                              select new TransByDate()
                              {
                                  TransDate = g.Key.Date,
                                  TransCount = g.Select(i => i.Sales_Ref).Distinct().Count(),
                                  Net_Value = g.Sum(i => i.Net_Amount),
                                  Vat_Value = g.Sum(i => i.Vat_Amount),
                                  Gross_Value = g.Sum(i => i.Selling_Price),
                                  Gross_Sale_Value = g.Sum(i => i.TransactionTotal),
                                  Discount_Value = g.Sum(i => i.DiscountValue),
                              }).ToListAsync();

            //This fiters the return data by the day
            var dataWithDay = (from d in data
                               where d.TransDate.Value.DayOfWeek == dayOfWeek
                               select d).ToList();

            ModelList dataList = new ModelList();
            dataList.transByDatesList = dataWithDay;


            return dataList;

        }

        #endregion

        
      




        #region Get List of All Transactions by Month and domian
        public async Task<ModelList> GetAllTransByDomainByMonthAsync(DateTime startDate, DateTime endDate, int domainId)
        {

            var data = await (from i in _stagingDbContext.Transactions
                              join j in _stagingDbContext.DomainDepartments
                              on i.DepartmentId equals j.DepartmentId
                              where j.DomainId.Equals(domainId)
                              && i.TransactionDateTime >= startDate && i.TransactionDateTime <= endDate
                              group i by new { i.TransactionDateTime.Value.Month } into g
                              select new TransByMonth()
                              {
                                  Month = g.Key.Month,
                                  TransCount = g.Select(i => i.Sales_Ref).Distinct().Count(),
                                  Net_Value = g.Sum(i => i.Net_Amount),
                                  Vat_Value = g.Sum(i => i.Vat_Amount),
                                  Gross_Value = g.Sum(i => i.Selling_Price),
                                  Gross_Sale_Value = g.Sum(i => i.TransactionTotal),
                                  Discount_Value = g.Sum(i => i.DiscountValue),
                              }).ToListAsync();

            ModelList dataList = new ModelList();
            dataList.transByMonthList = data;


            return dataList;

        }

        #endregion


        #region Get List of All Transactions by Domain gr by Dept
        public async Task<ModelList> GetAllTransByDomainByDeptAsync(DateTime startDate, DateTime endDate, int domainId)
        {

            var data = await (from i in _stagingDbContext.Transactions
                              join j in _stagingDbContext.DomainDepartments on i.DepartmentId equals j.DepartmentId
                              join k in _stagingDbContext.Departments on i.DepartmentId equals k.DepartmentId
                              where j.DomainId.Equals(domainId)
                              && i.TransactionDateTime >= startDate && i.TransactionDateTime <= endDate
                              group i by new { i.DepartmentId } into g
                              select new TransByDept()
                              {
                                  DepartmentId = g.Key.DepartmentId.Value,
                                  //select department name
                                  TransCount = g.Select(i => i.Sales_Ref).Distinct().Count(),
                                  Net_Value = g.Sum(i => i.Net_Amount),
                                  Vat_Value = g.Sum(i => i.Vat_Amount),
                                  Gross_Value = g.Sum(i => i.Selling_Price),
                                  Gross_Sale_Value = g.Sum(i => i.TransactionTotal),
                                  Discount_Value = g.Sum(i => i.DiscountValue),
                              }).ToListAsync();

            ModelList dataList = new ModelList();
            dataList.transByDeptList = data;


            return dataList;

        }

        #endregion

        #region test the day method
        public async Task TestDayMethod()
        {


            var day = DayOfWeek.Monday;
            DateTime firstDay = new DateTime(1753, 1, 7);
            DateTime start = new DateTime(2022, 07, 01);
            DateTime end = new DateTime(2022, 08, 01);





            switch (day)
            {
                case DayOfWeek.Monday:
                    firstDay = new DateTime(1753, 1, 8);
                    //    var check = firstDay.DayOfWeek;
                    break;
                case DayOfWeek.Tuesday:
                    firstDay = new DateTime(1753, 1, 9);
                    break;
                case DayOfWeek.Wednesday:
                    firstDay = new DateTime(1753, 1, 10);
                    break;
                case DayOfWeek.Thursday:
                    firstDay = new DateTime(1753, 1, 11);
                    break;
                case DayOfWeek.Friday:
                    firstDay = new DateTime(1753, 1, 12);
                    break;
                case DayOfWeek.Saturday:
                    firstDay = new DateTime(1753, 1, 13);
                    break;
                case DayOfWeek.Sunday:
                    firstDay = new DateTime(1753, 1, 7);
                    break;

            }

            //Get The required Dat
            try
            {
                //    var checks = (from b in _stagingDbContext.Transactions
                //                     //  where EntityFunctions.DiffDays(firstDay, b.transdate) % 7 == 1
                //                 where (b.TransactionDateTime >= start && b.TransactionDateTime <= end) && System.Data.Entity.DbFunctions.DiffDays(start, b.TransactionDateTime)  == 10
                //                 select b).AsAsyncEnumerable();


                //var data = await (from i in _stagingDbContext.Transactions
                //                  join j in _stagingDbContext.DomainDepartments
                //                  on i.DepartmentId equals j.DepartmentId
                //                  where j.DomainId.Equals(domainId)
                //                  && i.TransactionDateTime >= startDate && i.TransactionDateTime <= endDate
                //                  group i by new { i.TransactionDateTime.Value.Date } into g
                //                  select new TransByDate()
                //                  {
                //                      TransDate = g.Key.Date,
                //                      // DomainId = g.Select(j=>j.AreaId).Distinct(),
                //                      TransCount = g.Select(i => i.Sales_Ref).Distinct().Count(),
                //                      Net_Value = g.Sum(i => i.Net_Amount),
                //                      Vat_Value = g.Sum(i => i.Vat_Amount),
                //                      Gross_Value = g.Sum(i => i.Selling_Price),
                //                      Gross_Sale_Value = g.Sum(i => i.TransactionTotal),
                //                      Discount_Value = g.Sum(i => i.DiscountValue),
                                //  }).ToListAsync();

                var checks1 = (from b in _stagingDbContext.Transactions
                               where (b.TransactionDateTime >= start && b.TransactionDateTime <= end)
                               group b by new { b.TransactionDateTime.Value.Date } into g
                               select new
                               {
                                   g.Key.Date,
                                   Net_Value = g.Sum(i => i.Net_Amount),
                                   g.Key.Date.DayOfWeek
                               }).ToList();

                var checks3 = (from b in checks1
                              where b.DayOfWeek == DayOfWeek.Monday
                              select b);

               






                var checks2 = (from b in _stagingDbContext.Transactions
                               where System.Data.Entity.DbFunctions.DiffDays(firstDay, b.TransactionDateTime) % 7 == 1
                               //where (b.TransactionDateTime >= start && b.TransactionDateTime <= end) && System.Data.Entity.DbFunctions.DiffDays(firstDay, b.TransactionDateTime) % 7 == 1
                               select b).ToList();

                DateTime now = DateTime.Now.Date;

            


                //var results = from d in _stagingDbContext.Transactions
                //              where (DbFunctions.DiffDays(d.TransactionDateTime.Value.Date, now) < 2)
                                
                //              select d;

                //var results1 = (from d in _stagingDbContext.Transactions
                //              where (DbFunctions.DiffDays(d.TransactionDateTime, now) < 2)

                //              select d).ToList();


                //  var count = checks.Count();
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }
          
        }
        #endregion
    }

}

