using Microsoft.AspNetCore.Mvc;
using projeto_crudMVC_csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_crudMVC_csharp.Controllers
{
    public class ProdutosController : Controller
    {
        //criando uma lista estática:

        public static List<ProdutosClass> lsProdutos = new List<ProdutosClass>();


        public IActionResult Index()
        {
            return View(lsProdutos);//informar o model aqui 
        } 

        public IActionResult CreateProdutos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProdutos(ProdutosClass objeto)
        {
            lsProdutos.Add(objeto);
            return RedirectToAction("Index");
        }
    }
}
