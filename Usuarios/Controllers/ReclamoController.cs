using BussinesLogic.Logic;
using CommonSolution.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Usuarios.Controllers
{
    public class ReclamoController : Controller
    {
        public ActionResult Agregar()
        {
            return View();
        }

        public ActionResult AgregarReclamo(dtoReclamo dto)
        {
            L_ReclamoController reclamoController = new L_ReclamoController();
            reclamoController.AgregarReclamo(dto);
            return RedirectToAction("Mapa");
        }
    }
}