using BussinesLogic.Logic;
using CommonSolution.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCToledo.Controllers
{
    public class TipoReclamoController : Controller
    {
        public ActionResult Agregar()
        {
            return View();
        }

        public ActionResult AgregarUsuario(dtoTipoDeReclamo dto)
        {
            L_TipoReclamoController tiporeclamoController = new L_TipoReclamoController();
            tiporeclamoController.AgregarTipoReclamo(dto);
            return View("Agregar");
        }
    }
}