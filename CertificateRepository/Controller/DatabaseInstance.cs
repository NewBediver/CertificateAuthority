using CertificateRepository.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CertificateRepository.Controller
{
    public class DatabaseInstance
    {
        public static AppContext GetInstance()
        {
            if (m_Db == null)
            {
                var builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appsettings.json");
                var config = builder.Build();
                string connectionString = config.GetConnectionString("DefaultConnection");

                var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
                var options = optionsBuilder
                    .UseSqlServer(connectionString)
                    .Options;

                m_Db = new AppContext(options);
            }

            return m_Db;
        }

        private static AppContext m_Db;
    }
}
