using Entity;
using Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using AppLogic;

namespace UIForm
{
    public partial class ChangeDeleteForm : Form
    {
        private Campaign campaign;
        private FileAttach fileAttacher;
        public ChangeDeleteForm()
        {
            InitializeComponent();
        }

        private void btnSearchCampaign_Click(object sender, EventArgs e)
        {
            try
            {
                this.campaign = Connect.GetCampaignWithAttach((int)numericUp.Value);
            }
            catch (Exception)
            {
                MessageBox.Show("No se logró conseguir la campaña intente en otro momento", "Error");
            }

            if (this.campaign is null)
            {
                MessageBox.Show("No se consiguió la campaña que indica o no posee un archivo adjunto", "Error");
                btnSearchCampaign.BackColor = Color.Silver;
                this.CleanForm();
            }
            else
            {
                btnSearchCampaign.BackColor = Color.Lime;
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
                lblNameFile.Text = this.campaign.FileAttacher.NameFile;
            }
        }
        private void CleanForm()
        {
            btnSearchCampaign.BackColor = Color.Silver;
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            lblNameFile.Text = string.Empty;
            lblNewFile.Visible = false;
            lblNewFileChange.Visible = false;
            lblNewFileChange.Text = string.Empty;
            btnSave.Visible = false;
            btnSave.Enabled = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.campaign is null)
            {
                MessageBox.Show("No hay una campaña cargada", "Error");
            }
            else
            {
                try
                {
                    ActionDataBase.DeleteFileAttach(this.campaign);
                    MessageBox.Show("Se logro eliminar el adjunto con éxito", "Listo!");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se logro eliminar el adjunto intente en otro momento", "Error");
                }
            }
            this.CleanForm();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            lblNewFile.Visible = true;
            btnSave.Visible = true;
            lblNewFileChange.Visible = true;
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
                        this.fileAttacher = new FileAttach(this.campaign.Id, open.SafeFileName, "\\FilesAttached\\" + open.SafeFileName);
                        lblNewFileChange.Text = open.SafeFileName;
                        btnSearchCampaign.BackColor = Color.Lime;

                        this.campaign.FileAttacher = fileAttacher;
                        btnSave.Enabled = true;

                        if (!File.Exists(appPath))
                        {
                            File.Copy(path, appPath);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El peso máximo es de 5mb, intente nuevamente con otro archivo", "Error");
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ActionDataBase.SaveAttachment(this.fileAttacher);
                MessageBox.Show("Cargado correctamente", "Listo!");
                numericUp.Value = 1;
                this.CleanForm();
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
