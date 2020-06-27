using System.Collections.Generic;

namespace PieShop.Web.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();

        Pie GetPieById(int pieId);
    }
}