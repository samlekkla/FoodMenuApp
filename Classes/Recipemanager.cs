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

        private readonly string _filePath;

        public Recipemanager(string filePath)
        {
            _filePath = filePath;
        }
               

        public List<Recipe> LoadRecipes()
        {
            if (!File.Exists(_filePath))
                throw new FileNotFoundException("Recipe file not found.");

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Recipe>>(json);
        }

        public void SaveRecipes(List<Recipe> recipes)
        {
            var json = JsonConvert.SerializeObject(recipes, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
