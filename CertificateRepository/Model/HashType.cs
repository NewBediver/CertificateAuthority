using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CertificateRepository.Model
{
    public class HashType
    {
        [Key]
        public int ID_HashType_PK { get; set; }
        public string Name_HashType { get; set; }

        public ICollection<AlgParSet> AlgParSets_HashType { get; set; }
    }
}
