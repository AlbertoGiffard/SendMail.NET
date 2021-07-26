using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity 
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
