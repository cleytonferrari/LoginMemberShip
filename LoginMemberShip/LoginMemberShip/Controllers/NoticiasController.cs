using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginMemberShip.Controllers
{
    public class NoticiasController : Controller
    {
        //
        // GET: /Noticias/

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Administrador")]
        public ActionResult Administradores()
        {
            return View();
        }

        [Authorize(Roles = "Administrador,Redator")]
        public ActionResult Redatores()
        {
            return View();
        }
    }
}
