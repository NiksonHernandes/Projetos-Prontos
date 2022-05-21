using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prototipoSiteTurismo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prototipoSiteTurismo.Controllers
{
    public class PassagemController : Controller
    {
        public readonly Contexto db;//Banco de dados na controler
        public PassagemController(Contexto contexto)
        {
            db = contexto;
        }

        // GET: PassagemController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PesquisarPassagem()
        {
            return View(db.PASSAGEM.ToList());
        }


        // GET: PassagemController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PassagemController/Create
        public ActionResult CriarPassagem()
        {
            return View();
        }

        // POST: PassagemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CriarPassagem(Passagem collection)
        {
            try
            {
                db.PASSAGEM.Add(collection);
                db.SaveChanges();
                return RedirectToAction("PesquisarPassagem");
            }
            catch
            {
                return View();
            }
        }

        // GET: PassagemController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PassagemController/Edit/5
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

        // GET: PassagemController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PassagemController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
