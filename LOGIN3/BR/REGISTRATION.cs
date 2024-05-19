using LOGIN3.DAL;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace LOGIN3.BR
{
    public class REGISTRATION
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public long PersonID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Phonenumber { get; set; }
        public DateTime DOB { get; set; }


        public REGISTRATION Register(REGISTRATION reg)
        {
            this.AddRegistration(reg);
            this.SendEmail();
            

            return null;        


        }
        public void AddRegistration(REGISTRATION reg)
        {
            DataTable dt = null;
            LOGINDAL lOGINDAL = new LOGINDAL();
            lOGINDAL.fetchuRegsiter(reg.Email, dt);
            if (dt.Rows.Count>0)
            { 
            
            
            }
            else
            {
                lOGINDAL.RegistrationAdd(reg.Firstname, reg.Lastname, reg.Email, reg.Phonenumber, reg.Password, reg.DOB);

            }


        }
        public void SendEmail()
        {
            string senderMail = System.Configuration.ConfigurationManager.AppSettings["senderMail"].ToString();
            string senderPassword = System.Configuration.ConfigurationManager.AppSettings["senderPassword"].ToString();
            string emailbody = "<p>Hi!!! This is For testing Purpose.....<br>Don't send Reply Mail<br><br>Thanks and regards\r\n  </p>";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            //smtp.Timeout = 100000;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(senderMail, senderPassword);

            MailMessage mail = new MailMessage(senderMail, this.Email, "FOR UNDER TESTING", emailbody);
            mail.IsBodyHtml = true;
            mail.BodyEncoding = UTF8Encoding.UTF8;
            
            try
            {

                smtp.Send(mail);
            }
            catch (SmtpException e)
            {
                //textBox1.Text = e.Message;
            }


        }

    }
}