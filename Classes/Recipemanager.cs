using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace GrupparbeteFoodapplication.Classes
{
    public class Recipemanager
    {
        private const string filePath = "recipes.json";

        public class Recipe
        {

        }

        public List<Recipe> LoadRecipes()
        {
            if (!File.Exists(filePath))
                return new List<Recipe>();

            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Recipe>>(json) ?? new List<Recipe>();
        }

        public void SaveRecipes(List<Recipe> recipes)
        {
            var json = JsonConvert.SerializeObject(recipes, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
