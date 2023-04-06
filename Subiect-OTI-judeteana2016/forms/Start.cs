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
    public partial class Start : Form
    {
        private Label lbltitlu;
        private Button btninregistrare;
        private Button btnautentificare;
        private PictureBox pic;

        public Start()
        {
            InitializeComponent();

            this.lbltitlu=new Label();
            this.Controls.Add(this.lbltitlu);
            this.lbltitlu.Location=new Point(127, 29);
            this.lbltitlu.Size=new Size(550, 28);
            this.lbltitlu.Text="Meniuri diverse caracterizate de transparenta si excelenta!";
            this.lbltitlu.Font=new Font("Arial", 12, FontStyle.Regular);

            this.pic=new PictureBox();
            this.Controls.Add(this.pic);
            this.pic.Location=new Point(150, 78);
            this.pic.Size=new Size(482, 244);
            this.pic.Image=Image.FromFile(Application.StartupPath+@"\data\good-food-1.jpg");
            this.pic.SizeMode=PictureBoxSizeMode.StretchImage;

            this.btninregistrare=new Button();
            this.Controls.Add(this.btninregistrare);
            this.btninregistrare.Location=new Point(204, 353);
            this.btninregistrare.Size=new Size(170, 64);
            this.btninregistrare.Text="Inregistrare";
            this.btninregistrare.Click+=new EventHandler(inregistrare_Click);

            this.btnautentificare=new Button();
            this.Controls.Add(this.btnautentificare);
            this.btnautentificare.Location=new Point(414, 353);
            this.btnautentificare.Size=new Size(170, 64);
            this.btnautentificare.Text="Autentificare";
            this.btnautentificare.Click+=new EventHandler(autentificare_Click);
         

        }

        public void inregistrare_Click(object sender,EventArgs e)
        {

            this.Hide();
            Creare_cont_client a = new Creare_cont_client();
            a.Closed+=(s, args) => this.Close();
            a.Show();
        }

        public void autentificare_Click(object sender, EventArgs e)
        {

            this.Hide();
            Autentificare_client a = new Autentificare_client();
            a.Closed+=(s, args) => this.Close();
            a.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
