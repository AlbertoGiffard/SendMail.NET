using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampaignSender
{
    public class BaseCampaign
    {
        private List<Campaign> campaignList;
        private string name;

        private BaseCampaign()
        {
            campaignList = new List<Campaign>();
        }
        public BaseCampaign(string name) : this()
        {
            this.name = name;
        }
        public List<Campaign> CampaignList { get => campaignList; set => campaignList = value; }
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Muestra el listado de las campañas creadas
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        public string ShowCampaigns()
        {
            StringBuilder sb = new StringBuilder();
            if (this.campaignList.Count > 0)
            {
                foreach (Campaign campaign in this.campaignList)
                {
                    sb.AppendLine($"{campaign.ToString()}");
                }
            }
            else
            {
                sb.AppendLine($"No hay campañas creadas");
            }

            return sb.ToString();
        }
        /// <summary>
        /// busca el id mas alto de la lista de campañas
        /// </summary>
        /// <param name="baseCampaign"></param>
        /// <returns>devuelve el numero mas alto</returns>
        public static int MaxId(BaseCampaign baseCampaign)
        {
            int result = -1;
            if (baseCampaign is null)
            {
                throw new Exception("Error Interno, la lista no puede sumar campañas.\nComuníquese con el programador");
            }
            else
            {
                try
                {
                    result = baseCampaign.campaignList.Max(c => c.Id);
                }
                catch (InvalidOperationException)
                {
                    return result = 1;
                }
            }

            return result;
        }
        /// <summary>
        /// Obtiene la campaña a partir del Id
        /// </summary>
        /// <param name="baseCampaign"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Campaign GetCampaign(BaseCampaign baseCampaign, int id)
        {
            Campaign campaign = null;

            foreach (Campaign c in baseCampaign.campaignList)
            {
                if (c.Id == id)
                {
                    campaign = c;
                    break;
                }
            }

            return campaign;
        }
        /// <summary>
        /// Realiza el listado de las campañas que cuenten con la misma fecha 
        /// en el rango pasado por parametro
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public string GetCampaignsFromTo(DateTime from, DateTime to)
        {
            StringBuilder sb = new StringBuilder();

            for (DateTime value = from; value.Day <= to.Day; )
            {
                if (this.campaignList.Count < 1)
                {
                    sb.AppendLine("Sin campañas registradas.");
                    break;
                }
                foreach (Campaign campaign in this.campaignList)
                {
                    if (campaign.Date.Year == value.Year && campaign.Date.Month == value.Month && campaign.Date.Day == value.Day)
                    {
                        sb.AppendLine(campaign.ToString());
                    }
                }

                value = value.AddDays(1);
            }

            return sb.ToString();
        }
        /// <summary>
        /// Suma una nueva campaña a la base de campañas
        /// </summary>
        /// <param name="baseCampaign"></param>
        /// <param name="campaign"></param>
        /// <returns>devuelve la base</returns>
        public static BaseCampaign operator +(BaseCampaign baseCampaign, Campaign campaign)
        {
            if (!(baseCampaign is null) && !(campaign is null))
            {
                if (baseCampaign != campaign)
                {
                    baseCampaign.campaignList.Add(campaign);
                }
                else
                {
                    throw new Exception($"La campaña con el ID {campaign.Id} ya existe");
                }
            }

            return baseCampaign;
        }
        /// <summary>
        /// Busca en la base de campañas si la campaña pasada en el operador 
        /// contiene el mismo id
        /// </summary>
        /// <param name="baseCampaign"></param>
        /// <param name="campaign"></param>
        /// <returns></returns>
        public static bool operator ==(BaseCampaign baseCampaign, Campaign campaign)
        {
            bool result = false;

            foreach (Campaign c in baseCampaign.campaignList)
            {
                if (c.Id == campaign.Id)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public static bool operator !=(BaseCampaign baseCampaign, Campaign campaign)
        {
            return !(baseCampaign == campaign);
        }
        /// <summary>
        /// Busca en la base de campañas si el id pasado en el operador 
        /// existe alguna campaña a partir del id pasado
        /// </summary>
        /// <param name="baseCampaign"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool operator ==(BaseCampaign baseCampaign, int id)
        {
            bool result = false;

            foreach (Campaign c in baseCampaign.campaignList)
            {
                if (c.Id == id)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
        public static bool operator !=(BaseCampaign baseCampaign, int id)
        {
            return !(baseCampaign == id);
        }
    }
}
