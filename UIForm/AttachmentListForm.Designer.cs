
namespace UIForm
{
    partial class AttachmentListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSince = new System.Windows.Forms.Label();
            this.dtSince = new System.Windows.Forms.DateTimePicker();
            this.dtUntil = new System.Windows.Forms.DateTimePicker();
            this.lblUntil = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rchTxtBoxCampaign = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // lblSince
            // 
            this.lblSince.AutoSize = true;
            this.lblSince.Location = new System.Drawing.Point(13, 13);
            this.lblSince.Name = "lblSince";
            this.lblSince.Size = new System.Drawing.Size(66, 25);
            this.lblSince.TabIndex = 1;
            this.lblSince.Text = "Desde:";
            // 
            // dtSince
            // 
            this.dtSince.Location = new System.Drawing.Point(85, 12);
            this.dtSince.Name = "dtSince";
            this.dtSince.Size = new System.Drawing.Size(250, 31);
            this.dtSince.TabIndex = 2;
            // 
            // dtUntil
            // 
            this.dtUntil.Location = new System.Drawing.Point(464, 13);
            this.dtUntil.Name = "dtUntil";
            this.dtUntil.Size = new System.Drawing.Size(250, 31);
            this.dtUntil.TabIndex = 5;
            // 
            // lblUntil
            // 
            this.lblUntil.AutoSize = true;
            this.lblUntil.Location = new System.Drawing.Point(392, 14);
            this.lblUntil.Name = "lblUntil";
            this.lblUntil.Size = new System.Drawing.Size(61, 25);
            this.lblUntil.TabIndex = 4;
            this.lblUntil.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(301, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 41);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rchTxtBoxCampaign
            // 
            this.rchTxtBoxCampaign.Location = new System.Drawing.Point(13, 147);
            this.rchTxtBoxCampaign.Name = "rchTxtBoxCampaign";
            this.rchTxtBoxCampaign.ReadOnly = true;
            this.rchTxtBoxCampaign.Size = new System.Drawing.Size(748, 241);
            this.rchTxtBoxCampaign.TabIndex = 7;
            this.rchTxtBoxCampaign.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(635, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 38);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AttachmentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 472);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rchTxtBoxCampaign);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtUntil);
            this.Controls.Add(this.lblUntil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtSince);
            this.Controls.Add(this.lblSince);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttachmentListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AttachmentListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSince;
        private System.Windows.Forms.DateTimePicker dtSince;
        private System.Windows.Forms.DateTimePicker dtUntil;
        private System.Windows.Forms.Label lblUntil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rchTxtBoxCampaign;
        private System.Windows.Forms.Button btnExit;
    }
}