using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2016
{
    public class Comanda
    {
        private int id;
        private int idClient;
        private DateTime data;

        public Comanda()
        {

        }

        public Comanda(int id,int idClient,DateTime date)
        {
            this.id = id;
            this.idClient = idClient;
            this.data = date;
        }

        public Comanda(string prop)
        {
            string[] a = prop.Split(",");

            this.id= int.Parse(a[0]);
            this.idClient = int.Parse(a[1]);
            this.data=DateTime.Parse(a[2]);

        }

        public string descriere()
        {
            string text = "";

            text+=this.id+",";
            text+=this.idClient+",";
            text+=this.data+"\n";

            return text;

        }

        public string save()
        {
            string text = "";

            text+=this.id+",";
            text+=this.idClient+",";
            text+=this.data;

            return text;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int IdClient
        {
            get { return this.idClient; }
            set { this.idClient = value; }
        }

        public DateTime Date
        {
            get { return this.data; }
            set { this.data = value; }
        }


    }
}
