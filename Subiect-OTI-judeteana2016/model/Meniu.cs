using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2016
{
    public class Meniu
    {
        private int idProdus;
        private string denumireProdus;
        private string descriere;
        public int pret;
        private int kcal;
        private int felul;

        public Meniu()
        {

        }

        public Meniu(int idProdus,string denumireProdus, string descriere,int pret,int kcal,int felul)
        {
            this.idProdus = idProdus;
            this.denumireProdus = denumireProdus;
            this.descriere = descriere;
            this.pret = pret;
            this.kcal = kcal;
            this.felul = felul;
        }

        public Meniu(string prop)
        {
            string[] a = prop.Split(";");

           this.idProdus=int.Parse (a[0]);
            this.denumireProdus=a[1];
            this.descriere = a[2];
            this.pret=int.Parse(a[3]);
            this.kcal=int.Parse(a[4]);
            this.felul=int.Parse(a[5]);

        }

        public string description()
        {
            string text = "";

            text+=this.idProdus+",";
            text+=this.denumireProdus+",";
            text+=this.descriere+",";
            text+=this.pret+",";
            text+=this.kcal+",";
            text+=this.felul+"\n";

            return text;

        }

        public string save()
        {
            string text = "";

            text+=this.idProdus+";";
            text+=this.denumireProdus+";";
            text+=this.descriere+";";
            text+=this.pret+";";
            text+=this.kcal+";";
            text+=this.felul;

            return text;
        }

        public int IdProdus
        {
            get { return this.idProdus; }
            set { this.idProdus = value;}
        }

        public string DenumireProdus
        {
            get { return this.denumireProdus; }
            set { this.denumireProdus = value;}
        }

        public string Descriere
        {
            get { return this.descriere; }
            set { this.descriere = value;}
        }

        public int Pret
        {
            get { return this.pret; }
            set { this.pret = value;}
        }

        public int Kcal
        {
            get { return this.kcal; }
            set { this.kcal = value;}
        }

        public int Felul
        {
            get { return this.felul; }
            set { this.felul = value;}
        }










    }
}
