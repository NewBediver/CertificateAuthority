using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CertificateRepository.Model
{
    public class Gender
    {
        [Key]
        public int ID_Gender_PK { get; set; }
        public string Name_Gender { get; set; }

        public ICollection<Subj> Subjs_Gender { get; set; }
    }
}
