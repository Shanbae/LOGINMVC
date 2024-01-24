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

        public LoginViewModel()
        {
            logindto = new LoginDto(


                );
            //LoginViewModel = new LoginViewModel(logindto.Id);
        }
    }
}