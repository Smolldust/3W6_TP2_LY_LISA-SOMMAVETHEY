using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace NutriVie.Models
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public List<Recette>? Recette { get; set; } = new List<Recette>();

        [ValidateNever]
        public List<Aliment> Aliments { get; set; }
    }
}
