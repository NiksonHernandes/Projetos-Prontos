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



        //if (string.IsNullOrEmpty(texto_input))
        //    {
        //        db.PASSAGEM.ToList();
        //        return RedirectToAction("PesquisarPassagem");
        //    }
        //    else
        //    {
        //        db.PASSAGEM.Where(a => a.CidadeSaida.Contains(texto_input) || a.CidadeChegada.Contains(texto_input) || a.DataSaida.Contains(texto_input)
        //        || a.DataChegada.Contains(texto_input) || a.Preco == System.Convert.ToDecimal(texto_input))
        //        return RedirectToAction("PesquisarPassagem");
        //    }

        public ActionResult PesquisarPassagem(string queryCidadeSaida, string queryCidadeChegada,
            string queryDataSaida, string queryDataChegada, string query, string itembusca)
        {
            if (!(string.IsNullOrEmpty(queryCidadeSaida)))//se query for vazia ou nula, retorna lista de passagens
            {
                return View(db.PASSAGEM.Where(a => a.CidadeSaida.Contains(queryCidadeSaida)));
            }
            if (!(string.IsNullOrEmpty(queryCidadeChegada)))
            {
                return View(db.PASSAGEM.Where(a => a.CidadeChegada.Contains(queryCidadeChegada)));
            }
            if (!(string.IsNullOrEmpty(queryDataSaida)))
            {
                return View(db.PASSAGEM.Where(a => a.DataSaida.Contains(queryDataSaida)));
            }
            if (!(string.IsNullOrEmpty(queryDataChegada)))
            {
                return View(db.PASSAGEM.Where(a => a.DataChegada.Contains(queryDataChegada)));

            }

            //validação filtro interno
            if (string.IsNullOrEmpty(query))//se query for vazia ou nula, retorna lista de passagens
            {
                return View(db.PASSAGEM.ToList());

            }else if(itembusca == "Todos")
            {
                return View(db.PASSAGEM.ToList());
            }
            else if (itembusca == "Cchegada")
            {
                return View(db.PASSAGEM.Where(a => a.CidadeChegada.Contains(query)));  
            }
            else if (itembusca == "Csaida")
            {              
                return View(db.PASSAGEM.Where(a => a.CidadeSaida.Contains(query)));
            }
            else if (itembusca == "Dchegada")
            {
                return View(db.PASSAGEM.Where(a => a.DataChegada.Contains(query)));
            }
            else if (itembusca == "Dsaida")
            {     
                return View(db.PASSAGEM.Where(a => a.DataSaida.Contains(query)));
            }
            else
            {
                return View(db.PASSAGEM.ToList());
            }

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CriarPassagem(Passagem collection)
        {
            try
            {
                db.PASSAGEM.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PassagemController/Edit/5
        public ActionResult EditarPassagem(int id)
        {
            return View(db.PASSAGEM.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: PassagemController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarPassagem(int id, Passagem collection)
        {
            try
            {
                db.PASSAGEM.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PassagemController/Delete/5
        public ActionResult DeletarPassagem(int id)
        {
            db.PASSAGEM.Remove(db.PASSAGEM.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("PesquisarPassagem");
        }

        // POST: PassagemController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarPassagem(int id, IFormCollection collection)
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
