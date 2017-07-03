using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext db = new BlogContext();

        // GET: Blog
        public ActionResult Index()
        {
            return View(db.Publicaciones.ToList());
        }

        public ActionResult Ver(int idPublicacion)
        {
            var publicacion = db.Publicaciones.Find(idPublicacion);
            return View(publicacion);
        }

        [ChildActionOnly]
        public ActionResult Aside()
        {
            return PartialView("_Aside", db.Publicaciones.OrderByDescending(p => p.Vistas).ToList());
        }
    }
}