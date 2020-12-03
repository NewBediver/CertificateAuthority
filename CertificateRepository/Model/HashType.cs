using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertificateRepository.Model
{
    public class HashType
    {
        [Key]
        public int ID_HashType_PK { get; set; }
        public string Name_HashType { get; set; }

        public int ID_Len_FK { get; set; }
        [ForeignKey("ID_Len_FK")]
        public Len Len_HashType { get; set; }

        public ICollection<AlgParSet> AlgParSets_HashType { get; set; }
    }
}
