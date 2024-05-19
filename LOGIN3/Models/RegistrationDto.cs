using LOGIN3.BR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOGIN3.Models
{
    public class RegistrationDto:BaseDto
    {
        public RegistrationDto() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DOB { get; set; }

        public REGISTRATION ToEntity(RegistrationDto dto)
        {
            REGISTRATION entity = new REGISTRATION();
            if (dto != null)
            {
                entity.Firstname = FirstName;
                        
                entity.Lastname = LastName;
                entity.Email = Email;   
                    entity.Password = ConfirmPassword;
                    entity.Phonenumber=PhoneNumber;
                    entity.DOB=DOB;

            }
            return entity;
        }
        

    }
}