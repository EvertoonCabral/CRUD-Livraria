using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivraria.Controllers
{
    public class EmprestimoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
