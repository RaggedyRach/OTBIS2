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
        public async Task<ModelList> GetAllTransByDomainByDayAsync(DateTime startDate, DateTime endDate, int domainId)
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

            ModelList dataList = new ModelList();
            dataList.transByDatesList = data;


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
                              group i by new { i.DepartmentId} into g
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
    }
}
