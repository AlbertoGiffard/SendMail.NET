using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignSender
{
    public class Email
    {
        private string emailAddress;
        private string name;

        public Email(string email, string name)
        {
            this.emailAddress = email;
            this.name = name;
        }

        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Sobreescribo el metodo para que traiga la direccion del email junto al nombre
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.EmailAddress};{this.Name}");

            return sb.ToString();
        }
    }
}
