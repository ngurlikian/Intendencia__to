using BussinesLogic.Logic;
using CommonSolution.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCToledo.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Agregar()
        {
            return View();
        }

        public ActionResult AgregarUsuario(dtoUsuario dto)
        {
            L_UsuarioController usuarioController = new L_UsuarioController();
            usuarioController.AgregarUsuario(dto);
            return View("Agregar");
        }
    }
}