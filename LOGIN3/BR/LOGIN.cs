
using LOGIN3.DAL;
using System;
using System.Data;
using System.Text;

namespace LOGIN3.BR
{
    public class LOGIN
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public bool UnkownUser { get; set; }

        public bool AuthorizedUser { get; set; }
        public LOGIN Login(string userName, string passWord)
        {
            try
            {

                this.Username = userName;
                this.Password = passWord;
                DataTable dataTable = new DataTable();
                DateTime SESSIONDATE = DateTime.Today.Date;

                this.Password = Encryption(passWord);
                dataTable = usernamepasswordfetch(this.Username, this.Password);
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (Username == row["userName"].ToString())
                        {
                            AuthorizedUser = true;
                        }
                        else {
                            UnkownUser = true;
                        }
                    }
                }
                //else
                //{
                //    LOGINDAL lndal = new LOGINDAL();
                //    lndal.Add(this.Username, this.Password, SESSIONDATE);
                //}
                return this;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }
        public string Encryption(string passWord)
        {
            byte[] encrpassword = new byte[passWord.Length];
            encrpassword = Encoding.UTF8.GetBytes(passWord);
            return Convert.ToBase64String(encrpassword);
        }
        //public string Decryption(string Password)
        //{

        //}
        public DataTable usernamepasswordfetch(string userName, string passWord)
        {
            DataTable dt = new DataTable();
            LOGINDAL lndal = new LOGINDAL();
            dt = lndal.fetchusernamepassword(userName, passWord, dt);
            return dt;
        }
        //Validateuseraname()
        //{

        //}
    }


}
