using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using web_store_api.Application.DTOs;

namespace web_store_api.Application.Shared
{
    public class EmailSender
    {
        public static void SendEmail(string UserEmail)
        {
            try
            {
                MailMessage mail = new MailMessage("hgstore@gmail.com", UserEmail);

                mail.Subject = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
