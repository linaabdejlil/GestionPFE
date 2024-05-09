namespace GestionPFE.Models
{
    public class Enseignant
    {
        public int EncadreurID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public ICollection<PFE> PFEs { get; set; }
    }


}
