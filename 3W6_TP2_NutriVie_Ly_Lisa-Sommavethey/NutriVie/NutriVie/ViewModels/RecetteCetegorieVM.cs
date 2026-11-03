namespace NutriVie.ViewModels
{
    public class RecetteCetegorieVM
    {
        public int CategorieId { get; set; }
        public string NomCategorie { get; set; } = string.Empty;
        public List<RecetteInfoVM> Recettes { get; set;} = new List<RecetteInfoVM>();
    }
}
