using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertificateRepository.Model
{
    public class AlgParSet
    {
        [Key]
        public int ID_AlgParSet_PK { get; set; }
        public string OID_AlgParSet { get; set; }

        public int ID_HashType_FK { get; set; }
        [ForeignKey("ID_HashType_FK")]
        public HashType HashType_AlgParSet { get; set; }

        public int ID_AlgName_FK { get; set; }
        [ForeignKey("ID_AlgName_FK")]
        public AlgName AlgName_AlgParSet { get; set; }

        public int ID_Len_FK { get; set; }
        [ForeignKey("ID_Len_FK")]
        public Len Len_AlgParSet { get; set; }

        public ICollection<SignAlg> SignAlgs_AlgParSet { get; set; }
    }
}
