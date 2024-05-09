namespace GestionPFE.Models
{
    public class Societe
    {
        public int ID { get; set; }
        public string Lib { get; set; }
        public string Adresse { get; set; }
        public int  Tel{ get; set; }
        public ICollection<PFE> PFEs { get; set; }
    }
}
