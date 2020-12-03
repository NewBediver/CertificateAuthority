using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CertificateRepository.Model
{
    public class AlgName
    {
        [Key]
        public int ID_AlgName_PK { get; set; }
        public string Name_AlgName { get; set; }

        public ICollection<AlgParSet> AlgParSets_AlgName { get; set; }
    }
}
