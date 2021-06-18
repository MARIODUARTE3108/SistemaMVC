using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC01.Models;
using ProjetoMVC01.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjetoMVC01.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Login(LoginModel model, [FromServices] UsuarioRepository usuarioRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var usuario = usuarioRepository.Consultar(model.Email, model.Senha);

                    if (usuario != null)
                    {
                        var identity = new ClaimsIdentity(new[] {new Claim(ClaimTypes.Name, usuario.Email) }, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);
                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        
                        return RedirectToAction("Index","Home");
                    }
                    else
                    {
                        TempData["Mensagem"] = "Acesso negado. Dados inválidos!";
                    }
                }
                catch (Exception e)
                {
                    TempData["Mesangem"] = "Erro: " + e.Message;
                }

            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
           
            return RedirectToAction("Login","Account");
        }
    }
}
