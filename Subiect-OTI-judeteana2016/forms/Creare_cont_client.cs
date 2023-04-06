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
    public partial class Creare_cont_client : Form
    {

        private PictureBox pic;
        private Label lblnume;
        private Label lblprenume;
        private Label lbladresa;
        private Label lblparola;
        private Label lblparola2;
        private Label lbladresaemail;
        private TextBox txtnume;
        private Button btncreare;
        private TextBox txtprenume;
        private TextBox txtadresa;
        private TextBox txtparola;
        private TextBox txtparola2;
        private TextBox txtadresaemail;
        private ControlClient controlClient=new ControlClient();

        public Creare_cont_client()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(818, 584);

            this.pic=new PictureBox();
            this.Controls.Add(this.pic);
            this.pic.Location=new Point(193, 12);
            this.pic.Size=new Size(361, 137);
            this.pic.Image=Image.FromFile(Application.StartupPath+@"\data\good-food-1.jpg");
            this.pic.SizeMode=PictureBoxSizeMode.StretchImage;

            this.lblnume=new Label();
            this.Controls.Add(this.lblnume);
            this.lblnume.Location=new Point(170, 189);
            this.lblnume.Size=new Size(49, 20);
            this.lblnume.Text="Nume";

            this.lblprenume=new Label();
            this.Controls.Add(this.lblprenume);
            this.lblprenume.Location=new Point(170, 236);
            this.lblprenume.Size=new Size(70, 20);
            this.lblprenume.Text="Prenume";

            this.lbladresa=new Label();
            this.Controls.Add(this.lbladresa);
            this.lbladresa.Location=new Point(170, 287);
            this.lbladresa.Size=new Size(70, 20);
            this.lbladresa.Text="Adresa";

            this.lblparola=new Label();
            this.Controls.Add(this.lblparola);
            this.lblparola.Location=new Point(170, 334);
            this.lblparola.Size=new Size(70, 20);
            this.lblparola.Text="Parola";

            this.lblparola2=new Label();
            this.Controls.Add(this.lblparola2);
            this.lblparola2.Location=new Point(170, 387);
            this.lblparola2.Size=new Size(145, 20);
            this.lblparola2.Text="Reintroduce parola";

            this.lbladresaemail=new Label();
            this.Controls.Add(this.lbladresaemail);
            this.lbladresaemail.Location=new Point(170, 437);
            this.lbladresaemail.Size=new Size(100, 20);
            this.lbladresaemail.Text="Adresa email";

            this.txtnume=new TextBox();
            this.Controls.Add(this.txtnume);
            this.txtnume.Location=new Point(331, 189);
            this.txtnume.Size=new Size(268, 27);

            this.txtprenume=new TextBox();
            this.Controls.Add(this.txtprenume);
            this.txtprenume.Location=new Point(331, 236);
            this.txtprenume.Size=new Size(268, 27);

            this.txtadresa=new TextBox();
            this.Controls.Add(this.txtadresa);
            this.txtadresa.Location=new Point(331, 280);
            this.txtadresa.Size=new Size(268, 27);

            this.txtparola=new TextBox();
            this.Controls.Add(this.txtparola);
            this.txtparola.Location=new Point(331, 334);
            this.txtparola.Size=new Size(268, 27);
            this.txtparola.PasswordChar = '*';

            this.txtparola2=new TextBox();
            this.Controls.Add(this.txtparola2);
            this.txtparola2.Location=new Point(331, 387);
            this.txtparola2.Size=new Size(268, 27);
            this.txtparola2.PasswordChar = '*';

            this.txtadresaemail=new TextBox();
            this.Controls.Add(this.txtadresaemail);
            this.txtadresaemail.Location=new Point(331, 437);
            this.txtadresaemail.Size=new Size(268, 27);

            this.btncreare=new Button();
            this.Controls.Add(this.btncreare);
            this.btncreare.Location=new Point(331, 484);
            this.btncreare.Size=new Size(169, 41);
            this.btncreare.Text="Creare cont";
            this.btncreare.Click+=new EventHandler(crearecont_Click);

        }

        public void crearecont_Click(object sender,EventArgs e)
        {

            if (this.txtadresa.Text.Equals("")||this.txtadresaemail.Text.Equals("")||this.txtnume.Text.Equals("")||this.txtparola.Text.Equals("")||this.txtparola2.Text.Equals("")||this.txtprenume.Text.Equals(""))
            {
                MessageBox.Show("Completati toate campurile");
            }
            else if (this.txtparola.Text.Equals(this.txtparola2.Text)==false)
            {
                MessageBox.Show("Parola nu este la fel");
            }
            else
            {
                Client a=new Client(this.controlClient.getNextId(),this.txtparola.Text,this.txtnume.Text,this.txtprenume.Text,this.txtadresa.Text,this.txtadresaemail.Text,0);

                this.controlClient.adauga(a);
                this.controlClient.salvareFisier();

                this.Hide();
                Start start = new Start();
                start.Closed+=(s,args)=>this.Close();
                start.Show();

            }

        }
        
        private void Creare_cont_client_Load(object sender, EventArgs e)
        {

        }
    }
}
