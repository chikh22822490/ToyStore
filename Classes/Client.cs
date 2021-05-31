using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore.Classes
{
    class Client
    {
        public static void sendEmail(string adressFrom, string adressTo,string password)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(adressFrom);
                message.To.Add(new MailAddress(adressTo));
                message.Subject = "New toys added to our store!";
                message.Body = "You should check our new toy's collection, it too great";
                smtp.Port = 587;
                smtp.Host = "gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(adressFrom,password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
