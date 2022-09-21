using Application.Service;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ZodiacoController : Controller
    {
        public ZodiacoService ZodiacService;

        public ZodiacoController()
        {
            ZodiacService = new ZodiacoService();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ZodiacoViewModel zm)
        {
            ZodiacService.SetZodiaco(zm);
            string ZodiacData = ZodiacService.GetAll();
            ViewBag.ZodiacData = ZodiacData;
            return View();
        }
    }
}
