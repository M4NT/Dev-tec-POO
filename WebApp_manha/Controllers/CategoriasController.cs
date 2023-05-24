using Microsoft.AspNetCore.Mvc;
using WebApp_manha.Entidades;
using WebApp_manha.Models;

namespace WebApp_manha.Controllers
{
    public class CategoriasController : Controller
    {


        private Contexto db;
        public CategoriasController(Contexto _db)
        {
            this.db = _db;
        }
    
    




    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Lista( )
        {
            return View(db.Categorias.ToList());
        }

        public IActionResult Editar(int id)
        {
            Categorias item = db.Categorias.Find(id);
            if (item != null)
            {
                return View(item);
            }
            else
            {
                return RedirectToAction("Lista");
            }
        }
        [HttpPost]
        public IActionResult SalvarDados(CategoriaViewModel dados) 

    
        {

            Categorias entidade = new Categorias();
            entidade.Nome = dados.Nome;
            entidade.Id = dados.Id;
            entidade.Ativo = dados.Ativo == "on" ? true : false;

            if(entidade.Id > 0)
            {
                db.Categorias.Update(entidade);
                db.SaveChanges();
            }
            else
            {
                db.Categorias.Add(entidade);
                db.SaveChanges();
            }
           
            return RedirectToAction("Lista");
        }

        public IActionResult Excluir(int id)
        {
            Categorias item = db.Categorias.Find(id);
            if(item != null)
            {
                db.Categorias.Remove(item);
                db.SaveChanges();
            }
            return RedirectToAction("Lista");
        }

    

    }

}
