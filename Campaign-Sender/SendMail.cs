using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignSender
{
    public static class SendMail
    {
        /// <summary>
        /// Se encarga de realizar el envío de la campaña
        /// </summary>
        /// <param name="campaign"></param>
        /// <returns>true si lo logro realizar</returns>
        public static bool SendCampaign(Campaign campaign)
        {
            bool result = false;
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            
            foreach (Email email in campaign.EmailList)
            {
                message.To.Add(email.EmailAddress);
            }

            message.Subject = campaign.Subject;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.Body = campaign.Body;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            //Este valor deberia ser variable, por practicidad se harcodea el mio como sender
            message.From = new System.Net.Mail.MailAddress("alberto.g@embluemail.com");

            try
            {
                using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient())
                {
                    client.Host = "smtp.fastgb.com";
                    client.Port = 2525;
                    client.EnableSsl = true;
                    client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("smtp_marketing", "nT1$EhzP0Pp9");
                    client.Send(message);
                }
                result = true;
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error al intentar enviar: " + e.Message);
            }

            return result;
        }
    }
}
