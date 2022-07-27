namespace ASP.Demo.Models
{
    public class Entreprise
    {
        public string Nom { get; set; }
        public Magasin[] magasins { get; set; }
        public string ContactMail { get; set; }
        public string ContactPhone { get; set; }
    }
}
