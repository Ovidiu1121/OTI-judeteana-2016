using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2016
{
    public class ControlClient
    {
        private List<Client> lista=new List<Client>();
        private string path = Application.StartupPath+@"\data\client.txt";

        public ControlClient()
        {
            load();
        }

        public void load()
        {

            StreamReader read=new StreamReader(path);

            string line = "";

            while ((line=read.ReadLine())!=null)
            {
                Client client = new Client(line);
                lista.Add(client);
            }
            read.Close();
        }

        public string afisare()
        {
            string text = "";

            for(int i = 0; i<lista.Count; i++)
            {
                text+=lista[i].descriere()+"\n";
            }
            return text;

        }

        public string toSave()
        {
            string text = "";
            int i = 0;

            for(i=0; i<lista.Count-1; i++)
            {
                text+=lista[i].save()+"\n";
            }
            text+=lista[i].save();

            return text;
        }

        public void salvareFisier()
        {

            StreamWriter write=new StreamWriter(path);

            write.WriteLine(toSave());

            write.Close();

        }

        public bool isClient(string email,string parola)
        {

            for(int i = 0; i<lista.Count; i++)
            {
                if (lista[i].Email.Equals(email)&&lista[i].Parola.Equals(parola))
                {
                    return true;
                }
            }
            return false;
        }

        public int getNextId()
        {
            return this.lista.Count+1;
        }

        public void adauga(Client a)
        {
            this.lista.Add(a);
        }






    }
}
