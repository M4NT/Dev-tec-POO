﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp_manha.Controllers
{
    public class Clientes : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(string Nome, string Telefone)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                TempData["Erro"] = "O campo nome não pode estar em branco";
            }

            if(string.IsNullOrEmpty(Telefone))
            {
                TempData["Erro"] = "O campo Telefone não pode estar em branco";
            }
            return View();
        }

        public IActionResult Editar(int id)
        {
            return View();
        }

        public IActionResult Excluir(int id)
        {
            return View();
        }


    }
}
