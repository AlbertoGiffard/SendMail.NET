using AppLogic;
using Connection;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIForm
{
    public delegate void ShowStatus();
    public partial class MainFrm : Form
    {
        private Thread status;
        private bool stopped;
        private bool stateSend;
        private List<Email> emailList;
        private BaseCampaign baseCampaign;
        public MainFrm()
        {
            InitializeComponent();
            this.emailList = new List<Email>();
            this.baseCampaign = new BaseCampaign("Prueba");
            this.stopped = false;
            this.stateSend = false;
        }
        /// <summary>
        /// Inicializo el thread que se encarga de realizar la lectura de los campos que verifiquen que esten completos, asi como se cargan dos campañas de pruebas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_Load(object sender, EventArgs e)
        {
            this.status = new Thread(this.Changed);
            status.Start();
            //valores de prueba para la version sin base de datos
            Campaign c1 = new Campaign(1, "subject1", "body1", this.emailList, DateTime.Now);
            Campaign c2 = new Campaign(2, "subject2", "body2", this.emailList, DateTime.Now);
            this.baseCampaign += c1;
            this.baseCampaign += c2;
        }
        /// <summary>
        /// Verifica que si el lbl dice listo para enviar realice la llamada a los metodos que se encargan de ejecutar la logica
        /// IMPORTANTE: Puede llegar a demorar en realizar el envío así como en llegar el mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            int id;

            if (lblStatusActive.Text == "Listo para enviar")
            {
                this.stateSend = true;
                try
                {
                    id = ActionBaseCampaign.MaxId(this.baseCampaign);
                    if (id != 1)
                    {
                        id++;
                    }
                    Campaign campaign = new Campaign(id, txtSubject.Text, rchTxtMsg.Text, this.emailList, dateTimeSch.Value);
                    //agrega la campaña al atributo (para version sin base de datos)
                    //this.baseCampaign += campaign;
                    //Realiza el envío de la campaña
                    SendMail.SendCampaign(campaign);
                    //guarda la campaña en la base de datos
                    ActionDataBase.SaveCampaign(campaign);
                    MessageBox.Show("Enviado correctamente\nPuede llegar a demorar en llegar", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se logró realizar el envío, revise nuevamente los campos", "Error");
                }
                finally
                {
                    this.stateSend = false;
                }
            }
            else
            {
                MessageBox.Show("Aún faltan datos para poder enviar", "Error");
            }
        }
        /// <summary>
        /// metodo que ejecuta el thread
        /// </summary>
        private void Changed()
        {
            while (!this.stopped)
            {
                this.CheckTextChanged();
            }
        }
        /// <summary>
        /// realiza toda la logica del thread junto al delegado
        /// </summary>
        private void CheckTextChanged()
        {
            if (this.InvokeRequired)
            {
                ShowStatus d = new ShowStatus(this.CheckTextChanged);

                object[] arrayObjects = new object[] { };

                this.Invoke(d, arrayObjects);
            }
            else
            {
                if (rchTxtTo.Text == String.Empty || txtSubject.Text == String.Empty || rchTxtMsg.Text == String.Empty || dateTimeSch.Value == null || rchTxtTo.Text == "Aún sin destinatarios." || dateTimeSch.Value < DateTime.Today)
                {
                    lblStatusActive.Text = "Faltan Datos";

                }
                else
                {
                    if (this.stateSend)
                    {
                        lblStatusActive.Text = "Enviando";
                    }
                    else
                    {
                        lblStatusActive.Text = "Listo para enviar";
                    }
                }

            }
        }
        /// <summary>
        /// Cuando se agrega un contacto, se agrega el contacto en la lista de emails del atributo de la instancia del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != String.Empty)
            {
                Email email = new Email(txtEmail.Text, txtName.Text);

                this.emailList.Add(email);
                txtEmail.Text = String.Empty;
                txtName.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Debe indicar al menos un mail");
            }

            this.ShowAllEmails();
        }

        private void ShowAllEmails()
        {
            StringBuilder sb = new StringBuilder();

            if (this.emailList.Count > 0)
            {
                foreach (Email email in this.emailList)
                {
                    sb.AppendLine(email.ToString());
                }
            }
            else
            {
                sb.Append($"Aún sin destinatarios.");
            }

            rchTxtTo.Text = sb.ToString();
        }

        public void RemoveAllEmails()
        {
            if (this.emailList.Count > 0)
            {
                for (int i = 0; i <= this.emailList.Count; i++)
                {
                    this.emailList.RemoveAt(i);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.RemoveAllEmails();

            this.ShowAllEmails();
            dateTimeSch.Value = DateTime.Now;
            txtSubject.Text = String.Empty;
            rchTxtMsg.Text = String.Empty;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ScheduleForm newScheduleForm = new ScheduleForm(this.baseCampaign);
            newScheduleForm.ShowDialog();
        }
        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.stopped = true;
            if (MessageBox.Show("Seguro quieres salir?", "Cierre de aplicación", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                this.stopped = false;
                this.Activate();
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            AttachFileForm attachFileForm = new AttachFileForm();
            attachFileForm.ShowDialog();
        }
    }
}
