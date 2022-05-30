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
        public static List<Hoteis> lsCarrinhoHoteis = new List<Hoteis>();

        // GET: CarrinhoController
        public ActionResult Index(int id)
        {
            Passagem item = db.PASSAGEM.Find(id);
         

            if (item == null)
            {}
            else
            {
                lsCarrinho.Add(item);
                TempData["Carrinho"] = lsCarrinho.Count;
                TempData["erro"] = "Passagem adiciona com sucesso!";
            }

            return View(lsCarrinho);
        }

        public ActionResult IndexHoteis(int id)
        {

            Hoteis item = db.HOTEIS.Find(id);

            if (item == null)
            { }
            else
            {
                lsCarrinhoHoteis.Add(item);
                TempData["Carrinho"] = lsCarrinhoHoteis.Count;
                TempData["erro"] = "Hotel adicionado com sucesso!";
            }
            return View(lsCarrinhoHoteis);
        }

        public ActionResult DeleteHotel(int id)
        {
            Hoteis item = db.HOTEIS.Find(id);

            return View(item);

        }

        // POST: CarrinhoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteHotel(int id, IFormCollection collection)
        {
            Hoteis item = db.HOTEIS.Find(id);

            lsCarrinhoHoteis.Clear();
            //lsCarrinho.Remove(item);
            return RedirectToAction("IndexHoteis");
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
