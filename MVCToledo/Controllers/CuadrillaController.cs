using BussinesLogic.Logic;
using CommonSolution.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCToledo.Controllers
{
    public class CuadrillaController : Controller
    {
        public ActionResult Agregar()
        {
            return View();
        }

        public ActionResult AgregarCuadrilla(dtoCuadrilla dto)
        {
            L_CuadrillaController cuadrillaController = new L_CuadrillaController();
            cuadrillaController.AgregarCuadrilla(dto);
            return View("Agregar");
        }

        public ActionResult Lista()
        {
            L_CuadrillaController cuadrillaController = new L_CuadrillaController();
            List<dtoCuadrilla> colDataModel = cuadrillaController.getCuadrilla();

            return View(colDataModel);
        }
    }
}