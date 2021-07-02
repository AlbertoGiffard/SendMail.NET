
namespace UIForm
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.rchTxtMsg = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimeSch = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblStatusActive = new System.Windows.Forms.Label();
            this.rchTxtTo = new System.Windows.Forms.RichTextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTxtMsg
            // 
            this.rchTxtMsg.Location = new System.Drawing.Point(12, 292);
            this.rchTxtMsg.Name = "rchTxtMsg";
            this.rchTxtMsg.Size = new System.Drawing.Size(636, 177);
            this.rchTxtMsg.TabIndex = 0;
            this.rchTxtMsg.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(867, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 54);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Campaign-Sender";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(484, 102);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 28);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(553, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(553, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 27);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(458, 134);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 28);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre:";
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmail.Location = new System.Drawing.Point(566, 168);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(184, 38);
            this.btnAddEmail.TabIndex = 6;
            this.btnAddEmail.Text = "Agregar Contacto";
            this.btnAddEmail.UseVisualStyleBackColor = true;
            this.btnAddEmail.Click += new System.EventHandler(this.btnAddEmail_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTo.Location = new System.Drawing.Point(11, 53);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(126, 25);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "Destinatarios:";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdd.Location = new System.Drawing.Point(553, 63);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(197, 25);
            this.lblAdd.TabIndex = 9;
            this.lblAdd.Text = "Agregar destinatarios:";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsg.Location = new System.Drawing.Point(12, 253);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(87, 25);
            this.lblMsg.TabIndex = 10;
            this.lblMsg.Text = "Mensaje:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.Location = new System.Drawing.Point(12, 213);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(75, 25);
            this.lblSubject.TabIndex = 11;
            this.lblSubject.Text = "Asunto:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(93, 211);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(339, 27);
            this.txtSubject.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(12, 167);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 25);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Fecha:";
            // 
            // dateTimeSch
            // 
            this.dateTimeSch.Location = new System.Drawing.Point(93, 167);
            this.dateTimeSch.Name = "dateTimeSch";
            this.dateTimeSch.Size = new System.Drawing.Size(339, 27);
            this.dateTimeSch.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(701, 308);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 25);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.Location = new System.Drawing.Point(716, 391);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(233, 41);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(875, 63);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(340, 100);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnList.Location = new System.Drawing.Point(955, 177);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(174, 29);
            this.btnList.TabIndex = 19;
            this.btnList.Text = "Ver listado";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(955, 391);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(233, 41);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblStatusActive
            // 
            this.lblStatusActive.AutoSize = true;
            this.lblStatusActive.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusActive.Location = new System.Drawing.Point(767, 308);
            this.lblStatusActive.Name = "lblStatusActive";
            this.lblStatusActive.Size = new System.Drawing.Size(0, 25);
            this.lblStatusActive.TabIndex = 21;
            // 
            // rchTxtTo
            // 
            this.rchTxtTo.Location = new System.Drawing.Point(12, 82);
            this.rchTxtTo.Name = "rchTxtTo";
            this.rchTxtTo.ReadOnly = true;
            this.rchTxtTo.Size = new System.Drawing.Size(419, 61);
            this.rchTxtTo.TabIndex = 22;
            this.rchTxtTo.Text = "";
            // 
            // btnAttach
            // 
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAttach.Location = new System.Drawing.Point(955, 225);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(174, 29);
            this.btnAttach.TabIndex = 23;
            this.btnAttach.Text = "Ver Adjuntos";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 479);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.rchTxtTo);
            this.Controls.Add(this.lblStatusActive);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dateTimeSch);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.btnAddEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rchTxtMsg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.Text = "Campaign Sender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtMsg;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddEmail;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimeSch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblStatusActive;
        private System.Windows.Forms.RichTextBox rchTxtTo;
        private System.Windows.Forms.Button btnAttach;
    }
}

