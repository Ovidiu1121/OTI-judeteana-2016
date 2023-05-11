using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2016
{
    public class ControlMeniu
    {
        private List<Meniu>lista=new List<Meniu>();
        private string path = Application.StartupPath+@"\data\meniuu.txt";

        public ControlMeniu()
        {
            load();
        }

        public void load()
        {

            StreamReader read = new StreamReader(path);

            string line = "";

            while ((line=read.ReadLine())!=null)
            {
                Meniu meniu = new Meniu(line);
                lista.Add(meniu);
            }
            read.Close();
        }

        public string afisare()
        {
            string text = "";

            for (int i = 0; i<lista.Count; i++)
            {
                text+=lista[i].description()+"\n";
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

        public List<Meniu> getMeniu()
        {
            return this.lista;
        }

        public Meniu getMeniuById(int id)
        {

            for(int i = 0; i<lista.Count; i++)
            {
                if (this.lista[i].IdProdus.Equals(id))
                {
                    return lista[i];
                }
            }
            return null;
        }






    }
}
