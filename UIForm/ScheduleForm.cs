using Connection;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UIForm
{
    public partial class ScheduleForm : Form
    {
        private BaseCampaign baseCampaign;
        /// <summary>
        /// Inicializa el atributo como una nueva base de campañas
        /// </summary>
        private ScheduleForm()
        {
            InitializeComponent();
            this.baseCampaign = new BaseCampaign("nombre");
        }
        public ScheduleForm(BaseCampaign baseCampaign) : this()
        {
            this.baseCampaign = baseCampaign;
        }
        /// <summary>
        /// Busca en la base de datos todas las campañas que cumplan con el datarange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(dtPickerSince.Value > dtPickerUntil.Value)
            {
                MessageBox.Show("La fecha de fin no puede ser menor a la fecha de inicio", "Error");
            }
            else
            {
                //Version sin base de datos
                //rchTxtCampaignSended.Text = this.baseCampaign.GetCampaignsFromTo(dtPickerSince.Value, dtPickerUntil.Value);
                //version con base de datos
                try
                {
                rchTxtCampaignSended.Text = Connect.GetCampaignsFromTo(dtPickerSince.Value, dtPickerUntil.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo obtener la información intente en otro momento", "Error");
                }
            }
        }
        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
