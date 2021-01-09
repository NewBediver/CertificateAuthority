using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertificateRepository.Model
{
    public class Issuer
    {
        [Key]
        public int ID_Issuer_PK { get; set; }
        public string Name_Issuer { get; set; }
        public string Phone_Issuer { get; set; }
        public string EMail_Issuer { get; set; }
        public string OGRN_Issuer { get; set; }
        public string INN_Issuer { get; set; }
        public string KPP_Issuer { get; set; }
        public string CheckingAcc_Issuer { get; set; }
        public string BIK_Issuer { get; set; }
        public string OKTMO_Issuer { get; set; }
        public string KBK_Issuer { get; set; }

        public int? ID_City_FK { get; set; }
        [ForeignKey("ID_City_FK")]
        public City City_Issuer { get; set; }

        public ICollection<Cert> Certs_Issuer { get; set; }
        public ICollection<CancelledCert> CancelledCerts_Issuer { get; set; }
    }
}
