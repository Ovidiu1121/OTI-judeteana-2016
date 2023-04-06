using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2016
{
    public class Client
    {
        private int id;
        private string parola;
        private string nume;
        private string prenume;
        private string adresa;
        private string email;
        private int kcal_zilnice;

        public Client()
        {

        }

        public Client(int id,string parola, string nume, string prenume, string adresa, string email, int kcal_zilnice)
        {
            this.id = id;
            this.parola = parola;
            this.nume = nume;
            this.prenume = prenume;
            this.adresa = adresa;
            this.email = email;
            this.kcal_zilnice = kcal_zilnice;
        }

        public Client(string prop)
        {
            string[] a = prop.Split(",");

            this.id=int.Parse(a[0]);
            this.parola = a[1];
            this.nume = a[2];
            this.prenume = a[3];
            this.adresa = a[4];
            this.email = a[5];
            this.kcal_zilnice=int.Parse(a[6]);

        }

        public string descriere()
        {
            string text = "";

            text+=this.id+",";
            text+=this.parola+",";
            text+=this.nume+",";
            text+=this.prenume+",";
            text+=this.adresa+",";
            text+=this.email+",";
            text+=this.kcal_zilnice+"\n";

            return text;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Parola
        {
            get { return this.parola; }
            set { this.parola = value;}
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value;}
        }

        public string Prenume
        {
            get { return this.prenume;}
            set { this.prenume = value;}
        }

        public string Adresa
        {
            get { return this.adresa; }
            set { this.adresa = value;}
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value;}
        }

        public int Kcal_zilnice
        {
            get { return this.kcal_zilnice;}
            set { this.kcal_zilnice = value;}
        }

        public string save()
        {
            string text = "";

            text+=this.id+",";
            text+=this.parola+",";
            text+=this.nume+",";
            text+=this.prenume+",";
            text+=this.adresa+",";
            text+=this.email+",";
            text+=this.kcal_zilnice;

            return text;


        }


    }
}
