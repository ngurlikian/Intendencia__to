using BussinesLogic.Logic;
using CommonSolution.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Usuarios.Controllers
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

        public ActionResult Eliminar(string NombreDeUsuario)
        {
            L_UsuarioController usuarioController = new L_UsuarioController();
            List<string> colErrores = usuarioController.BorrarUsuario(NombreDeUsuario);

            return View();
        }
    }
}