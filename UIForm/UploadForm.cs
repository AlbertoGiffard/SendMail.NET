using AppLogic;
using Connection;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace UIForm
{
    public partial class UploadForm : Form
    {
        private Campaign campaign;
        private FileAttach fileAttacher;
        public UploadForm()
        {
            InitializeComponent();
        }

        private void btnSearchCampaign_Click(object sender, EventArgs e)
        {
            this.campaign = Connect.GetCampaign((int)numericUp.Value);

            if (this.campaign is null)
            {
                MessageBox.Show("No se consiguió la campaña que indica", "Error");
                btnSearchCampaign.BackColor = Color.Silver;
            }
            else
            {
                btnSearchCampaign.BackColor = Color.Lime;
                btnFind.Enabled = true;
            }

            btnFind.BackColor = Color.Silver;
            btnUpload.Enabled = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FileAttach fileAttach = new FileAttach();
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Selecciona el archivo para subir";
                open.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    //Obtiene la ruta
                    string path = open.FileName;
                    string appPath = Application.StartupPath + "\\FilesAttached\\" + open.SafeFileName;
                    if (fileAttach.ValidateSize(path))
                    {
                        lblNameFile.Text = open.SafeFileName;
                        btnSearchCampaign.BackColor = Color.Lime;

                        this.fileAttacher = new FileAttach(this.campaign.Id, open.SafeFileName, "\\FilesAttached\\" + open.SafeFileName);
                        this.campaign.FileAttacher = fileAttacher;
                        btnUpload.Enabled = true;

                        if (!File.Exists(appPath))
                        {
                            File.Copy(path, appPath);
                        }

                        btnFind.BackColor = Color.Lime;
                    }
                    else
                    {
                        MessageBox.Show("El peso máximo es de 5mb, intente nuevamente con otro archivo", "Error");
                    }
                }
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                ActionDataBase.SaveAttachment(this.fileAttacher);
                MessageBox.Show("Cargado correctamente", "Listo!");
                numericUp.Value = 1;
                lblNameFile.Text = string.Empty;
                btnUpload.Enabled = false;
                btnFind.Enabled = false;
                btnFind.BackColor = Color.Silver;
                btnSearchCampaign.BackColor = Color.Silver;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el archivo adjunto, intente en otro momento", "Error");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
