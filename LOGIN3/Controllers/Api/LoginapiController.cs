using LOGIN3.BR;
using LOGIN3.Models;
using LOGIN3.SERVICE;
using LOGIN3.SERVICE.Iservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.ApplicationServices;
using System.Web.Http;

//using System.Web.Mvc;

namespace LOGIN3.Controllers.Api
{
    public class LoginapiController : ApiController
    {
        // GET: LOGINAPI
        private readonly ILOGINSERVICE _loginService;
        private readonly IREGISTRATIONSERVICE _rEGISTRATIONSERVICE;
        public LoginapiController()
        {


        }
        public LoginapiController(ILOGINSERVICE loginService, IREGISTRATIONSERVICE rEGISTRATIONSERVICE)
        {
            _loginService = loginService ?? throw new ArgumentNullException(nameof(loginService));
            _rEGISTRATIONSERVICE= rEGISTRATIONSERVICE ?? throw new ArgumentNullException(nameof(rEGISTRATIONSERVICE));
        }
        //HttpResponseMessage _response;
        // GET: LOGIN
        
        [HttpPost]
        [Route("api/Loginapi/LoginPost")]
        public HttpResponseMessage LoginPost(LoginDto dto)
        {

            var entity = dto.ToEntity(dto);
            
            var result = _loginService.Login(entity.Username, entity.Password);

            return Request.CreateResponse(HttpStatusCode.OK, result)/*.new HttpResponseMessage(HttpStatusCode.OK,result)*/;
        }

        [HttpPost]
        [Route("api/Loginapi/Register")]
        public HttpResponseMessage Register(RegistrationDto dto)
        {
           // dto.ImgbyteData = dto.ImgbyteData.ToArray();
            
            var entity = dto.ToEntity(dto);
           // byte[] grrg = ; 
            var result = _rEGISTRATIONSERVICE.Register(entity);

            return Request.CreateResponse(HttpStatusCode.OK, "")/*.new HttpResponseMessage(HttpStatusCode.OK,result)*/;
        }
        //[HttpPost]
        //[Route("api/Loginapi/Webcam")]
        //public HttpResponseMessage Webcam([FromBody] byte[] data)
        //{
        //    return null;
        //}
    }
}