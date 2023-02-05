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

namespace OTBIS.Web
{
    public class GetProductionService
    {
        #region Property
        private readonly StagingDbContext _stagingDbContext;

        #endregion

        #region Constructor
        public GetProductionService(StagingDbContext stagingDbContext)
        {
            _stagingDbContext = stagingDbContext;

        }
        #endregion

        #region Get List of All Transactions by Date Range and domian group by domain
        // public async Task<ModelList> GetAllTransByDomainAsync(DateTime startDate, DateTime endDate, int domainId)
        // {
        //var data = await (from i in _stagingDbContext.Transactions
        //                  join j in _stagingDbContext.DomainDepartments
        //                  on i.DepartmentId equals j.DepartmentId
        //                  where j.DomainId.Equals(domainId)
        //                  && i.TransactionDateTime >= startDate && i.TransactionDateTime <= endDate
        //                  group i by new { j.DomainId } into g
        //                  select new TransByDate()
        //                  {
        //                      TransDate = g.Key.DomainId,
        //                      TransCount = g.Select(i => i.Sales_Ref).Distinct().Count(),
        //                      Net_Value = g.Sum(i => i.Net_Amount),
        //                      Vat_Value = g.Sum(i => i.Vat_Amount),
        //                      Gross_Value = g.Sum(i => i.Selling_Price),
        //                      Gross_Sale_Value = g.Sum(i => i.TransactionTotal),
        //                      Discount_Value = g.Sum(i => i.DiscountValue),
        //                  }).ToListAsync();

        //ModelList dataList = new ModelList();
        //dataList.transByDatesList = data;


        //return dataList;
        // }

        #endregion
      
        //#region
        //public async Task<TransNetByCat[]> groupTransByCat(List<Transaction> list)
        //{

        //    List<TransNetByCat> test = new List<TransNetByCat>();

        //    //var query = TransNetByCat.GroupBy(o => new { CategoryName = o.CategoryName })
        //    //                .Select(s => new TransNetByCat() { CategoryName = s.Key.CategoryName, Net_Amount = s.Sum(o => o.Net_Amount), })
        //    //                .OrderBy(o => o.CategoryName).ToArray();

        //    return query;

        //}
        //#endregion

        #region Get List of All Transactions by domain
        public async Task<List<Transaction>> GetAllTransByDomainAsync(int DomainId)
        {
            var data = await (from i in _stagingDbContext.Transactions
                              join j in _stagingDbContext.DomainDepartments
                              on i.DepartmentId equals j.DepartmentId
                              where j.DomainId == DomainId
                              select i).OrderByDescending(c => c.TransactionDateTime).ToListAsync();

            return data;
        }

        #endregion
        #region Get List of All Transactions by domain within date
        public async Task<List<Transaction>> GetAllTransByDomainAsyncbyDate(int DomainId, DateTime startDate, DateTime endDate)
        {
            var data = await (from i in _stagingDbContext.Transactions
                              join j in _stagingDbContext.DomainDepartments
                              on i.DepartmentId equals j.DepartmentId
                              where j.DomainId == DomainId && i.TransactionDateTime >= startDate && i.TransactionDateTime <= endDate

                              select i).OrderByDescending(c => c.TransactionDateTime).ToListAsync();

            return data;
        }

        #endregion

    }

}
