using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CertificateRepository.Model
{
    public class Len
    {
        [Key]
        public int ID_Len_PK { get; set; }
        public int Value_Len { get; set; }

        public ICollection<AlgParSet> AlgParSets_Len { get; set; }
    }
}
