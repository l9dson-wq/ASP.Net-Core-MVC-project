using Application.Service;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class PrestamosController : Controller
    {
        public PrestamosService PrestamosService;

        public PrestamosController()
        {
            PrestamosService = new PrestamosService();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PrestamosViewModel pm)
        {
            PrestamosService.SetPrestamo(pm);
            double testing = PrestamosService.GetAll();
            ViewBag.testing = Math.Round(testing,2); 
            return View();
        }
    }
}
