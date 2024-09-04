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



        [HttpGet]
        public IActionResult Editar(int? id)
        {

            if(id == null || id == 0)
            {
                return NotFound("Id do emprestimo nulo ou 0");
            }
                                                                        //onde x(emprestimo) tiver o ID igual ao ID do paraemtro 
            EmprestimosModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id); // Apos consultar se o ID é nulo eu crio uma variavel emprestimo e atribuo a ela fazendo uma busca no banco
                                                                                            //os atributos do emprestimo que tenha o mesmo ID passado no parametro

            if(emprestimo == null)
            { 
                return NotFound("Emprestimo invalido");
            }


            return View(emprestimo);
        }


        [HttpPost]
        public IActionResult Editar(EmprestimosModel emprestimo)
        {

            if (ModelState.IsValid)
            {
                _db.Update(emprestimo);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(emprestimo);
            }

        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound("Id do emprestimo nulo ou 0");
            }
            EmprestimosModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id); 

            if (emprestimo == null)
            {
                return NotFound("Emprestimo invalido");
            }


            return View(emprestimo);
        }


        [HttpPost]
        public IActionResult Excluir(EmprestimosModel emprestimo)
        {

            if (ModelState.IsValid)
            {
                _db.Remove(emprestimo);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(emprestimo);
            }

        }


    }
}
