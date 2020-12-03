using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertificateRepository.Model
{
    public class City
    {
        [Key]
        public int ID_City_PK { get; set; }
        public string Name_City { get; set; }

        public int ID_Region_FK { get; set; }
        [ForeignKey("ID_Region_FK")]
        public Region Region_City { get; set; }

        public ICollection<Issuer> Issuers_City { get; set; }
        public ICollection<Subj> Subjs_City { get; set; }
    }
}
