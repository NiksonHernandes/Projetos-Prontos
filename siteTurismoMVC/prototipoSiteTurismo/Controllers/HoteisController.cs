using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prototipoSiteTurismo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prototipoSiteTurismo.Controllers
{
    public class HoteisController : Controller
    {
        public readonly Contexto db;//Banco de dados na controler
        public HoteisController(Contexto contexto)
        {
            db = contexto;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: HoteisController
        public ActionResult PesquisarHoteis(string queryNome, string queryCidade, string queryDataSaida, string queryDataChegada, string query, string itembusca)
        {
            if (!(string.IsNullOrEmpty(queryNome)))//se query for vazia ou nula, retorna lista de passagens
            {
                return View(db.HOTEIS.Where(a => a.Nome.Contains(queryNome)));
            }
            if (!(string.IsNullOrEmpty(queryCidade)))
            {
                return View(db.HOTEIS.Where(a => a.Cidade.Contains(queryCidade)));
            }
            if (!(string.IsNullOrEmpty(queryDataSaida)))
            {
                return View(db.HOTEIS.Where(a => a.DataSaida.Contains(queryDataSaida)));
            }
            if (!(string.IsNullOrEmpty(queryDataChegada)))
            {
                return View(db.HOTEIS.Where(a => a.DataChegada.Contains(queryDataChegada)));

            }

            //validação filtro interno
            if (string.IsNullOrEmpty(query))//se query for vazia ou nula, retorna lista de passagens
            {
                return View(db.HOTEIS.ToList());

            }
            else if (itembusca == "Todos")
            {
                return View(db.HOTEIS.ToList());
            }
            else if (itembusca == "Nome")
            {
                return View(db.HOTEIS.Where(a => a.Nome.Contains(query)));
            }
            else if (itembusca == "Cidade")
            {
                return View(db.HOTEIS.Where(a => a.Cidade.Contains(query)));
            }
            else if (itembusca == "Dchegada")
            {
                return View(db.HOTEIS.Where(a => a.DataChegada.Contains(query)));
            }
            else if (itembusca == "Dsaida")
            {
                return View(db.HOTEIS.Where(a => a.DataSaida.Contains(query)));
            }
            else
            {
                return View(db.HOTEIS.ToList());
            }

            
        }

        // GET: HoteisController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HoteisController/Create
        public ActionResult CriarHoteis()
        {
            return View();
        }

        // POST: HoteisController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CriarHoteis(Hoteis collection)
        {
            try
            {
                db.HOTEIS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HoteisController/Edit/5
        public ActionResult EditarHoteis(int id)
        {
            return View(db.HOTEIS.Where(a=> a.Id == id).FirstOrDefault());
        }

        // POST: HoteisController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarHoteis(int id, Hoteis collection)
        {
            try
            {
                db.HOTEIS.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HoteisController/Delete/5
        public ActionResult DeletarHoteis(int id)
        {
            db.HOTEIS.Remove(db.HOTEIS.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("PesquisarHoteis");
        }

        // POST: HoteisController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarHoteis(int id, IFormCollection collection)
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
