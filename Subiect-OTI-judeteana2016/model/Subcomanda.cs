using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2016
{
    public class Subcomanda
    {
        private int id;
        private int idComanda;
        private int idProdus;
        private int cantitate;

        public Subcomanda()
        {

        }

        public Subcomanda(int id,int idComanda,int idProdus,int cantitate)
        {
            this.id = id;
            this.idComanda = idComanda;
            this.idProdus = idProdus;
            this.cantitate = cantitate;
        }

        public Subcomanda(string prop)
        {
            string[] a = prop.Split(",");

            this.id= int.Parse(a[0]);
            this.idComanda= int.Parse(a[1]);
            this.idProdus= int.Parse(a[2]);
            this.cantitate= int.Parse(a[3]);

        }

        public string descriere()
        {
            string text = "";

            text+=this.id+",";
            text+=this.idComanda+",";
            text+=this.idProdus+",";
            text+=this.cantitate+"\n";

            return text;

        }

        public string save()
        {
            string text = "";

            text+=this.id+",";
            text+=this.idComanda+",";
            text+=this.idProdus+",";
            text+=this.cantitate;

            return text;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int IdComanda
        {
            get { return this.idComanda;}
            set { this.idComanda = value;}
        }

        public int IdProdus
        {
            get { return this.idProdus;}
            set { this.idProdus = value;}
        }

        public int Cantitate
        {
            get { return this.cantitate;}
            set { this.cantitate = value;}
        }




    }
}
