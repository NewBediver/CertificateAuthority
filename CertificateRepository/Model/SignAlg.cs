using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertificateRepository.Model
{
    public class SignAlg
    {
        [Key]
        public int ID_SignAlg_PK { get; set; }
        public byte[] PublicKey_SignAlg { get; set; }
        public byte[] PrivateKey_SignAlg { get; set; }

        public int ID_SignType_FK { get; set; }
        [ForeignKey("ID_SignType_FK")]
        public SignType SignType_SignAlg { get; set; }

        public ICollection<Cert> Certs_SignAlg { get; set; }
    }
}
