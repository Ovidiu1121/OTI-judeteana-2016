using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2016
{
    public class ControlComanda
    {

        private List<Comanda> lista=new List<Comanda>();
        private string path = Application.StartupPath+@"\data\comanda.txt";

        public ControlComanda()
        {
            load();
        }

        public void load()
        {

            StreamReader read=new StreamReader(path);

            string line = "";

            while ((line=read.ReadLine())!=null)
            {
                Comanda comanda = new Comanda(line);
                lista.Add(comanda);
            }
            read.Close();
        }

        public string afisare()
        {
            string text = "";

            for (int i = 0; i<lista.Count; i++)
            {
                text+=lista[i].descriere()+"\n";
            }
            return text;

        }

        public string toSave()
        {
            string text = "";
            int i = 0;

            for (i=0; i<lista.Count-1; i++)
            {
                text+=lista[i].save();
            }
            text+=lista[i].save();

            return text;
        }

        public void salvareFisier()
        {

            StreamWriter write = new StreamWriter(path);

            write.WriteLine(toSave());

            write.Close();

        }





    }
}
