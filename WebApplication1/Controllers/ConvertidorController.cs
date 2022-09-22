using Application.Service;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ConvertidorController : Controller
    {
        public ConvertidorService ConvertidorService;

        public ConvertidorController()
        {
            ConvertidorService = new();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ConvertidorViewModel cv)
        {
            ConvertidorService.Convert(cv);
            double valor = ConvertidorService.GetAll();
            ViewBag.Valor = Math.Round(valor, 2);
            return View();
        }
    }
}
