
namespace UIForm
{
    partial class ScheduleForm
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
            this.lblSince = new System.Windows.Forms.Label();
            this.dtPickerSince = new System.Windows.Forms.DateTimePicker();
            this.dtPickerUntil = new System.Windows.Forms.DateTimePicker();
            this.lblUntil = new System.Windows.Forms.Label();
            this.rchTxtCampaignSended = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSince
            // 
            this.lblSince.AutoSize = true;
            this.lblSince.Location = new System.Drawing.Point(16, 16);
            this.lblSince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSince.Name = "lblSince";
            this.lblSince.Size = new System.Drawing.Size(66, 25);
            this.lblSince.TabIndex = 0;
            this.lblSince.Text = "Desde:";
            // 
            // dtPickerSince
            // 
            this.dtPickerSince.Location = new System.Drawing.Point(89, 12);
            this.dtPickerSince.Name = "dtPickerSince";
            this.dtPickerSince.Size = new System.Drawing.Size(250, 31);
            this.dtPickerSince.TabIndex = 1;
            // 
            // dtPickerUntil
            // 
            this.dtPickerUntil.Location = new System.Drawing.Point(489, 12);
            this.dtPickerUntil.Name = "dtPickerUntil";
            this.dtPickerUntil.Size = new System.Drawing.Size(250, 31);
            this.dtPickerUntil.TabIndex = 3;
            // 
            // lblUntil
            // 
            this.lblUntil.AutoSize = true;
            this.lblUntil.Location = new System.Drawing.Point(416, 16);
            this.lblUntil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUntil.Name = "lblUntil";
            this.lblUntil.Size = new System.Drawing.Size(61, 25);
            this.lblUntil.TabIndex = 2;
            this.lblUntil.Text = "Hasta:";
            // 
            // rchTxtCampaignSended
            // 
            this.rchTxtCampaignSended.Location = new System.Drawing.Point(16, 114);
            this.rchTxtCampaignSended.Name = "rchTxtCampaignSended";
            this.rchTxtCampaignSended.ReadOnly = true;
            this.rchTxtCampaignSended.Size = new System.Drawing.Size(723, 228);
            this.rchTxtCampaignSended.TabIndex = 4;
            this.rchTxtCampaignSended.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(599, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(314, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 43);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 404);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rchTxtCampaignSended);
            this.Controls.Add(this.dtPickerUntil);
            this.Controls.Add(this.lblUntil);
            this.Controls.Add(this.dtPickerSince);
            this.Controls.Add(this.lblSince);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de envíos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSince;
        private System.Windows.Forms.DateTimePicker dtPickerSince;
        private System.Windows.Forms.DateTimePicker dtPickerUntil;
        private System.Windows.Forms.Label lblUntil;
        private System.Windows.Forms.RichTextBox rchTxtCampaignSended;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
    }
}