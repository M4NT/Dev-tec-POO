using Microsoft.AspNetCore.Mvc;
using WebApp_manha.Models;

namespace WebApp_manha.Controllers
{
    public class ClientesController : Controller
    {
      public static List<ClienteViewModel> lista = new List<ClienteViewModel>();
        public IActionResult Lista()
        {
            //ClienteViewModel novo = new ClienteViewModel();
           
            //for (var i = 0; i <10; i++)
            //{
            //    novo.Id = 10;
            //    novo.Nome = "Guilherme Duarte";
            //    novo.Telefone = "(16)34567890";

            //    lista.Add(novo);

            //}

        
            return View(lista);
        }

        public IActionResult Cadastro()
        {
            return View();
          
        }
        [HttpPost]
        public IActionResult SalvarDados(ClienteViewModel model)
        {
            if(model.Id > 0)
            {
                int cliente = lista.FindIndex(a => a.Id == model.Id);
                lista[cliente] = model;
            }
            else
            {
                lista.Add(model);
                Random random = new Random();
                model.Id = random.Next(1, 9999);
            }
{          
           
        }
            return RedirectToAction("Lista");
         }

            [HttpPost]
        public IActionResult Cadastro(string Nome, string Telefone)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                TempData["Erro"] = "o campo nome não pode estar em branco";
            }
            if (string.IsNullOrEmpty(Telefone))
            {

                TempData["Erro"] = "o campo Telefone não pode estar em branco";
            }
            return View();
        }

        public IActionResult Editar(int id)
        {
            ClienteViewModel cliente = lista.Find(a => a.Id == id);
            if (cliente != null)
            {
                return View(cliente);
            }
            else
            {
                return RedirectToAction("Lista");
            }
            return View();
        }

        public IActionResult Excluir(int id)
        {
            ClienteViewModel cliente = lista.Find(a => a.Id == id); 
            if (cliente != null)
            {
                lista.Remove(cliente);
            }
            return RedirectToAction("Lista");
        }



    }
}




//public IActionResult Lista()
//{
//    ClienteViewModel novo = new ClienteViewModel();
//    novo.Nome = "Fernando Graciano";
//    novo.Id = 10;
//    novo.Telefone = "16991340447";

//    ClienteViewModel novo2 = new ClienteViewModel();
//    novo.Nome = "Julio Garcia";
//    novo.Id = 5;
//    novo.Telefone = "169874563214";

//    List<ClienteViewModel> lista = new List<ClienteViewModel>();
//    lista.Add(novo);
//    lista.Add(novo2);

//    return View(lista);
//}








