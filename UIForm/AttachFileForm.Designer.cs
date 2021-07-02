
namespace UIForm
{
    partial class AttachFileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCampaign = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(509, 59);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Campaign-File-Attacher";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(74, 93);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(419, 75);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Puedes subir archivos PDF a las campañas creadas, \r\ncambiar el archivo, borrar o " +
    "únicamente saber que\r\n campañas tienen subido algún archivo adjunto";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(212, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(101, 206);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(355, 42);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Subir Archivo...";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnCampaign
            // 
            this.btnCampaign.Location = new System.Drawing.Point(101, 265);
            this.btnCampaign.Name = "btnCampaign";
            this.btnCampaign.Size = new System.Drawing.Size(355, 42);
            this.btnCampaign.TabIndex = 4;
            this.btnCampaign.Text = "Listado de Campañas c/ Adjuntos";
            this.btnCampaign.UseVisualStyleBackColor = true;
            this.btnCampaign.Click += new System.EventHandler(this.btnCampaign_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(101, 327);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(355, 42);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Cambiar o Borrar Archivo";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // AttachFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCampaign);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttachFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AttachFileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCampaign;
        private System.Windows.Forms.Button btnChange;
    }
}