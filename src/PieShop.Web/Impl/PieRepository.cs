using PieShop.Web.Core;
using PieShop.Web.Data;
using PieShop.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace PieShop.Web.Impl
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _appDbContext.Pies.ToList();
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.SingleOrDefault(p => p.Id == pieId);
        }
    }
}
