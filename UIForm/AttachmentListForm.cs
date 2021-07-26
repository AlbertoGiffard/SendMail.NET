using Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UIForm
{
    public partial class AttachmentListForm : Form
    {
        public AttachmentListForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtSince.Value.Day > dtUntil.Value.Day)
            {
                MessageBox.Show("La fecha de fin no puede ser menor a la fecha de inicio", "Error");
            }
            else
            {
                try
                {
                    rchTxtBoxCampaign.Text = Connect.GetCampaignsAttachFromTo(dtSince.Value, dtUntil.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo obtener la información intente en otro momento", "Error");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
