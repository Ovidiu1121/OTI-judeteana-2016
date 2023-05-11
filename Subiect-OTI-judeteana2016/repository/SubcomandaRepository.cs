using Microsoft.Extensions.Configuration;
using Subiect_OTI_judeteana2016.data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_judeteana2016.repository
{
    public class SubcomandaRepository
    {
        private string connectionString;
        private DataAcces dataAcces;

        public SubcomandaRepository()
        {
            this.dataAcces = new DataAcces();

            this.connectionString =GetConnection();

        }

        public List<Subcomanda> getAllSubcomenzi()
        {
            string sql = "select * from subcomenzi";

            return this.dataAcces.LoadData<Subcomanda, dynamic>(sql, new { }, connectionString);

        }

        public string GetConnection()
        {
            string c = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();
            string connectionStringIs = configuration.GetConnectionString("Default");
            return connectionStringIs;
        }


    }
}
