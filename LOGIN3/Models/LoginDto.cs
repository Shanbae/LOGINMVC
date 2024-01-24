using LOGIN3.BR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOGIN3.Models
{
    public class LoginDto:BaseDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        //public LoginDto(string Username,string Password) { }
        public LOGIN ToEntity(LoginDto dto) {

            var entity = new LOGIN();
            entity.Username = Username;
            entity.Password = Password;

            return entity;
        }
    }

}