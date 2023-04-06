using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2016
{
    public class ControlSubcomanda
    {
        private List<Subcomanda>lista=new List<Subcomanda>();
        private string path = Application.StartupPath+@"\data\subcomanda.txt";

        public ControlSubcomanda()
        {
            load();
        }

        public void load()
        {

            StreamReader read = new StreamReader(path);

            string line = "";

            while ((line=read.ReadLine())!=null)
            {
                Subcomanda subcomanda = new Subcomanda(line);
                lista.Add(subcomanda);
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
