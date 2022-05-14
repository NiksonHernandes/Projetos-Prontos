using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROTOTIPO_SITE_TURISMO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROTOTIPO_SITE_TURISMO.Controllers
{
    public class PassagensController : Controller
    {
        private readonly Contexto db;

        public PassagensController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: PassagensController
        public ActionResult Index(string query, string itembusca)
        {
            if (string.IsNullOrEmpty(query))//se query for vazia ou nula, retorna lista de passagens
            {
                return View(db.PASSAGENS.ToList());
            }
            else if(itembusca == "Todos")
            {
                //return View(db.PASSAGENS.Where(a => a.Cidade.Contains(query)));
                return View(db.PASSAGENS.ToList());

            }
            else if(itembusca == "Cidade")
            {
                return View(db.PASSAGENS.Where(a => a.Cidade.Contains(query)));

            }else if (itembusca == "Preco")
            {
                
                return View(db.PASSAGENS.Where(a => a.Preco == System.Convert.ToDecimal(query))); 
            }
            else
            {
                return View(db.PASSAGENS.ToList());
            }
        }

        // GET: PassagensController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PassagensController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PassagensController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Passagens collection)
        {
            try
            {
                db.PASSAGENS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PassagensController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PassagensController/Edit/5
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

        // GET: PassagensController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PassagensController/Delete/5
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
