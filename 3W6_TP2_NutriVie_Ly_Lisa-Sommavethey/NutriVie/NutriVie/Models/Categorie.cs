using System.ComponentModel.DataAnnotations;

namespace NutriVie.Models
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }

        //public int RecetteId { get; set; }
        public List<Recette>? Recette { get; set; } = new List<Recette>();
    }
}
