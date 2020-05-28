using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCParte2.Controllers
{
    public class UsuariosController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaUsuarios()
        {
            List<string> listaUsuarios = new List<string>();
            listaUsuarios.Add("Fernando");
            listaUsuarios.Add("Alejandra");
            listaUsuarios.Add("Raul");
            listaUsuarios.Add("Martin");
            listaUsuarios.Add("Ernesto");

            //ViewBag.ListaUsuarios = listaUsuarios;
            //TempData["ListaUsuarios"] = listaUsuarios;
            //Session["ListaUsuarios"] = listaUsuarios;
            ViewData["ListaUsuarios"] = listaUsuarios;

            return View(listaUsuarios);
        }

        [HttpPost]
        public ActionResult ListaUsuarios(string selUsuarios)
        {
            ViewBag.Nombre = selUsuarios;
            //List<string> listaUsuarios = ViewBag.ListaUsuarios;
            //List<string> listaUsuarios = (List<string>)TempData["ListaUsuarios"];
            //List<string> listaUsuarios = (List<string>)Session["ListaUsuarios"];
            List<string> listaUsuarios = (List<string>)ViewData["ListaUsuarios"];
            return View(listaUsuarios);
        }



    }
}