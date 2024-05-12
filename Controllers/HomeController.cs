using Microsoft.AspNetCore.Mvc;
using WebApp2ByAsim.Services;

namespace WebApp2ByAsim.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(_productService.GetAll());
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
