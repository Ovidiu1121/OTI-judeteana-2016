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
    public partial class Optiuni : Form
    {
        private TabControl tabcontrol;
        private Label lblvarsta;
        private Label lblinaltime;
        private Label lblgreutate;
        private TextBox txtvarsta;
        private TextBox txtinaltime;
        private TextBox txtgreutate;
        private Label lblnecesarzilnic;
        private TextBox txtnecesarzilnic;
        private Button btncalculeaza;
        private DataGridView datagridview1;
        private ControlMeniu controlMeniu=new ControlMeniu();
        private Label lblnecesarzilnic2;
        private Label lbltoalkcal;
        private Label lblprettotal;
        private TextBox txtnecesarzilnic2;
        private TextBox txttoalkcal;
        private TextBox txtprettotal;
        private Button btncomanda;


        public Optiuni()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(1068, 580);

            this.tabcontrol=new TabControl();
            this.Controls.Add(this.tabcontrol);
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Size = new System.Drawing.Size(983, 534);

            TabPage tab1 = new TabPage("CalculatorKcal");
            TabPage tab2 = new TabPage("Comanda");
            TabPage tab3 = new TabPage("Generare Meniu");
            TabPage tab4 = new TabPage("Grafic Kcal");
            this.tabcontrol.Controls.AddRange(new System.Windows.Forms.Control[] { tab1, tab2,tab3,tab4 });

            this.lblvarsta=new Label();
            tab1.Controls.Add(this.lblvarsta);
            this.lblvarsta.Location = new System.Drawing.Point(108, 69);
            this.lblvarsta.Size = new System.Drawing.Size(83, 20);
            this.lblvarsta.Text="Varsta (ani)";

            this.lblinaltime=new Label();
            tab1.Controls.Add(this.lblinaltime);
            this.lblinaltime.Location = new System.Drawing.Point(108, 158);
            this.lblinaltime.Size = new System.Drawing.Size(97, 20);
            this.lblinaltime.Text="Inaltime (cm)";

            this.lblgreutate=new Label();
            tab1.Controls.Add(this.lblgreutate);
            this.lblgreutate.Location = new System.Drawing.Point(108, 258);
            this.lblgreutate.Size = new System.Drawing.Size(96, 20);
            this.lblgreutate.Text="Greutate (kg)";

            this.lblnecesarzilnic=new Label();
            tab1.Controls.Add(this.lblnecesarzilnic);
            this.lblnecesarzilnic.Location = new System.Drawing.Point(533, 155);
            this.lblnecesarzilnic.Size = new System.Drawing.Size(105, 20);
            this.lblnecesarzilnic.Text="Necesar zilnic:";

            this.txtvarsta=new TextBox();
            tab1.Controls.Add(this.txtvarsta);
            this.txtvarsta.Location = new System.Drawing.Point(257, 63);
            this.txtvarsta.Size = new System.Drawing.Size(152, 27);

            this.txtinaltime=new TextBox();
            tab1.Controls.Add(this.txtinaltime);
            this.txtinaltime.Location = new System.Drawing.Point(257, 155);
            this.txtinaltime.Size = new System.Drawing.Size(152, 27);

            this.txtgreutate=new TextBox();
            tab1.Controls.Add(this.txtgreutate);
            this.txtgreutate.Location = new System.Drawing.Point(257, 248);
            this.txtgreutate.Size = new System.Drawing.Size(152, 27);

            this.txtnecesarzilnic=new TextBox();
            tab1.Controls.Add(this.txtnecesarzilnic);
            this.txtnecesarzilnic.Location = new System.Drawing.Point(639, 151);
            this.txtnecesarzilnic.Size = new System.Drawing.Size(152, 27);
            this.txtnecesarzilnic.Enabled=false;

            this.btncalculeaza=new Button();
            tab1.Controls.Add(this.btncalculeaza);
            this.btncalculeaza.Location = new System.Drawing.Point(160, 330);
            this.btncalculeaza.Size = new System.Drawing.Size(184, 55);
            this.btncalculeaza.Text="Calculeaza";
            this.btncalculeaza.Click+=new EventHandler(calculeaza_Click);

            this.datagridview1=new DataGridView();
            tab2.Controls.Add(this.datagridview1);
            this.datagridview1.Location = new System.Drawing.Point(6, 0);
            this.datagridview1.Size=new Size(1031, 367);
            populate();

            this.lblnecesarzilnic2=new Label();
            tab2.Controls.Add(this.lblnecesarzilnic2);
            this.lblnecesarzilnic2.Location=new Point(71, 375);
            this.lblnecesarzilnic2.Size=new System.Drawing.Size(100, 20);
            this.lblnecesarzilnic2.Text="Necesar zilnic";

            this.lbltoalkcal=new Label();
            tab2.Controls.Add(this.lbltoalkcal);
            this.lbltoalkcal.Location=new Point(71, 417);
            this.lbltoalkcal.Size=new System.Drawing.Size(72, 20);
            this.lbltoalkcal.Text="Total kcal";

            this.lblprettotal=new Label();
            tab2.Controls.Add(this.lblprettotal);
            this.lblprettotal.Location=new Point(71, 459);
            this.lblprettotal.Size=new System.Drawing.Size(100, 20);
            this.lblprettotal.Text="Pret total";

            this.txtnecesarzilnic2=new TextBox();
            tab2.Controls.Add(this.txtnecesarzilnic2);
            this.txtnecesarzilnic2.Location = new System.Drawing.Point(186, 372);
            this.txtnecesarzilnic2.Size = new System.Drawing.Size(124, 27);
            this.txtnecesarzilnic2.Enabled=false;

            this.txttoalkcal=new TextBox();
            tab2.Controls.Add(this.txttoalkcal);
            this.txttoalkcal.Location = new System.Drawing.Point(186, 414);
            this.txttoalkcal.Size = new System.Drawing.Size(124, 27);
            this.txttoalkcal.Enabled=false;

            this.txtprettotal=new TextBox();
            tab2.Controls.Add(this.txtprettotal);
            this.txtprettotal.Location = new System.Drawing.Point(186, 456);
            this.txtprettotal.Size = new System.Drawing.Size(124, 27);
            this.txtprettotal.Enabled=false;

            this.btncomanda=new Button();
            tab2.Controls.Add(this.btncomanda);
            this.btncomanda.Location = new System.Drawing.Point(448, 405);
            this.btncomanda.Size = new System.Drawing.Size(159, 44);
            this.btncomanda.Text="Comanda";





        }

        public void calculeaza_Click(object sender,EventArgs e)
        {

            if (this.txtvarsta.Text.Equals("")||this.txtgreutate.Text.Equals("")||this.txtinaltime.Text.Equals(""))
            {
                MessageBox.Show("Vă rugăm să completați toate câmpurile.");
            }else
            {
                int s = int.Parse(this.txtgreutate.Text)+int.Parse(this.txtinaltime.Text)+int.Parse(this.txtvarsta.Text);

                if (s<250)
                {
                    this.txtnecesarzilnic.Text="1800";
                }
                else if (s>=250&&s<=275)
                {
                    this.txtnecesarzilnic.Text="2200";
                }
                else
                {
                    this.txtnecesarzilnic.Text="2500";
                }

            }

        }

        public void populate()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id produs", typeof(int));
            dt.Columns.Add("Denumire produs", typeof(string));
            dt.Columns.Add("Descriere", typeof(string));
            dt.Columns.Add("Pret", typeof(int));
            dt.Columns.Add("Kcal", typeof(int));
            dt.Columns.Add("Felul", typeof(int));
            dt.Columns.Add("Cantintate", typeof(int));
            dt.Columns.Add("Adauga", typeof(string));

            List<Meniu> lista = this.controlMeniu.getMeniu();

            foreach(Meniu m in lista)
            {
                dt.Rows.Add(m.IdProdus,m.DenumireProdus,m.Descriere,m.Pret,m.Kcal,m.Felul,1,"");
            }

            datagridview1.DataSource = dt;

        }




        private void Optiuni_Load(object sender, EventArgs e)
        {

        }
    }
}
