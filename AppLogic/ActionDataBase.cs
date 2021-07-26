using Connection;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppLogic
{
    public static class ActionDataBase
    {
        /// <summary>
        /// Guarda una nueva campaña en la base de datos
        /// </summary>
        /// <param name="campaign"></param>
        /// <returns>true si lo logro realizar</returns>
        public static bool SaveCampaign(Campaign campaign)
        {
            return Connect.ExecuteQuery($"INSERT INTO Campaign (Subject, Date, FilePath, NameFile) VALUES ('{campaign.Subject}','{campaign.Date.Date}', '{null}', '{null}')");
        }
        /// <summary>
        /// realmente no elimina nada, sino que le saca el adjunto al row de la campaña
        /// </summary>
        /// <param name="campaign"></param>
        /// <returns>true si logro realizarlo</returns>
        public static bool DeleteFileAttach(Campaign campaign)
        {
            return Connect.ExecuteQuery($"UPDATE Campaign SET FilePath = NULL, NameFile = NULL WHERE Campaign.Id = {campaign.Id}");
        }
        /// <summary>
        /// Actualiza los campos de la campaña dentro de la base 
        /// </summary>
        /// <param name="fileAttacher"></param>
        /// <returns></returns>
        public static bool SaveAttachment(FileAttach fileAttacher)
        {
            return Connect.ExecuteQuery($"UPDATE Campaign SET FilePath = '{fileAttacher.FilePath}', NameFile = '{fileAttacher.NameFile}' WHERE Campaign.Id = {fileAttacher.CampaignId}");
        }
    }
}
