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
    public class MeniuRepository
    {

        private string connectionString;
        private DataAcces dataAcces;

        public MeniuRepository()
        {
            this.dataAcces = new DataAcces();

            this.connectionString =GetConnection();

        }

        public List<Meniu> getAllMeniuri()
        {

            string sql = "select * from meniuri";

            return this.dataAcces.LoadData<Meniu, dynamic>(sql, new {},connectionString);

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
