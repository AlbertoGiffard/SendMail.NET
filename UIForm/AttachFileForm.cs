using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UIForm
{
    public partial class AttachFileForm : Form
    {
        public AttachFileForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            UploadForm uploadForm = new UploadForm();
            uploadForm.ShowDialog();
        }

        private void btnCampaign_Click(object sender, EventArgs e)
        {
            AttachmentListForm attachmentListForm = new AttachmentListForm();
            attachmentListForm.ShowDialog();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeDeleteForm changeDeleteForm = new ChangeDeleteForm();
            changeDeleteForm.ShowDialog();
        }
    }
}
