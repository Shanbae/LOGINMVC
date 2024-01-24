using LOGIN3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LOGIN3.Controllers
{
    public class LOGINController : Controller
    {
        // GET: LOGIN
        public ActionResult Index()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
                return View("LOGIN",loginViewModel);
        }

        public ActionResult NewRegistration()
        {
            return View("REGISTRATION");
        }
    }
}