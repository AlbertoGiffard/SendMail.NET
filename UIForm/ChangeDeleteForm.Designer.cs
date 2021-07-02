
namespace UIForm
{
    partial class ChangeDeleteForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblNameFile = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearchCampaign = new System.Windows.Forms.Button();
            this.numericUp = new System.Windows.Forms.NumericUpDown();
            this.lblId = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblNewFile = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblNewFileChange = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(477, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 36);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Silver;
            this.btnChange.Enabled = false;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChange.Location = new System.Drawing.Point(65, 211);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(186, 36);
            this.btnChange.TabIndex = 18;
            this.btnChange.Text = "Cambiar adjunto...";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblNameFile
            // 
            this.lblNameFile.AutoSize = true;
            this.lblNameFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameFile.Location = new System.Drawing.Point(189, 153);
            this.lblNameFile.Name = "lblNameFile";
            this.lblNameFile.Size = new System.Drawing.Size(0, 28);
            this.lblNameFile.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(100, 153);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 28);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Nombre:";
            // 
            // btnSearchCampaign
            // 
            this.btnSearchCampaign.BackColor = System.Drawing.Color.Silver;
            this.btnSearchCampaign.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchCampaign.Location = new System.Drawing.Point(367, 95);
            this.btnSearchCampaign.Name = "btnSearchCampaign";
            this.btnSearchCampaign.Size = new System.Drawing.Size(186, 36);
            this.btnSearchCampaign.TabIndex = 14;
            this.btnSearchCampaign.Text = "Buscar Campaña";
            this.btnSearchCampaign.UseVisualStyleBackColor = false;
            this.btnSearchCampaign.Click += new System.EventHandler(this.btnSearchCampaign_Click);
            // 
            // numericUp
            // 
            this.numericUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUp.Location = new System.Drawing.Point(195, 98);
            this.numericUp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUp.Name = "numericUp";
            this.numericUp.Size = new System.Drawing.Size(150, 34);
            this.numericUp.TabIndex = 13;
            this.numericUp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(25, 98);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(164, 28);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id de la campaña:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(65, 28);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(448, 22);
            this.lblText.TabIndex = 11;
            this.lblText.Text = "Sube tu Archivo PDF a tu campaña seleccionada";
            // 
            // lblNewFile
            // 
            this.lblNewFile.AutoSize = true;
            this.lblNewFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewFile.Location = new System.Drawing.Point(30, 273);
            this.lblNewFile.Name = "lblNewFile";
            this.lblNewFile.Size = new System.Drawing.Size(221, 28);
            this.lblNewFile.TabIndex = 10;
            this.lblNewFile.Text = "Nombre nuevo adjunto:";
            this.lblNewFile.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(307, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(186, 36);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Eliminar Adjunto";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNewFileChange
            // 
            this.lblNewFileChange.AutoSize = true;
            this.lblNewFileChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewFileChange.Location = new System.Drawing.Point(251, 273);
            this.lblNewFileChange.Name = "lblNewFileChange";
            this.lblNewFileChange.Size = new System.Drawing.Size(0, 28);
            this.lblNewFileChange.TabIndex = 21;
            this.lblNewFileChange.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(189, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 36);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Guardar Cambios";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChangeDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 451);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNewFileChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblNameFile);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSearchCampaign);
            this.Controls.Add(this.numericUp);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblNewFile);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangeDeleteForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblNameFile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearchCampaign;
        private System.Windows.Forms.NumericUpDown numericUp;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblNewFile;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblNewFileChange;
        private System.Windows.Forms.Button btnSave;
    }
}