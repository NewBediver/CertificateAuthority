using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertificateRepository.Model
{
    public class CancelledCert
    {
        [Key]
        public int ID_CancelledCert_PK { get; set; }
        public string SerialNumber_CancelledCert { get; set; }
        public DateTime ValidFrom_CancelledCert { get; set; }
        public DateTime ValidBy_CancelledCert { get; set; }
        public string SignSerialNumber_CancelledCert { get; set; }
        public string SignValue_CancelledCert { get; set; }

        public int ID_Ver_FK { get; set; }
        [ForeignKey("ID_Ver_FK")]
        public Ver Ver_CancelledCert { get; set; }

        public int ID_SignAlg_FK { get; set; }
        [ForeignKey("ID_SignAlg_FK")]
        public SignAlg SignAlg_CancelledCert { get; set; }

        public int ID_Issuer_FK { get; set; }
        [ForeignKey("ID_Issuer_FK")]
        public Issuer Issuer_CancelledCert { get; set; }

        public int ID_Subj_FK { get; set; }
        [ForeignKey("ID_Subj_FK")]
        public Subj Subj_CancelledCert { get; set; }

        public CancelledCert() { }

        public CancelledCert(Cert certificate)
        {
            SerialNumber_CancelledCert = certificate.SerialNumber_Cert;
            ValidFrom_CancelledCert = certificate.ValidFrom_Cert;
            ValidBy_CancelledCert = certificate.ValidBy_Cert;
            SignSerialNumber_CancelledCert = certificate.SignSerialNumber_Cert;
            SignValue_CancelledCert = certificate.SignValue_Cert;

            ID_Ver_FK = certificate.ID_Ver_FK;
            Ver_CancelledCert = certificate.Ver_Cert;
            ID_SignAlg_FK = certificate.ID_SignAlg_FK;
            SignAlg_CancelledCert = certificate.SignAlg_Cert;
            ID_Issuer_FK = certificate.ID_Issuer_FK;
            Issuer_CancelledCert = certificate.Issuer_Cert;
            ID_Subj_FK = certificate.ID_Subj_FK;
            Subj_CancelledCert = certificate.Subj_Cert;
        }
    }
}
