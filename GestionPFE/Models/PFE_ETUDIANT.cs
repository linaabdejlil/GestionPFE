using System.ComponentModel.DataAnnotations;

namespace GestionPFE.Models
{
    public class PFE_ETUDIANT
    {
        public int ID { get; set; }
        [Display(Name = "PFE")]
        public int PFEID { get; set; }
        [Display(Name = "Etudiant")]
        public int EtudiantID { get; set;}
        public virtual PFE?PFE { get; set; }
        public virtual Etudiant? Etudiant { get; set; }
       

    }
}
