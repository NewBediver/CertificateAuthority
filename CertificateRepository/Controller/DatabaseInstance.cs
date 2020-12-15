using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CertificateRepository.Controller
{
    public class DatabaseInstance
    {
        public static Model.ApplicationContext GetInstance()
        {
            if (m_Db == null)
            {
                var builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appsettings.json");
                var config = builder.Build();
                string connectionString = config.GetConnectionString("DefaultConnection");

                var optionsBuilder = new DbContextOptionsBuilder<Model.ApplicationContext>();
                var options = optionsBuilder
                    .UseSqlServer(connectionString)
                    .Options;

                m_Db = new Model.ApplicationContext(options);
            }

            return m_Db;
        }

        private static Model.ApplicationContext m_Db;
    }
}
