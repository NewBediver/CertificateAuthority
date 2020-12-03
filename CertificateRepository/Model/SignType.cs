using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertificateRepository.Model
{
    public class SignType
    {
        [Key]
        public int ID_SignType_PK { get; set; }

        public int ID_AlgParSet_FK { get; set; }
        [ForeignKey("ID_AlgParSet_FK")]
        public AlgParSet AlgParSet_SignType { get; set; }

        public ICollection<SignAlg> SignAlgs_SignType { get; set; }
    }
}
