
namespace UIForm
{
    partial class UploadForm
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
            this.lblFind = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.numericUp = new System.Windows.Forms.NumericUpDown();
            this.btnSearchCampaign = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameFile = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFind.Location = new System.Drawing.Point(101, 165);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(144, 28);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Buscar Archivo:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(121, 27);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(448, 22);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Sube tu Archivo PDF a tu campaña seleccionada";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(81, 102);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(164, 28);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id de la campaña:";
            // 
            // numericUp
            // 
            this.numericUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUp.Location = new System.Drawing.Point(251, 97);
            this.numericUp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUp.Name = "numericUp";
            this.numericUp.Size = new System.Drawing.Size(150, 34);
            this.numericUp.TabIndex = 3;
            this.numericUp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSearchCampaign
            // 
            this.btnSearchCampaign.BackColor = System.Drawing.Color.Silver;
            this.btnSearchCampaign.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchCampaign.Location = new System.Drawing.Point(423, 94);
            this.btnSearchCampaign.Name = "btnSearchCampaign";
            this.btnSearchCampaign.Size = new System.Drawing.Size(186, 36);
            this.btnSearchCampaign.TabIndex = 4;
            this.btnSearchCampaign.Text = "Buscar Campaña";
            this.btnSearchCampaign.UseVisualStyleBackColor = false;
            this.btnSearchCampaign.Click += new System.EventHandler(this.btnSearchCampaign_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Silver;
            this.btnFind.Enabled = false;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(423, 162);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(186, 36);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Examinar...";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(207, 244);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 28);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nombre:";
            // 
            // lblNameFile
            // 
            this.lblNameFile.AutoSize = true;
            this.lblNameFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameFile.Location = new System.Drawing.Point(296, 244);
            this.lblNameFile.Name = "lblNameFile";
            this.lblNameFile.Size = new System.Drawing.Size(0, 28);
            this.lblNameFile.TabIndex = 7;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpload.Enabled = false;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpload.Location = new System.Drawing.Point(260, 314);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(186, 36);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Subir Archivo";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(611, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 36);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 441);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblNameFile);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSearchCampaign);
            this.Controls.Add(this.numericUp);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblFind);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uploadForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NumericUpDown numericUp;
        private System.Windows.Forms.Button btnSearchCampaign;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameFile;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnClose;
    }
}