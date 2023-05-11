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
        private Label lblnecesarzilnic2Val;
        private Label lbltoalkcalVal;
        private Label lblprettotalVal;
        private Button btncomanda;
        private DataGridViewButtonColumn btnadauga;
        private Label lblnecesarzilnickcal;
        private Label lblbuget;
        private Label lblmeniurioptime;
        private TextBox txtnecesarzilnickcal;
        private TextBox txtbuget;
        private Button btngenereaza;
        private DataGridView datagridview2;
        public ControlMeniu controlmeniu;
        public int sumaprettotal = 0;
        public int sumatotalkcal = 0;
        public Optiuni()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(1068, 580);

            this.tabcontrol=new TabControl();
            this.Controls.Add(this.tabcontrol);
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Size = new System.Drawing.Size(1040, 534);

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
            this.datagridview1.Size=new Size(1030, 367);
            this.datagridview1.Name="data grid view 1";
            populate();

            DataGridViewColumn col = this.datagridview1.Columns["Id produs"];
            col.Width = 80; 

            this.btnadauga=new DataGridViewButtonColumn();
            this.datagridview1.Columns.Add(this.btnadauga);
            this.btnadauga.Text="Adauga";
            this.btnadauga.Name="Adauga";
            this.btnadauga.HeaderText="Adauga";
            this.btnadauga.UseColumnTextForButtonValue=true;

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

            this.lblnecesarzilnic2Val=new Label();
            tab2.Controls.Add(this.lblnecesarzilnic2Val);
            this.lblnecesarzilnic2Val.Location = new System.Drawing.Point(186, 372);
            this.lblnecesarzilnic2Val.Size = new System.Drawing.Size(124, 27);

            this.lbltoalkcalVal=new Label();
            tab2.Controls.Add(this.lbltoalkcalVal);
            this.lbltoalkcalVal.Location = new System.Drawing.Point(186, 414);
            this.lbltoalkcalVal.Size = new System.Drawing.Size(124, 27);
            this.lbltoalkcalVal.Text="0";

            this.lblprettotalVal=new Label();
            tab2.Controls.Add(this.lblprettotalVal);
            this.lblprettotalVal.Location = new System.Drawing.Point(186, 456);
            this.lblprettotalVal.Size = new System.Drawing.Size(124, 27);
            this.lblprettotalVal.Text="0";

            this.btncomanda=new Button();
            tab2.Controls.Add(this.btncomanda);
            this.btncomanda.Location = new System.Drawing.Point(448, 405);
            this.btncomanda.Size = new System.Drawing.Size(159, 44);
            this.btncomanda.Text="Comanda";

            this.lblnecesarzilnickcal=new Label();
            tab3.Controls.Add(this.lblnecesarzilnickcal);
            this.lblnecesarzilnickcal.Location = new System.Drawing.Point(20, 15);
            this.lblnecesarzilnickcal.Size=new Size(163, 20);
            this.lblnecesarzilnickcal.Text="Necesar zilnic de kcal";

            this.lblbuget=new Label();
            tab3.Controls.Add(this.lblbuget);
            this.lblbuget.Location=new Point(20, 49);
            this.lblbuget.Size=new Size(48, 20);
            this.lblbuget.Text="Buget";

            this.lblmeniurioptime=new Label();
            tab3.Controls.Add(this.lblmeniurioptime);
            this.lblmeniurioptime.Location=new Point(41, 103);
            this.lblmeniurioptime.Size=new Size(310, 31);
            this.lblmeniurioptime.Text="Meniuri optime pentru dvs:";
            this.lblmeniurioptime.Font=new Font("Arial", 14, FontStyle.Regular);

            this.txtnecesarzilnickcal=new TextBox();
            tab3.Controls.Add(this.txtnecesarzilnickcal);
            this.txtnecesarzilnickcal.Location=new Point(193, 12);
            this.txtnecesarzilnickcal.Size=new Size(125, 27);
            this.txtnecesarzilnickcal.Enabled=false;

            this.txtbuget=new TextBox();
            tab3.Controls.Add(this.txtbuget);
            this.txtbuget.Location=new Point(193, 49);
            this.txtbuget.Size=new Size(125, 27);

            this.btngenereaza=new Button();
            tab3.Controls.Add(this.btngenereaza);
            this.btngenereaza.Location = new System.Drawing.Point(405, 21);
            this.btngenereaza.Size = new System.Drawing.Size(146, 48);
            this.btngenereaza.Text="Genereaza";

            this.datagridview2=new DataGridView();
            tab3.Controls.Add(this.datagridview2);
            this.datagridview2.Location=new System.Drawing.Point(0, 137);
            this.datagridview2.Size=new Size(1048, 364);

            this.datagridview1.CellClick +=new DataGridViewCellEventHandler(dataGridView1_CellClick);
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
                    this.lblnecesarzilnic2Val.Text=this.txtnecesarzilnic.Text;
                    this.txtnecesarzilnickcal.Text=this.txtnecesarzilnic.Text;
                }
                else if (s>=250&&s<=275)
                {
                    this.txtnecesarzilnic.Text="2200";
                    this.lblnecesarzilnic2Val.Text=this.txtnecesarzilnic.Text;
                    this.txtnecesarzilnickcal.Text=this.txtnecesarzilnic.Text;
                }
                else
                {
                    this.txtnecesarzilnic.Text="2500";
                    this.lblnecesarzilnic2Val.Text=this.txtnecesarzilnic.Text;
                    this.txtnecesarzilnickcal.Text=this.txtnecesarzilnic.Text;
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


            List<Meniu> lista = this.controlMeniu.getMeniu();

            foreach(Meniu m in lista)
            {
                dt.Rows.Add(m.IdProdus,m.DenumireProdus,m.Descriere,m.Pret,m.Kcal,m.Felul,1);
            }

            datagridview1.DataSource = dt;

        }

        public void genereaza_Click(object sender,EventArgs e)
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("Felul 1", typeof(string));
            dt.Columns.Add("Felul 2", typeof(string));
            dt.Columns.Add("Felul 3", typeof(string));
            dt.Columns.Add("Total kcal", typeof(int));
            dt.Columns.Add("Pret total", typeof(int));

            List<Meniu>lista=new List<Meniu>();



        }

        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != this.datagridview1.Columns["Adauga"].Index) return;

            int index = int.Parse(this.datagridview1.Rows[e.RowIndex].Cells[1].Value.ToString());

            controlmeniu=new ControlMeniu();
            MessageBox.Show(index.ToString());
            Meniu a=controlmeniu.getMeniuById(index);

            sumaprettotal+=a.Pret;
            sumatotalkcal+=a.Kcal;

            this.lblprettotalVal.Text=sumaprettotal.ToString();
            this.lbltoalkcalVal.Text=sumatotalkcal.ToString();

        }

        private void Optiuni_Load(object sender, EventArgs e)
        {

        }
    }
}
