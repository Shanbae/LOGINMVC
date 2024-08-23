using LOGIN3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.DynamicData.ModelProviders;

namespace LOGIN3.Models
{
    public class LoginViewModel
    {
        public LoginDto logindto { get; set; }
       // public LoginViewModel LoginViewModel { get; set; }
       public EducationDetails  education{ get; set; }
        public LoginViewModel()
        {
            logindto = new LoginDto(


                );
            education = new EducationDetails( );
            //LoginViewModel = new LoginViewModel(logindto.Id);
        }
    }
}