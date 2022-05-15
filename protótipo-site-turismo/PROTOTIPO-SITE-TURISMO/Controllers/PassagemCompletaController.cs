using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROTOTIPO_SITE_TURISMO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROTOTIPO_SITE_TURISMO.Controllers
{
    public class PassagemCompletaController : Controller
    {
        private readonly Contexto db;

        public PassagemCompletaController(Contexto contexto)
        {
            db = contexto;
        }

        // GET: PassagemCompletaController
        public IActionResult Pesquisa(string queryCidadeSaida, string queryCidadeChegada,
            string queryDataSaida, string queryDataChegada)
        {

            if (!(string.IsNullOrEmpty(queryCidadeSaida)))//se query for vazia ou nula, retorna lista de passagens
            {
                return View(db.PASSAGEMCOMPLETA.Where(a => a.CidadeSaida.Contains(queryCidadeSaida)));
            }
            if (!(string.IsNullOrEmpty(queryCidadeChegada)))
            {
                return View(db.PASSAGEMCOMPLETA.Where(a => a.CidadeChegada.Contains(queryCidadeChegada)));
            }
            if (!(string.IsNullOrEmpty(queryDataSaida)))
            {
                return View(db.PASSAGEMCOMPLETA.Where(a => a.DataSaida.Contains(queryDataSaida)));
            }
            if (!(string.IsNullOrEmpty(queryDataChegada)))
            {
                return View(db.PASSAGEMCOMPLETA.Where(a => a.DataChegada.Contains(queryDataChegada)));
            }
            else
            {
                return View(db.PASSAGEMCOMPLETA.ToList());
            }

        }
        
        [HttpPost]
        public ActionResult Pesquisa(string queryDataSaida)
        {
            if (string.IsNullOrEmpty(queryDataSaida))
            {
                TempData["erro"] = "Campo vazio. Tente novamente";
                return View();
            }


            return View();
        }//ÑÃO ESTA FUNCIONANDO - PAREI AQUI - IMPLEMENTAR FEEDBACK


        // GET: PassagemCompletaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PassagemCompletaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PassagemCompletaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PassagemCompleta collection)
        {
            try
            {
                db.PASSAGEMCOMPLETA.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PassagemCompletaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PassagemCompletaController/Edit/5
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

        // GET: PassagemCompletaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PassagemCompletaController/Delete/5
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
