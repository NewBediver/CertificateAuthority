using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CertificateRepository.Model
{
    public class Ver
    {
        [Key]
        public int ID_Ver_PK { get; set; }
        public string Number_Ver { get; set; }

        public ICollection<Cert> Certs_Ver { get; set; }
    }
}
