using Entity;
using System;
using System.Linq;
using System.Text;

namespace AppLogic
{
    public static class ActionBaseCampaign
    {
        public static string ShowCampaigns(BaseCampaign baseCampaign)
        {
            StringBuilder sb = new StringBuilder();
            if (baseCampaign.CampaignList.Count > 0)
            {
                foreach (Campaign campaign in baseCampaign.CampaignList)
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
                    result = baseCampaign.CampaignList.Max(c => c.Id);
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

            foreach (Campaign c in baseCampaign.CampaignList)
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
        public static string GetCampaignsFromTo(BaseCampaign baseCampaign, DateTime from, DateTime to)
        {
            StringBuilder sb = new StringBuilder();

            for (DateTime value = from; value.Day <= to.Day;)
            {
                if (baseCampaign.CampaignList.Count < 1)
                {
                    sb.AppendLine("Sin campañas registradas.");
                    break;
                }
                foreach (Campaign campaign in baseCampaign.CampaignList)
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
    }
}
