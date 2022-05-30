using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prototipoSiteTurismo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace prototipoSiteTurismo.Controllers
{
    public class LoginController : Controller
    {
        public readonly Contexto db;//Banco de dados na controler
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
        public ActionResult EntrarLogin()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> EntrarLogin(string Email, string Senha)
        {
            Login usuarioLogado = db.LOGIN.Where(a => a.Email == Email && a.Senha == Senha).FirstOrDefault();

            if(usuarioLogado == null)
            {
                TempData["erro"] = "Usuário ou senha inválido";
                return View();
            }
            
            TempData["logado"] = "usuario.Nome";
            

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, usuarioLogado.Nome));
            claims.Add(new Claim(ClaimTypes.Sid, usuarioLogado.Id.ToString()));

            var userIdentity = new ClaimsIdentity(claims, "Acesso");
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync("CookieAuthentication", principal, new AuthenticationProperties());

            


            return Redirect("/Carrinho/Index");
        }

        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync("CookieAuthentication");
            return Redirect("/Login/EntrarLogin");
              
        }

        // GET: LoginController/Create
        public ActionResult CriarLogin()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CriarLogin(Login collection)
        {
            try
            {
                db.LOGIN.Add(collection);
                db.SaveChanges();                
                return RedirectToAction(nameof(EntrarLogin));
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
