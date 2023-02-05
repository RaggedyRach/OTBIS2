using OTBIS.Web.Data.Interfaces;
using OTBIS.Web.Data.Production;
using OTBIS.Web.Data;
using OTBIS.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace OTBIS.Web.Services
{
    public class ComparedOnService

    {
        #region Property
        private readonly StagingDbContext _context;
        #endregion

        #region Constructor
        public ComparedOnService(StagingDbContext StagingContext)
        {
            _context = StagingContext;
        }
        #endregion

       // public List<ComparedOn> ComparedOns { get; set; } = new List<ComparedOn>();
        //public List<ComparedOn> ComparedOns  { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #region Get List of ComparedOns 
        public async Task<List<ComparedOn>> GetComparedOnsAsync()

        {
            var data = await (from i in _context.ComparedOns
                              select i).ToListAsync();
                            
            return data;
            

        }

        public List<ComparedOn> GetComparedOn()

        {


            var data =  (from i in _context.ComparedOns
                              select i).ToList();

            return data;
            //ComparedOns = await _context.ComparedOns.ToListAsync();

        }
        #endregion

        #region Add Comparison    
        public async Task<bool> AddComparison(ComparedOn NewCompare)
        {
            _context.ComparedOns.Add(NewCompare);
            await _context.SaveChangesAsync();
          
            return true;
        }
        #endregion
        //#region Property
        //private readonly MyDbContext _MyDbContext;
        //#endregion

        //#region Constructor
        //public Prod_TransactionService(MyDbContext myDbContext)
        //{
        //    _MyDbContext = myDbContext;
        //}
        //#endregion

        //#region Get List of Transactions    
        //public async Task<List<ProdTransaction>> GetAllProdTransaction()
        //{
        //    var data = await (from i in _MyDbContext.ProdTransactions
        //                      where i.ValueDate >= DateTime.Now.AddDays(-7)
        //                      select i).OrderByDescending(c => c.ValueDate).ToListAsync();
        //    return data;
        //}
        //#endregion


        //#region Add Comparison    
        //public async Task<bool> AddCategory(Category NewCompare)
        //{
        //    //_context.compareOn.Add(category);
            
        //    //await _MyDbContext.SaveChangesAsync();
        //    return true;
        //}
        //#endregion

    }
}


