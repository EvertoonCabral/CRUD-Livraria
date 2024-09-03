using EmprestimoLivraria.Data;
using EmprestimoLivraria.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivraria.Controllers
{
    public class EmprestimoController : Controller
    {

        readonly private AplicationDbContext _db;

        public EmprestimoController(AplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos;

            return View(emprestimos);
        }

        [HttpPost]
        public IActionResult Cadastrar(EmprestimosModel emprestimo)
        {

            if (ModelState.IsValid)
            {
                _db.Add(emprestimo);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar() //metodo executado no index da View no botao de cadastrar emprestimo para ser aberto a view da tela
        {


            return View();
        }

    }
}
