using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertificateRepository.Model
{
    public class Region
    {
        [Key]
        public int ID_Region_PK { get; set; }
        public string Name_Region { get; set; }

        public int ID_Country_FK { get; set; }
        [ForeignKey("ID_Country_FK")]
        public Country Country_Region {get; set;}

        public ICollection<City> Cities_Region { get; set; }
    }
}
