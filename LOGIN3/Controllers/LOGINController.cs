using LOGIN3.Models;
using LOGIN3.SERVICE;
using LOGIN3.SERVICE.Iservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LOGIN3.Controllers
{
    public class LOGINController : Controller
    {
        private readonly ISTATESERVICE _stateService;

        //public LOGINController()
        //{

        //    //_stateService = new ISTATESERVICE();
        //}
        public LOGINController(ISTATESERVICE stateService)
        {
            _stateService = stateService ?? throw new ArgumentNullException(nameof(stateService));
           
        }
        // GET: LOGIN
        
        public ActionResult Index()
        {
            LoginViewModel loginViewModel = new LoginViewModel();

            return View("LOGIN",loginViewModel);
        }

        public ActionResult NewRegistration()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            return View("REGISTRATION");
        }

        public ActionResult EducationDetails()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            IEnumerable<StatesDto> states = null;
            IEnumerable<StatesDto> districts = null;
             states = _stateService.GetList();
             districts= _stateService.GetDistrictsList();
            loginViewModel.education.DistrictSelectList= districts;
            loginViewModel.education.StatesSelectList = states.Select(s => new SelectListItem
            {
                Value = s.StateID.ToString(),
                Text = s.StateName.ToString()
            }).ToList();

            //loginViewModel.education.DistrictSelectList = districts.Select(s => new SelectListItem
            //{
            //    Value = s.DistrictID.ToString(),
            //    Text = s.DistrictName.ToString(),
                
            //}).ToList();

            return View("EDUCATIONDETAILS", loginViewModel);
        }
    }
}