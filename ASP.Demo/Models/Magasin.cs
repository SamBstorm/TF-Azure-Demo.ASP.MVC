using System.ComponentModel.DataAnnotations;

namespace ASP.Demo.Models
{
    public class Magasin
    {
        public int MagasinId { get; set; }
        public string Nom { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Pays { get; set; }
    }
}
