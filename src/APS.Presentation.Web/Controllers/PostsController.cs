using APS.Application.Interfaces;
using APS.Application.ViewModel.Posts;
using APS.Presentation.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace APS.Presentation.Web.Controllers
{
    public class PostsController : Controller
    {

        private IPostAppService postAppService;

        public PostsController(IPostAppService postAppService)
        {
            this.postAppService = postAppService;
        }

        // GET: Post
        public ActionResult Index()
        {
            return View();
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Post/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        public ActionResult Cadastrar(PostModel model)
        {
            try
            {
                var listaPosts = (List<PostModel>)HttpContext.Session["ListaPosts"]; 
                if (listaPosts == null)
                    listaPosts = new List<PostModel>();

                model.Latitude = (double)HttpContext.Session["Latitude"];
                model.Longitude = (double)HttpContext.Session["Longitude"];

                listaPosts.Add(model);

                HttpContext.Session["ListaPosts"] = listaPosts;

                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Post/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public class PostModel {

            public string Nome { get; set; }
            public string Descricao { get; set; }
            public IEnumerable<string> ListaTags { get; set; }
            public IEnumerable<string> ListaImagens { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public string Distancia { get {
                    return HTMLUtils.DistanciaLatitudeLongitude(Latitude, Longitude);
            } }

            public PostModel() { }

        }
    }
}
