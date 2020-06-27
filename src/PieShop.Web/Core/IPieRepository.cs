using PieShop.Web.Models;
using System.Collections.Generic;

namespace PieShop.Web.Core
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();

        Pie GetPieById(int pieId);
    }
}