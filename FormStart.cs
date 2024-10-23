using System.Windows.Forms;
using Newtonsoft.Json;

namespace GrupparbeteFoodapplication
{
    public partial class FormStart : Form
    {
        private Recipemanager recipemanager;
        private List<Recipe> recipes;
        public FormStart()
        {
            InitializeComponent();
            recipemanager = new Recipemanager();
            LoadRecipes();
            PopulateTypeComboBox();
        }
        public class Recipe
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
        public class Recipemanager
        {
            private const string filePath = "recipes.json";

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
        private void PopulateTypeComboBox()
        {
            comboBoxType.Items.AddRange(new string[] { "Meat", "Fish", "Salad", "Soup", "Dessert" });
        }
        private void LoadRecipes()
        {
            recipes = recipemanager.LoadRecipes();
            comboBoxRecipeView.Items.Clear();
            foreach (var recipe in recipes)
            {
                comboBoxRecipeView.Items.Add(recipe.Name);
            }
        }

        private void ClearFormFields()
        {
            comboBoxType.SelectedIndex = -1;
            textBoxName.Clear();
            richTextBoxDescription.Clear();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var newRecipe = new Recipe
            {
                Type = comboBoxType.SelectedItem?.ToString(),
                Name = textBoxName.Text,
                Description = richTextBoxDescription.Text,

            };

            recipes.Add(newRecipe);
            recipemanager.SaveRecipes(recipes);
            LoadRecipes();
            ClearFormFields();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxRecipeView.SelectedItem != null)
            {
                var selectedTitle = comboBoxRecipeView.SelectedItem.ToString();
                var recipe = recipes.FirstOrDefault(r => r.Name == selectedTitle);

                if (recipe != null)
                {
                    recipe.Name = textBoxName.Text;
                    recipe.Description = richTextBoxDescription.Text;
                    recipe.Type = comboBoxType.SelectedItem?.ToString();
                    recipemanager.SaveRecipes(recipes);
                    LoadRecipes();
                    ClearFormFields();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxRecipeView.SelectedItem != null)
            {
                var selectedTitle = comboBoxRecipeView.SelectedItem.ToString();
                var recipeToRemove = recipes.FirstOrDefault(r => r.Name == selectedTitle);

                if (recipeToRemove != null)
                {
                    recipes.Remove(recipeToRemove);
                    recipemanager.SaveRecipes(recipes);
                    LoadRecipes();
                    ClearFormFields();
                }
            }
        }




        private void buttonSearchRecipe_Click(object sender, EventArgs e)
        {
            FormSearch form = new FormSearch(this);
            form.ShowDialog();
        }

        public void ReturnValues(string text)
        {
            //Här körs koden som anropas från andra formuläret.
            MessageBox.Show(text);
        }



        private void comboBoxRecipeView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxRecipeView.SelectedItem != null)
            {
                var selectedTitle = comboBoxRecipeView.SelectedItem.ToString();
                var recipe = recipes.FirstOrDefault(r => r.Name == selectedTitle);

                if (recipe != null)
                {
                    textBoxName.Text = recipe.Name;
                    richTextBoxDescription.Text = recipe.Description;
                    comboBoxType.SelectedItem = recipe.Type;
                }
            }
        }

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
