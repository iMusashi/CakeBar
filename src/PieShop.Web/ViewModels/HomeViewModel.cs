using PieShop.Web.Models;
using System.Collections.Generic;

namespace PieShop.Web.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies{ get; set; }
    }
}
