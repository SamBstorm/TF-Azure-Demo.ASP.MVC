using System.ComponentModel;

namespace ASP.Demo.Models.ViewModels
{
    public class MagasinListItem
    {
        [DisplayName("Identifiant")]
        public int ID { get; set; }
        public string Nom { get; set; }
        [DisplayName("Localité")]
        public string Ville { get; set; }
        public string Pays { get; set; }
    }
}
