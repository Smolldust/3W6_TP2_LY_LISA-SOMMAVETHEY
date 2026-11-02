using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriVie.Data;
using NutriVie.Models;
using NutriVie.ViewModels;

namespace NutriVie.Controllers
{
    public class StatController : Controller
    {
        private readonly NutriVieDbContext _context;
        public StatController(NutriVieDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            StatVM vm = new StatVM();
            // Le nombre de recettes avec 3 aliments.
            vm.NbRecettesTroisAliments = _context.Recettes
                .Count(r => r.AlimentRecettes.Count == 3);

            // L’aliment le plus calorique.
            vm.AlimentPlusCalorique = _context.Aliments
                .OrderByDescending(a => a.CaloriesPour100g).First().Nom;

            // Une liste des quatre recettes dont la durée totale est la plus courte(préparation et cuisson).
            // Vous devez afficher le nom de la recette et le temps total.
            vm.RecettesCourtes = _context.Recettes
                .OrderBy(r => r.TempsPreparation + r.TempsCuisson).Take(4).ToList();

            // Le nombre de calories de la recette française la moins calorique en utilisant Min et Sum
            var recettesFrancaise = _context.Recettes
                .Include(r => r.AlimentRecettes)
                .ThenInclude(ar => ar.Aliment)
                .Where(r => r.Categorie.Nom == "Française")
                .ToList();

            vm.NbCalorieFaibleRecetteFrancais = recettesFrancaise
                .Min(r => r.AlimentRecettes.Sum(ar => ar.Poids * ar.Aliment.CaloriesPour100g / 100));
            return View(vm);
        }
    }
}
