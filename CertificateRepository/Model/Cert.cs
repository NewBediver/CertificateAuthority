using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertificateRepository.Model
{
    public class Cert
    {
        [Key]
        public int ID_Cert_PK { get; set; }
        public string SerialNumber_Cert { get; set; }
        public DateTime ValidFrom_Cert { get; set; }
        public DateTime ValidBy_Cert { get; set; }
        public string SignSerialNumber_Cert { get; set; }
        public string SignValue_Cert { get; set; }

        public int ID_Ver_FK { get; set; }
        [ForeignKey("ID_Ver_FK")]
        public Ver Ver_Cert { get; set; }

        public int ID_SignAlg_FK { get; set; }
        [ForeignKey("ID_SignAlg_FK")]
        public SignAlg SignAlg_Cert { get; set; }

        public int ID_Issuer_FK { get; set; }
        [ForeignKey("ID_Issuer_FK")]
        public Issuer Issuer_Cert { get; set; }

        public int ID_Subj_FK { get; set; }
        [ForeignKey("ID_Subj_FK")]
        public Subj Subj_Cert { get; set; }
    }
}
