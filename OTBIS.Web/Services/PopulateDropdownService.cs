using Microsoft.EntityFrameworkCore;
using OTBIS.Web.Data;
using OTBIS.Web.Models;
using OTBIS.Web.Data.Production;
using OTBIS.Web.Services;

namespace OTBIS.Web.Services
{
    public class PopulateDropdownService
    {
        #region Property
        private readonly StagingDbcontext _context;
        #endregion

        #region Constructor
        public PopulateDropdownService(StagingDbcontext Stagingcontext)
        {
            _context = Stagingcontext;
        }
        #endregion

      
        #region Get List of Domains
        public async Task<List<Domain>> GetDomains()

        {
            var data = await (from i in _context.Domains
                              select i).ToListAsync();
            
            return data;
        

        }
        #endregion

        #region Get List of Domains matching id
        public async Task<List<Domain>> GetDomainsByiD(int id)

        {
            var data = await (from i in _context.Domains
                        where i.DomainId == 1
                        select i).ToListAsync();

            return data;


        }
        #endregion

        #region Get List of Domains NAMES only
        public async Task<List<String>> GetDomainsNames()

        {
            var data = await (from i in _context.Domains
                              select i.DomainName).ToListAsync();

            return data;


        }
        #endregion
        #region Get List of Departments
        public async Task<List<Department>> GetDepartments()

        {
            var data = await (from i in _context.Departments
                              select i).ToListAsync();

            return data;


        }
        #endregion
        #region Get List of Departments
        public async Task<List<string>> GetDepartmentsNames()

        {
            var data = await (from i in _context.Departments 
                              select i.DepartmentName).ToListAsync();

            return data;


        }
        #endregion
        #region Get List of Departments in a Domain
        public async Task<List<Department>> GetDepartmentsinDomain(int domainId)

        {
            var data = await (from i in _context.Departments
                              join j in _context.DomainDepartments on i.DepartmentId equals j.DepartmentId
                              where j.DomainId == domainId
                              select i).ToListAsync();

            return data;


        }
        #endregion

        #region Get List of Categories
        public async Task<List<Category>> GetCategories()

        {
            var data = await (from i in _context.Categories select i).ToListAsync();

            return data;


        }
        #endregion

        #region Get List of Categories Names
        public async Task<List<string>> GetCategoriesName()

        {
            var data =  await (from i in _context.Categories select i.CategoryName).ToListAsync();

            return data;


        }
        #endregion
        #region Get List of Categories in Department
        public async Task<List<Category>> GetCategoriesInDepartment(int departmentID)

        {
            var data = await (from i in _context.Categories 
                              join j in _context.DepartmentCategories on i.CategoryId 
                              equals j.CategoryId where j.DepartmentId == departmentID 
                              select i).ToListAsync();

        
            return data;


        }
        #endregion
        #region Get List of SubCategories
        public async Task<List<SubCategory>> GetSubCategories()

        {
            var data = await (from i in _context.SubCategories where i != null select i).ToListAsync();

            return data;


        }
        #endregion

        #region Get List of SubCategories Names
        public Task <List<string>> GetSubCategoriesNames()

        {
            var data =  (from i in _context.SubCategories where i != null select i.SubCategoryName).ToListAsync();

            return data;


        }
        #endregion

        #region Get List of SubCategories in Catagories
        public async Task<List<SubCategory>> GetSubCategoriesInCatagories(int CategoriesId)

        {
            var data =  await (from i in _context.SubCategories
                         join j in _context.CategorySubCategories on i.SubCategoryId equals j.SubCategoryId
                         where j.CategoryId == CategoriesId
                         select i).ToListAsync();


            return data;


        }
        #endregion

        #region Get List of NominalCodes 
        public async Task<List<NominalCode>> GetNominalCodes()

        {
            var data = await (from i in _context.NominalCodes where i != null select i).ToListAsync();

            return data;


        }
        #endregion


        #region Get List of NominalCodes Description 
        public async Task<List<string>> GetNominalCodesNames()

        {
            var data = await (from i in _context.NominalCodes
                        select i.NominalCodeDescription).ToListAsync();

            return data;


        }
        #endregion


        #region Get List of Discount Description 
        public async Task<List<string>> GetDiscoutDescpription()

        {
            var data = await (from i in _context.Discounts select i.DiscountDescription).ToListAsync();

            return data;


        }
        #endregion

        #region Get List of Discount Description in Domain
        public async Task<List<Discount>> GetDiscoutDescpriptionInDomain(int domainId)

        {
            var data = await (from i in _context.Discounts where i.Domainid == domainId select i).ToListAsync();

            return data;

          
        }
        #endregion

        #region Get List of Item in SubCat
        public async Task<List<Item>> GetIteminSubCat(int SubCatId)

        {
            var data = await (from i in _context.Items join j in _context.ItemSubCats on i.ItemId 
                              equals j.ItemId where j.SubCategoryId == SubCatId select i).ToListAsync();

            return data;


        }
        #endregion
        #region Get List of Item Description
        public async Task<List<string>> GetItemDescription()

        {
            var data = await (from i in _context.Items select i.ItemDescription).ToListAsync();

            return data;


        }
        #endregion

        //#region Get List of Transation Selling Price
        //public List<decimal> GetTransSellingPrice()

        //{
        //    var data =  (from i in _context.Transactions

        //                      select i.TransactionTotal).OrderBy(c => c).ToListAsync();

        //    return data;


        //}
        //#endregion

        #region Get List of Transaction Net Prices 
        public async Task<List<decimal?>> GetTransNetPrices()

        {
            var data = await (from i in _context.Transactions select i.Net_Amount).ToListAsync();

            return data;


        }
        #endregion

        #region Get List of Tills
        public async Task<List<Till>> GetTills()

        {
            //var data = _context.Tills.Where(c => c.Name).ToList();
            //if (!c.Name.IsNullOrEmpty(c=) ? false : c).toList();

         
            var data = await (from i in _context.Tills
                        where i != null
                              select i).ToListAsync();

            return data;


        }
        #endregion

        #region Get List of Clerks
        public async Task<List<Clerk>> GetClerks(int domainId)

        {
            var data = await (from i in _context.Clerks where i.DomainId == domainId select i).ToListAsync();

            return data;


        }
        #endregion


        #region Get List of Payment Types
        public async Task<List<PaymentType>> GetPaymentTypes()

        {
            var data =  await (from i in _context.PaymentTypes
                        select i).ToListAsync();

            return data;


        }
        #endregion

        #region Get date range start
        public async Task<DateTime> getDateStart()

        {
            DateTime dateStart = DateTime.MinValue;

            var data = await (from i in _context.Transactions

                        select i.TransactionDateTime).FirstAsync();
            if (data != null) 
            {
                dateStart = data.Value;
            }     
                        
            return dateStart;
        }
        #endregion
    }
}
