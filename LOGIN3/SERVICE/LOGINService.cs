using LOGIN3.BR;
using LOGIN3.SERVICE.Iservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOGIN3.SERVICE
{
    public class LOGINService : ILOGINSERVICE,IREGISTRATIONSERVICE
    {

        public LOGIN Login(string userName, string passWord)
        {
            LOGIN ln = new LOGIN();


            return ln.Login(userName, passWord); ;
        }
        public REGISTRATION Register(REGISTRATION reg)
        {
           


            return reg.Register(reg); ;
        }
        //public interface IREGISTRATIONSERVICE
        //{
        //    REGISTRATION Register(REGISTRATION reg);
        //}
    }
   
}