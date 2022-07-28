using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.Demo.Models.ViewModels
{
    public class MagasinCreateForm
    {
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Rue { get; set; }
        [DisplayName("Numéro")]
        public string Numero { get; set; }
        [Required]
        public string Ville { get; set; }
        [Required]
        [DisplayName("Code postal")]
        public string CodePostal { get; set; }
        [Required]
        public string Pays { get; set; }
    }
}
