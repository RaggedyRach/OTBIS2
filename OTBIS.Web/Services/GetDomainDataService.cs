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
//using Humanizer;
//using System.Data.Entity.Core.Objects;
//using System.Data.Entity;

namespace OTBIS.Web.Services
{
    public class GetDomainDataService
    {
        #region Property
        private readonly StagingDbcontext _StagingDbcontext;

        #endregion

        #region Constructor
        public GetDomainDataService(StagingDbcontext StagingDbcontext)
        {
            _StagingDbcontext = StagingDbcontext;

             _StagingDbcontext.Database.SetCommandTimeout(180);

        }
        #endregion

        //#region Get List of All Transactions by Date Range
        //public async Task<ModelList> GetAllTransByDateRangeAsync(DateTime startDate, DateTime endDate)
        //{
        //    int idnum = 0;
        //    var data = await (from i in _StagingDbcontext.Transactions
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
            var data = await (from i in _StagingDbcontext.Transactions
                              join j in _StagingDbcontext.DomainDepartments
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



            var data = await (from i in _StagingDbcontext.Transactions
                              join j in _StagingDbcontext.DomainDepartments
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

            var data = await (from i in _StagingDbcontext.Transactions
                              join j in _StagingDbcontext.DomainDepartments
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
            var data = await (from t in _StagingDbcontext.Transactions
                              join dd in _StagingDbcontext.DomainDepartments 
                              on t.DepartmentId equals dd.DepartmentId
                              join d in _StagingDbcontext.Departments 
                              on t.DepartmentId equals d.DepartmentId

                              where dd.DomainId == domainId
                              && t.TransactionDateTime >= startDate && t.TransactionDateTime <= endDate

                              group new { t,d } by new { t.DepartmentId, d.DepartmentName } into g

                              select new TransByDept()
                              {
                                  DepartmentId = g.Key.DepartmentId.Value,
                                  //select department name
                                  Department = g.Key.DepartmentName,
                                  TransCount = g.Count(x=>x.t.Sales_Ref.HasValue),
                                  Net_Value = g.Sum(x => x.t.Net_Amount.Value),
                                  Vat_Value = g.Sum(x => x.t.Vat_Amount.Value),
                                  Gross_Value = g.Sum(x => x.t.Selling_Price.Value),
                                  Gross_Sale_Value = g.Sum(x => x.t.TransactionTotal.Value),
                                  Discount_Value = g.Sum(x => x.t.DiscountValue.Value),
                              }).ToListAsync();

            ModelList dataList = new ModelList();
            dataList.transByDeptList = data;


            return dataList;
   
        }
        #endregion

        #region Get List of All Transactions by Domain gr by Cat
        public async Task<ModelList> GetAllTransByDomainByCatAsync(DateTime startDate, DateTime endDate, int domainId)
        {
            var data = await (from t in _StagingDbcontext.Transactions
                              join dd in _StagingDbcontext.DomainDepartments
                              on t.DepartmentId equals dd.DepartmentId
                              join c in _StagingDbcontext.Categories
                              on t.CategoryId equals c.CategoryId

                              where dd.DomainId == domainId
                              && t.TransactionDateTime >= startDate && t.TransactionDateTime <= endDate

                              group new { t, c } by new { t.CategoryId, c.CategoryName } into g

                              select new TransByCat()
                              {
                                  CategoryId = g.Key.CategoryId.Value,
                                  //select department name
                                  Category = g.Key.CategoryName,
                                  TransCount = g.Count(x => x.t.Sales_Ref.HasValue),
                                  Net_Value = g.Sum(x => x.t.Net_Amount.Value),
                                  Vat_Value = g.Sum(x => x.t.Vat_Amount.Value),
                                  Gross_Value = g.Sum(x => x.t.Selling_Price.Value),
                                  Gross_Sale_Value = g.Sum(x => x.t.TransactionTotal.Value),
                                  Discount_Value = g.Sum(x => x.t.DiscountValue.Value),
                              }).ToListAsync();

            ModelList dataList = new ModelList();
            dataList.transByCatList = data;


            return dataList;

        }
        #endregion

        #region Get List of All Transactions by Domain gr by SubCat
        public async Task<ModelList> GetAllTransByDomainBySubCatAsync(DateTime startDate, DateTime endDate, int domainId)
        {
            var data = await (from t in _StagingDbcontext.Transactions
                              join dd in _StagingDbcontext.DomainDepartments
                              on t.DepartmentId equals dd.DepartmentId
                              join sc in _StagingDbcontext.SubCategories
                              on t.SubCategoryId equals sc.SubCategoryId

                              where dd.DomainId == domainId
                              && t.TransactionDateTime >= startDate && t.TransactionDateTime <= endDate

                              group new { t, sc } by new { t.SubCategoryId, sc.SubCategoryName } into g

                              select new TransBySubCat()
                              {
                                  SubCategoryId = g.Key.SubCategoryId.Value,
                                  //select department name
                                  SubCategory = g.Key.SubCategoryName,
                                  TransCount = g.Count(x => x.t.Sales_Ref.HasValue),
                                  Net_Value = g.Sum(x => x.t.Net_Amount.Value),
                                  Vat_Value = g.Sum(x => x.t.Vat_Amount.Value),
                                  Gross_Value = g.Sum(x => x.t.Selling_Price.Value),
                                  Gross_Sale_Value = g.Sum(x => x.t.TransactionTotal.Value),
                                  Discount_Value = g.Sum(x => x.t.DiscountValue.Value),
                              }).ToListAsync();

            ModelList dataList = new ModelList();
            dataList.transBySubCatList = data;


            return dataList;

        }
        #endregion

        #region Get List of All Transactions by Domain gr by SubCat
        public async Task<ModelList> GetAllTransByDomainByItemAsync(DateTime startDate, DateTime endDate, int domainId)
        {
            var data = await (from t in _StagingDbcontext.Transactions
                              join dd in _StagingDbcontext.DomainDepartments
                                on t.DepartmentId equals dd.DepartmentId
                              join d in _StagingDbcontext.Domains
                                on dd.DomainId equals d.DomainId               
                              join dep in _StagingDbcontext.Departments
                                on t.DepartmentId equals dep.DepartmentId
                              join c in _StagingDbcontext.Categories
                                on t.CategoryId equals c.CategoryId
                              join sc in _StagingDbcontext.SubCategories
                                on t.SubCategoryId equals sc.SubCategoryId
                              join i in _StagingDbcontext.Items
                                on t.ItemId equals i.ItemId

                              where dd.DomainId == domainId
                              && t.TransactionDateTime >= startDate && t.TransactionDateTime <= endDate

                              group new { t, i, c, d, dep, sc } by new { t.ItemId, i.ItemDescription } into g

                              select new TransByItem()
                              {
                                  
                                  ItemId = g.Key.ItemId.Value,
                                  Item = g.Key.ItemDescription,
                                  TransCount = g.Count(x => x.t.Sales_Ref.HasValue),
                                  Net_Value = g.Sum(x => x.t.Net_Amount.Value),
                                  Vat_Value = g.Sum(x => x.t.Vat_Amount.Value),
                                  Gross_Value = g.Sum(x => x.t.Selling_Price.Value),
                                  Gross_Sale_Value = g.Sum(x => x.t.TransactionTotal.Value),
                                  Discount_Value = g.Sum(x => x.t.DiscountValue.Value),
                                  Domain = string.Join(",",g.Select(x=>x.d.DomainName).ToList()),
                                  Department = string.Join(",", g.Select(x => x.dep.DepartmentName)),
                                  Category = string.Join(",", g.Select(x => x.c.CategoryName)),
                                  SubCategory = string.Join(",", g.Select(x => x.sc.SubCategoryName)),
                              }).ToListAsync();

            ModelList dataList = new ModelList();
            dataList.transByItemList = data;


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
                //    var checks = (from b in _StagingDbcontext.Transactions
                //                     //  where EntityFunctions.DiffDays(firstDay, b.transdate) % 7 == 1
                //                 where (b.TransactionDateTime >= start && b.TransactionDateTime <= end) && System.Data.Entity.DbFunctions.DiffDays(start, b.TransactionDateTime)  == 10
                //                 select b).AsAsyncEnumerable();


                //var data = await (from i in _StagingDbcontext.Transactions
                //                  join j in _StagingDbcontext.DomainDepartments
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

                var checks1 = (from b in _StagingDbcontext.Transactions
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

               






                var checks2 = (from b in _StagingDbcontext.Transactions
                               where System.Data.Entity.DbFunctions.DiffDays(firstDay, b.TransactionDateTime) % 7 == 1
                               //where (b.TransactionDateTime >= start && b.TransactionDateTime <= end) && System.Data.Entity.DbFunctions.DiffDays(firstDay, b.TransactionDateTime) % 7 == 1
                               select b).ToList();

                DateTime now = DateTime.Now.Date;

            


                //var results = from d in _StagingDbcontext.Transactions
                //              where (DbFunctions.DiffDays(d.TransactionDateTime.Value.Date, now) < 2)
                                
                //              select d;

                //var results1 = (from d in _StagingDbcontext.Transactions
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

