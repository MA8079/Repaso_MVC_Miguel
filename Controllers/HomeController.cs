using Repaso_MVC_Miguel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Repaso_MVC_Miguel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            EntradaDAO endao = new EntradaDAO();
            return View(endao.CargarEntrada());
        }
    }
}