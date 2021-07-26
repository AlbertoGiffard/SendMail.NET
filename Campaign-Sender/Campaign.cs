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
