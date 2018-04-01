using APS.Application.Interfaces;
using APS.Application.ViewModel.Usuario;
using APS.Domain.Core.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APS.Presentation.Web.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioAppService usuarioAppService;

        public UsuariosController(IUsuarioAppService usuarioAppService)
        {
            this.usuarioAppService = usuarioAppService;
        }
        // GET: Usuarios
        public ActionResult Index()
        {
            return View(usuarioAppService.BuscarTodos());
        }
        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Remover(long id)
        {
            var usuario = usuarioAppService.BuscarPorId(id);
            return View(usuario);
        }

        public ActionResult Detalhes(long id)
        {
            var usuario = usuarioAppService.BuscarPorId(id);
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Remover(long id, CadastroViewModel cadastroViewModel)
        {
            try
            {
                usuarioAppService.Remover(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Cadastrar(CadastroViewModel cadastroViewModel)
        {
            try
            {
                usuarioAppService.Cadastrar(cadastroViewModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Atualizar(int id)
        {
            var viewmodel = usuarioAppService.BuscarPorId(id);
            return View(viewmodel);
        }

        // POST: Default/Edit/5
        [HttpPost]
        public ActionResult Atualizar(int id, CadastroViewModel cadastroViewModel)
        {
            try
            {
                usuarioAppService.Atualizar(cadastroViewModel);
                return RedirectToAction("Index");
            }
            catch (ServiceException e)
            {
                return View();
            }
            catch (Exception e)
            {
                return View();
            }
            
        }
    }
}