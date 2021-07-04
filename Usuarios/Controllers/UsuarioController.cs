using BussinesLogic.Logic;
using CommonSolution.Constantes;
using CommonSolution.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Usuarios.Helpers;

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
            if (usuarioController.ValidarAgregar(dto.NombreDeUsuario).Count() == 0) 
            {
                usuarioController.AgregarUsuario(dto);
            }
            else
            {
                string error = "El usuario ya existe ";
                ModelState.AddModelError("ErrorGeneral", error);
            }
            return View("Agregar");
        } 
            
               
            

    [UsertAuthentication]
        public ActionResult Eliminar(string user)
        {
            user = (string)Session[CLogin.Session_Username];
            L_UsuarioController usuarioController = new L_UsuarioController();
            List<string> colErrores = usuarioController.BorrarUsuario(user);
            FormsAuthentication.SignOut();
            Session.Clear();
            return Redirect("Login");
        }

        public ActionResult Lista(string user)
        {
            user = (string)Session[CLogin.Session_Username];
            L_UsuarioController usuarioCotroller = new L_UsuarioController();
            dtoUsuario model = usuarioCotroller.getUsuarioLogeado(user);

            return View(model);
        }
    }
}