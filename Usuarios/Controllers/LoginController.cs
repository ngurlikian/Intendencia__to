using BussinesLogic.Logic;
using CommonSolution.Constantes;
using CommonSolution.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Usuarios.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated == true)
            {
                return Redirect("/Home");
            }

            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Login");
        }

        [HttpPost]
        public ActionResult Login(dtoLogin dto)
        {
            L_UsuarioController user = new L_UsuarioController();
            if (user.ValidarLogin(dto.username, dto.password))
            {
                FormsAuthentication.SetAuthCookie(dto.username, false);
                Session[CLogin.Session_Username] = dto.username;
                return Redirect("/Home");
            }
            else 
            {
                string error = "Usuario o contraseña no son correctos, o usuario no existe";
                ModelState.AddModelError("ErrorGeneral", error);
            }
            return View();
        } 
    }
}