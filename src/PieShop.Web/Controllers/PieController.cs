using PieShop.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PieShop.Web.Controllers
{
    public class PieController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Pie Overview";

            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);
            return View(pies);
        }

        private readonly IPieRepository _pieRepository;

        public PieController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public ViewResult List()
        {
            return View(_pieRepository.GetAllPies());
        }
    }
}