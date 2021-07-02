using CampaignFileAttacher;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignSender
{
    public class Campaign
    {
        private int id;
        private string subject;
        private string body;
        private List<Email> emailList;
        private DateTime date;
        private FileAttacher fileAttacher;

        public Campaign()
        {
            this.emailList = new List<Email>();
            this.fileAttacher = null;
        }
        public Campaign(int id, string subject, string body, List<Email> emailList, DateTime date) : this()
        {
            this.id = id;
            this.subject = subject;
            this.body = body;
            this.emailList = emailList;
            this.date = date;
        }
        public Campaign(int id, string subject, string body, List<Email> emailList, DateTime date, FileAttacher fileAttacher) : this(id, subject, body, emailList, date)
        {
            this.fileAttacher = fileAttacher;
        }

        public int Id { get => this.id; set => this.id = value; }
        public string Subject { get => this.subject; set => this.subject = value; }
        public string Body { get => this.body; set => this.body = value; }
        public List<Email> EmailList { get => this.emailList; set => this.emailList = value; }
        public DateTime Date { get => this.date; set => this.date = value; }
        public FileAttacher FileAttacher { get => fileAttacher; set => fileAttacher = value; }

        /// <summary>
        /// Agrega un nuevo email al listado de emails
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool AddNewEmail(Email email)
        {
            bool result = false;

            if (email.EmailAddress != String.Empty)
            {
                this.emailList.Add(email);
                result = true;
            }

            return result;
        }
        /// <summary>
        /// agrega todo un listado de emails al atributo de la instancia
        /// </summary>
        /// <param name="emailList"></param>
        /// <returns></returns>
        public bool AddNewEmail(List<Email> emailList)
        {
            bool result = true;

            foreach (Email e in emailList)
            {
                if (e.EmailAddress != String.Empty)
                {
                    this.emailList.Add(e);
                }
            }

            return result;
        }
        /// <summary>
        /// Muestra todo el listado de emails de la instancia
        /// </summary>
        /// <returns></returns>
        public string ShowAllEmails()
        {
            StringBuilder sb = new StringBuilder();

            if (this.emailList.Count > 0)
            {
                foreach (Email email in this.EmailList)
                {
                    sb.AppendLine(email.ToString());
                }
            }
            else
            {
                sb.AppendLine($"Aún sin destinatarios.");
            }

            return sb.ToString();
        }
        /// <summary>
        /// Remueve todo el listado de emails de la campaña
        /// </summary>
        /// <returns>devuelve tru si lo logró realizar</returns>
        public bool RemoveAllEmails()
        {
            bool result = false;

            if (this.emailList.Count > 0)
            {
                for(int i = 0; i <= this.emailList.Count; i++)
                {
                    this.emailList.RemoveAt(i);
                    result = true;
                }
            }

            return result;
        }
        /// <summary>
        /// Sobreescribo el metodo para que retorne el id, el subject y la fecha
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = $"{this.Id} ; {this.Date} ; {this.Subject} ; {this.fileAttacher.NameFile}";

            return result;
        }
    }
}
