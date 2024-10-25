using Newtonsoft.Json;

namespace GrupparbeteFoodapplication.Classes
{
    public class Recipemanager
    {
        private readonly string _filePath;

        public Recipemanager(string filePath)
        {
            _filePath = filePath;
        }

        public List<string> LoadRecipeType()
        {
            return LoadRecipes().Select(recipe => recipe.Type).Distinct().ToList();
        }

        public List<Recipe> LoadRecipes()
        {
            if (!File.Exists(_filePath))
            {
                Logger.LogError("Recipe file not found.");
                return new List<Recipe>();
            }

            try
            {
                var json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<Recipe>>(json) ?? new List<Recipe>();
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to load recipes: {ex.Message}");
                return new List<Recipe>();
            }
        }

        public void SaveRecipes(List<Recipe> recipes)
        {
            try
            {
                var json = JsonConvert.SerializeObject(recipes, Formatting.Indented);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to save recipes: {ex.Message}");
            }
        }
    }
}
