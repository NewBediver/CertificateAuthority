using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertificateRepository.Model
{
    public class Subj
    {
        [Key]
        public int ID_Subj_PK { get; set; }
        public string Surname_Subj { get; set; }
        public string Name_Subj { get; set; }
        public DateTime BirthDate_Subj { get; set; }
        public string Phone_Subj { get; set; }
        public string EMail_Subj { get; set; }
        public string PassportSerias_Subj { get; set; }
        public string PassportNumber_Subj { get; set; }
        public string INN_Subj { get; set; }
        public string SNILS_Subj { get; set; }

        public int ID_Gender_FK { get; set; }
        [ForeignKey("ID_Gender_FK")]
        public Gender Gender_Subj { get; set; }

        public int ID_Citizen_FK { get; set; }
        [ForeignKey("ID_Citizen_FK")]
        public Citizen Citizen_Subj { get; set; }

        public int ID_City_FK { get; set; }
        [ForeignKey("ID_City_FK")]
        public City City_Subj { get; set; }

        public ICollection<Cert> Certs_Subj { get; set; }
    }
}
