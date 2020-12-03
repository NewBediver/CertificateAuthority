using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CertificateRepository.Model
{
    public class Country
    {
        [Key]
        public int ID_Country_PK { get; set; }
        public string Name_Country { get; set; }

        public ICollection<Region> Regions_Country { get; set; }
    }
}
