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


namespace OTBIS.Web.Services
{
    public class GetSeriesName
    {
        #region Property
        private readonly StagingDbcontext _StagingDbcontext;

        #endregion

        #region Constructor
        public GetSeriesName(StagingDbcontext StagingDbcontext)
        {
            _StagingDbcontext = StagingDbcontext;

             _StagingDbcontext.Database.SetCommandTimeout(180);

        }
        #endregion
        #region Get name of Department
        public async Task<string> GetSeriesDeptName(int deptId)
        {
            string name = "";
            var data = await (from i in _StagingDbcontext.Departments

                              where i.DepartmentId.Equals(deptId)

                              select i.DepartmentName).FirstOrDefaultAsync();
            if (data == null)
            {
                data = "";
            }

            return data;
        }

        #endregion



        #region Get List of All Transactions by Date Range and Category
        public async Task<string> GetSeriesCatName(int categoryId)
        {
            string name = "";
            var data = await (from i in _StagingDbcontext.Categories

                              where i.CategoryId.Equals(categoryId)

                              select i.CategoryName).FirstOrDefaultAsync();
            if (data == null)
            {
                data = "";
            }

            return data;
        }

        #endregion

    }

}

