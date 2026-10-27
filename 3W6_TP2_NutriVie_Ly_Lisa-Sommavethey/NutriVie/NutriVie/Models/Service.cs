using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NutriVie.Models
{
    public class Service
    {
        [Key]
        public int ServiceId {  get; set; }

        [DisplayName("Nom")]
        public string Nom { get; set; }
        public string Description { get; set; }

    }
}
