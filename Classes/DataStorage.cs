using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupparbeteFoodapplication.Classes
{
    public class DataStorage
    {
        private const string FILE_PATH = @"C:\Users\Sam\Desktop\CloudAzure-Jensen\GrupparbeteFoodapplication\Databases\recipes.json";

        public void SaveUpdatedRecipe(Recipe recipe)
        {
            //Uppdatera recept
            List<Recipe> recipes = LoadRecipes();
            int index = recipes.FindIndex(r => r.Name == recipe.Name);
            if (index != -1)
            {
                recipes[index] = recipe;
            }
            else
            {
                //lägger till nytt recept i slutet av filen
                recipes.Add(recipe);
            }

            string jsonString = JsonSerializer.Serialize(recipes, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(FILE_PATH, jsonString);
        }
        public List <Recipe> LoadRecipes()
        {
            if (File.Exists(FILE_PATH))
            {
                string jsonString = File.ReadAllText(FILE_PATH);
                return JsonSerializer.Deserialize<List<Recipe>>(jsonString) ?? new List<Recipe>();
            }

            return new List<Recipe>();
        }

        public void DeleteRecipe(string name)
        {
            List<Recipe> recipes = LoadRecipes();
            recipes.RemoveAll(r => r.Name == name);
            string jsonString = JsonSerializer.Serialize(recipes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FILE_PATH, jsonString);
        }

        public List<Recipe> SearchRecipes(string searchTerm, string type)
        {
            List<Recipe> recipes = LoadRecipes();
            return recipes.Where(r => (string.IsNullOrEmpty(searchTerm) || 
                   r.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) 
                   && (string.IsNullOrEmpty(type) || 
                   r.Type.Equals(type, StringComparison.OrdinalIgnoreCase)))
                   .ToList();
        }
    }

}