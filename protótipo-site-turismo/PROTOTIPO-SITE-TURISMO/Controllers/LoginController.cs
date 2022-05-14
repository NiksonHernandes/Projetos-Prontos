using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROTOTIPO_SITE_TURISMO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        public async Task<ActionResult> Entrar(string Usuario, string Senha)
        {
            if (string.IsNullOrEmpty(Usuario) || string.IsNullOrEmpty(Senha))
            {
                TempData["erro"] = "Campo vazio. Tente novamente";
                return View();
            }

            Entidades.Login usuarioLogado = db.LOGIN.Where(a => a.Usuario == Usuario && a.Senha == Senha).FirstOrDefault();

            if(usuarioLogado == null)
            {
                TempData["erro"] = "Usuário ou senha inválido";
                return View();
            }

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, usuarioLogado.Nome));
            claims.Add(new Claim(ClaimTypes.Sid, usuarioLogado.Id.ToString()));

            var userIdentity = new ClaimsIdentity(claims, "Acesso");
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync("CookieAuthentication", principal, new AuthenticationProperties());

            return Redirect("/Passagens/Index");
      
        }

        public async Task<ActionResult> Logoff() //deslogar
        {
            await HttpContext.SignOutAsync("CookieAuthentication");
            ViewData["ReturnUrl"] = "/";
            return Redirect("/Login/Entrar");
        }

        // GET: LoginController/CriarConta
        public ActionResult CriarConta()
        {
            return View();
        }

        // POST: LoginController/CriarConta
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CriarConta(Login collection, Login dadosTela)
        {
            try
            {
                if (string.IsNullOrEmpty(dadosTela.Nome) && string.IsNullOrEmpty(dadosTela.Usuario) && string.IsNullOrEmpty(dadosTela.Senha))
                {
                    TempData["erro"] = "Todos os campos em branco!";
                    return View();
                }if (string.IsNullOrEmpty(dadosTela.Nome))
                {
                    TempData["erro"] = "Campo de nome não pode estar em branco!";
                    return View();
                }
                if (string.IsNullOrEmpty(dadosTela.Usuario))
                {
                    TempData["erro"] = "Campo de login não pode estar em branco!";
                    return View();

                }
                if (string.IsNullOrEmpty(dadosTela.Senha))
                {
                    TempData["erro"] = "Campo de senha não pode estar em branco!";
                    return View();

                }
                
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
