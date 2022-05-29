using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prototipoSiteTurismo.Entidades;
using prototipoSiteTurismo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prototipoSiteTurismo.Controllers
{
    [Authorize(AuthenticationSchemes = "CookieAuthentication")] // proteção de tela -> vai pedir login para entrar aqui
    public class CarrinhoController : Controller
    {
        public readonly Contexto db;//Banco de dados na controler
        public CarrinhoController(Contexto contexto)
        {
            db = contexto;
        }

        //criando uma lista estática:
        public static List<Passagem> lsCarrinho = new List<Passagem>();

        // GET: CarrinhoController
        public ActionResult Index(int id)
        {
            Passagem item = db.PASSAGEM.Find(id);
            if(item == null)
            {

            }
            else
            {
                lsCarrinho.Add(item);
                TempData["Carrinho"] = lsCarrinho.Count;
                TempData["erro"] = "Passagem adiciona com sucesso!";
            }            
            return View(lsCarrinho);
        }

        // GET: CarrinhoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarrinhoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarrinhoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarrinhoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarrinhoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarrinhoController/Delete/5
        public ActionResult Delete(int id)
        {
            Passagem item = db.PASSAGEM.Find(id);

            return View(item);

        }

        // POST: CarrinhoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            Passagem item = db.PASSAGEM.Find(id);

            lsCarrinho.Clear();
            //lsCarrinho.Remove(item);
            return RedirectToAction("Index");
        }
    }
}
