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

        public ActionResult AgregarTipoReclamo(dtoTipoDeReclamo dto)
        {
            L_TipoReclamoController tiporeclamoController = new L_TipoReclamoController();
            tiporeclamoController.AgregarTipoReclamo(dto);
            return View("Agregar");
        }

        public ActionResult Lista()
        {
            L_TipoReclamoController tipoReclamoController = new L_TipoReclamoController();
            List<dtoTipoDeReclamo> colDataModel = tipoReclamoController.getTipoReclamo();

            return View(colDataModel);
        }

        public ActionResult Eliminar(int NroDeTipoDeReclamo)
        {
            L_TipoReclamoController tipoReclamoController = new L_TipoReclamoController();
            List<string> colErrores = tipoReclamoController.BorrarTipoReclamo(NroDeTipoDeReclamo);

            return RedirectToAction("Lista");
        }

        public ActionResult Modificar(dtoTipoDeReclamo NroDeTipoDeReclamo)
        {
            L_TipoReclamoController tipoReclamoController = new L_TipoReclamoController();
            List<string> colErrores = tipoReclamoController.ModificarTipoReclamo(NroDeTipoDeReclamo);

            return RedirectToAction("Lista");
        }
    }
}