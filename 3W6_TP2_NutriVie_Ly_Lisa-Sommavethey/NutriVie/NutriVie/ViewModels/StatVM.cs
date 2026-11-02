using NutriVie.Models;
namespace NutriVie.ViewModels
{
    public class StatVM
    {
        public int NbRecettesTroisAliments { get; set; }
        public string AlimentPlusCalorique { get; set; } = string.Empty;
        public List<Recette> RecettesCourtes { get; set; } = new List<Recette>();
        public double NbCalorieFaibleRecetteFrancais { get; set; }
    }
}
