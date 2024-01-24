using LOGIN3.BR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOGIN3.SERVICE.Iservices
{
   
        public interface ILOGINSERVICE
        {
            LOGIN Login(string userName, string passWord);
        }
    public interface IREGISTRATIONSERVICE
    {
        REGISTRATION Register(REGISTRATION reg);
    }

}