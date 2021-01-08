using Microsoft.EntityFrameworkCore;

namespace CertificateRepository.Model
{
    public class AppContext
        : DbContext
    {
        public DbSet<AlgName> AlgNames { get; set; }
        public DbSet<AlgParSet> AlgParSets { get; set; }
        public DbSet<CancelledCert> CancelledCerts { get; set; }
        public DbSet<Cert> Certs { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<HashType> HashTypes { get; set; }
        public DbSet<Issuer> Issuers { get; set; }
        public DbSet<Len> Lens { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<SignAlg> SignAlgs { get; set; }
        public DbSet<Subj> Subjs { get; set; }
        public DbSet<Ver> Vers { get; set; }

        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
