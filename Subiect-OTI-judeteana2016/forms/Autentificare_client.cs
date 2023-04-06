using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect_OTI_judeteana2016
{
    public partial class Autentificare_client : Form
    {

        private Label lbladresaemail;
        private Label lblparola;
        private TextBox txtadresaemail;
        private TextBox txtparola;
        private Button btnintra;
        private ControlClient controlClient=new ControlClient();

        public Autentificare_client()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(605, 305);

            this.lblparola = new Label();
            this.Controls.Add(this.lblparola);
            this.lblparola.Location = new System.Drawing.Point(78, 71);
            this.lblparola.Size = new System.Drawing.Size(50, 20);
            this.lblparola.Text="Parola";

            this.lbladresaemail = new Label();
            this.Controls.Add(this.lbladresaemail);
            this.lbladresaemail.Location = new System.Drawing.Point(78, 116);
            this.lbladresaemail.Size = new System.Drawing.Size(96, 20);
            this.lbladresaemail.Text="Adresa email";

            this.txtparola = new TextBox();
            this.Controls.Add(this.txtparola);
            this.txtparola.Location = new System.Drawing.Point(202, 71);
            this.txtparola.Size=new System.Drawing.Size(268, 27);
            this.txtparola.PasswordChar = '*';

            this.txtadresaemail = new TextBox();
            this.Controls.Add(this.txtadresaemail);
            this.txtadresaemail.Location = new System.Drawing.Point(202, 113);
            this.txtadresaemail.Size=new System.Drawing.Size(268, 27);

            this.btnintra=new Button();
            this.Controls.Add(this.btnintra);
            this.btnintra.Location = new System.Drawing.Point(421, 202);
            this.btnintra.Size=new System.Drawing.Size(142, 33);
            this.btnintra.Text="Intra";
            this.btnintra.Click+=new EventHandler(intra_Click);

        }

        public void intra_Click(object sender, EventArgs e)
        {

            if (this.txtadresaemail.Text.Equals("")||this.txtparola.Text.Equals(""))
            {
                MessageBox.Show("Vă rugăm să completați toate câmpurile pentru a vă autentifica.");
            }else if (this.controlClient.isClient(this.txtadresaemail.Text, this.txtparola.Text)==false)
            {
                MessageBox.Show("Îmi pare rău, autentificarea a eșuat");
                this.txtparola.Text="";
                this.txtadresaemail.Text="";
            }
            else
            {
                this.Hide();
                Optiuni a=new Optiuni();
                a.Closed+=(s, args) => this.Close();
                a.Show();
            }

        }

        private void Autentificare_client_Load(object sender, EventArgs e)
        {

        }
    }
}
