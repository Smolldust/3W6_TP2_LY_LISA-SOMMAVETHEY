using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NutriVie.Models
{
    public class Service
    {
        [Key]
        public int ServiceId {  get; set; }

        [Required(ErrorMessage = "Le nome est obligatoire.")]
        [StringLength(50)]
        [DisplayName("Nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "La description est obligatoire.")]
        [StringLength(150)]
        [DisplayName("Description")]
        public string Description { get; set; }

    }
}
