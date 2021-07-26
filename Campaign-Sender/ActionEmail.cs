using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignSender
{
    public static class ActionEmail
    {
        /// <summary>
        /// Agrega un nuevo email al listado de emails
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool AddNewEmail(Email email, List<Email> emailList)
        {
            bool result = false;

            if (email.EmailAddress != String.Empty)
            {
                emailList.Add(email);
                result = true;
            }

            return result;
        }
        /// <summary>
        /// agrega todo un listado de emails al atributo
        /// </summary>
        /// <param name="emailList"></param>
        /// <returns></returns>
        public static bool AddNewEmail(List<Email> emailList)
        {
            bool result = true;

            foreach (Email e in emailList)
            {
                if (e.EmailAddress != String.Empty)
                {
                    emailList.Add(e);
                }
            }

            return result;
        }
        /// <summary>
        /// Muestra todo el listado de emails de la instancia
        /// </summary>
        /// <returns></returns>
        public static string ShowAllEmails(Campaign campaign)
        {
            StringBuilder sb = new StringBuilder();

            if (campaign.EmailList.Count > 0)
            {
                foreach (Email email in campaign.EmailList)
                {
                    sb.AppendLine(email.ToString());
                }
            }
            else
            {
                sb.Append($"Aún sin destinatarios.");
            }

            return sb.ToString();
        }
        /// <summary>
        /// Remueve todo el listado de emails de la campaña
        /// </summary>
        /// <returns>devuelve tru si lo logró realizar</returns>
        public static bool RemoveAllEmails(Campaign campaign)
        {
            bool result = false;

            if (campaign.EmailList.Count > 0)
            {
                for (int i = 0; i < campaign.EmailList.Count; i++)
                {
                    campaign.EmailList.RemoveAt(i);
                    result = true;
                }
            }

            return result;
        }
    }
}
