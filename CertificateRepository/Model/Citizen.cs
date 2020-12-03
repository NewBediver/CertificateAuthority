using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CertificateRepository.Model
{
    public class Citizen
    {
        [Key]
        public int ID_Citizen_PK { get; set; }
        public string Name_Citizen { get; set; }

        public ICollection<Subj> Subjs_Citizen { get; set; }
    }
}
