namespace GestionPFE.Models
{
    public class PFE
    {
        public int PFEID { get; set; }
        public string titre { get; set;}
        public int TitreID { get;set;}
        public string desc { get; set; }
        public DateTime DateD { get; set; }
        public DateTime DateF { get; set; }
   

        public ICollection<Enseignant> enseignants { get; set; }   
        public ICollection<Societe> societes { get; set;}




    }
}
