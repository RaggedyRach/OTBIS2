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
using Humanizer;
//using System.Data.Entity.Core.Objects;
//using System.Data.Entity;

namespace OTBIS.Web.Services
{
    public class GetTillDataService
    {
        #region Property
        private readonly StagingDbcontext _stagingDbcontext;

        #endregion

        #region Constructor
        public GetTillDataService(StagingDbcontext stagingDbcontext)
        {
            _stagingDbcontext = stagingDbcontext;

             _stagingDbcontext.Database.SetCommandTimeout(180);

        }
        #endregion

        //#region Get List of All Transactions by Date Range
        //public async Task<ModelList> GetAllTransByDateRangeAsync(DateTime startDate, DateTime endDate)
        //{
        //    int idnum = 0;
        //    var data = await (from i in _stagingDbcontext.Transactions
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


        #region Get List of All Transactions by Date Range and Till
        public async Task<ModelList> GetAllTransByTillAndDateAsync(DateTime startDate, DateTime endDate, int tillId)
        {
            var data = await (from i in _stagingDbcontext.Transactions
                              join j in _stagingDbcontext.DomainDepartments
                              on i.DepartmentId equals j.DepartmentId
                              where i.TillId.Equals(tillId)
                              && i.TransactionDateTime >= startDate && i.TransactionDateTime <= endDate
                              group  i by new { i.TransactionDateTime.Value.Date} into g
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

            ModelList dataList = new ModelList();
            dataList.transByDatesList = data;


            return dataList;
        }

        #endregion

        #region Get List of All Transactions by Day and Till
        public async Task<ModelList> GetAllTransByTillByDayAsync(DateTime startDate, DateTime endDate, int tillId, DayOfWeek dayOfWeek)
        {
            //Func<Transaction, bool>isBetween = s => s.TransactionDateTime >= startDate && s.TransactionDateTime <= endDate;

            var data = await (from i in _stagingDbcontext.Transactions
                              where i.TillId.Equals(tillId)
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


        #region Get List of All Transactions by Month and Till
        public async Task<ModelList> GetAllTransByTillByMonthAsync(DateTime startDate, DateTime endDate, int tillId)
        {

            var data = await (from i in _stagingDbcontext.Transactions
                              where i.TillId.Equals(tillId)
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


        #region Get List of All Transactions by Till gr by Dept
        public async Task<ModelList> GetAllTransByTillByDeptAsync(DateTime startDate, DateTime endDate, int tillId)
        {
            var data = await (from t in _stagingDbcontext.Transactions
                              join d in _stagingDbcontext.Departments 
                              on t.DepartmentId equals d.DepartmentId

                              where t.TillId == tillId
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

        #region Get List of All Transactions by Till gr by Cat
        public async Task<ModelList> GetAllTransByTillByCatAsync(DateTime startDate, DateTime endDate, int tillId)
        {
            var data = await (from t in _stagingDbcontext.Transactions
                              join c in _stagingDbcontext.Categories
                              on t.CategoryId equals c.CategoryId

                              where t.TillId == tillId
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

        #region Get List of All Transactions by Till gr by SubCat
        public async Task<ModelList> GetAllTransByTillBySubCatAsync(DateTime startDate, DateTime endDate, int tillID)
        {
            var data = await (from t in _stagingDbcontext.Transactions
                              join sc in _stagingDbcontext.SubCategories
                              on t.SubCategoryId equals sc.SubCategoryId

                              where t.TillId == tillID
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

        #region Get List of All Transactions by Till gr by Item
        public async Task<ModelList> GetAllTransByTillByItemAsync(DateTime startDate, DateTime endDate, int tillId)
        {
            var data = await (from t in _stagingDbcontext.Transactions
                              join dd in _stagingDbcontext.DomainDepartments
                                on t.DepartmentId equals dd.DepartmentId
                              join d in _stagingDbcontext.Domains
                                on dd.DomainId equals d.DomainId               
                              join dep in _stagingDbcontext.Departments
                                on t.DepartmentId equals dep.DepartmentId
                              join c in _stagingDbcontext.Categories
                                on t.CategoryId equals c.CategoryId
                              join sc in _stagingDbcontext.SubCategories
                                on t.SubCategoryId equals sc.SubCategoryId
                              join i in _stagingDbcontext.Items
                                on t.ItemId equals i.ItemId

                              where t.TillId == tillId
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

      
    }

}

