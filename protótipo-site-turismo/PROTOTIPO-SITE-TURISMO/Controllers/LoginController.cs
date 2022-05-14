using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROTOTIPO_SITE_TURISMO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROTOTIPO_SITE_TURISMO.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto db;

        public LoginController(Contexto contexto)
        {
            db = contexto;
        }

        // GET: LoginController
        public ActionResult Index()
        {
            return View(db.LOGIN.ToList());
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Entrar
        public ActionResult Entrar() //validação com login e senha do usuário - buscar no BD
        {
            return View();  

        }

        // POST: LoginController/Entrar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Entrar(string Usuario, string Senha)
        {
            if (Usuario == "admin" && Senha == "admin")
            {
                return RedirectToAction("Index");

            }
            else
            {
                return RedirectToAction("NaoLogado");
            }
            /*try
            {
                //db.LOGIN.Find(collection)
                //db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }*/
        }

        // GET: LoginController/CriarConta
        public ActionResult CriarConta()
        {
            return View();
        }

        // POST: LoginController/CriarConta
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CriarConta(Login collection)
        {
            try
            {
                db.LOGIN.Add(collection);
                db.SaveChanges();
                return RedirectToAction("Entrar");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
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
