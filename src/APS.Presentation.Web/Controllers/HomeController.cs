using APS.Application.Interfaces;
using APS.Application.ViewModel.Usuario;
using APS.Presentation.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace APS.Presentation.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUsuarioAppService _serviceUsuarios;

        public HomeController(IUsuarioAppService serviceUsuarios)
        {
            _serviceUsuarios = serviceUsuarios;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginUsuarioViewModel model)
        {
            var usuario = _serviceUsuarios.BuscarPorEmail(model.Email);
            if(usuario != null && usuario.Senha.Equals(model.Senha))
            {
                HttpContext.Session["UsuarioLogado"] = usuario;
                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Usuario ou senha Inválido!");
            }
        }
    }
}