using System.Net;
using System.Net.Mail;
namespace GenderEqualityApp
{
    internal class EmailRegister
    {
        SmtpClient smtpClient;
        static string fromMail = "alphagrp5.official@gmail.com";
        static string password = "grp5Alpha";
        public EmailRegister()
        {
            smtpClient = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromMail, password)
            };
        }

        public void Send (string body, string toAddr)
        {
            using (var m = new MailMessage(fromMail, toAddr)
            {
                Subject = "Verification Code",
                Body = body,
            })
            {
                m.IsBodyHtml = true;
                smtpClient.Send(m);
            }
        }
    }
}