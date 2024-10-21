using GrupparbeteFoodapplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupparbeteFoodapplication
{
    public partial class FormSearch : Form
    {
        private readonly FormStart _formStart;

        private List<Recipe> recipes;

        public FormSearch(FormStart formStart)
        {
            InitializeComponent();
            _formStart = formStart;
            LoadRecipes();

        }

        private void LoadRecipes()
        {
            var recipeManager = new Recipemanager(@"C:\Users\Sam\Desktop\CloudAzure-Jensen\GrupparbeteFoodapplication\Databases\recipes.json");
            recipes = recipeManager.LoadRecipes();

            foreach (var recipe in recipes)
            {
                comboBoxType.Items.Add(recipe.Type);
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var recipeManager = new Recipemanager(@"C:\Users\Sam\Desktop\CloudAzure-Jensen\GrupparbeteFoodapplication\Databases\recipes.json");
            var recipes = recipeManager.LoadRecipes();

            listBoxResult.Items.Clear();

           
            if (!string.IsNullOrWhiteSpace(textBoxTitel.Text))
            {
                var searchTitle = textBoxTitel.Text.Trim();

                
                var filteredRecipesByName = recipes
                    .Where(r => r.Name.Contains(searchTitle, StringComparison.OrdinalIgnoreCase)) // Delsträngsmatchning
                    .ToList();

                if (filteredRecipesByName.Any())
                {
                    foreach (var recipe in filteredRecipesByName)
                    {
                        listBoxResult.Items.Add($"{recipe.Name} - {recipe.Type}");
                    }
                }
                else
                {
                    MessageBox.Show("Inga recept hittades som innehåller de angivna bokstäverna.");
                }
            }
            
            else if (comboBoxType.SelectedItem != null)
            {
                var selectedType = comboBoxType.SelectedItem.ToString();
                var filteredRecipesByType = recipes
                    .Where(r => r.Type.Equals(selectedType, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                foreach (var recipe in filteredRecipesByType)
                {
                    listBoxResult.Items.Add($"{recipe.Name} - {recipe.Type}");
                }
            }
            else
            {
                MessageBox.Show("Vänligen ange ett receptnamn eller välj en recepttyp.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Vill du avsluta sökfunktionen?", "Information", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }

        }


        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem != null)
            {
                var selectedRecipeName = comboBoxType.SelectedItem.ToString();
                var recipe = GetRecipeDetails(selectedRecipeName);

                if (recipe != null)
                {
                    listBoxRecipeDetails.Text = recipe.Description; 
                }
            }
        }

        private Recipe GetRecipeDetails(string name)
        {
            return recipes.FirstOrDefault(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        private List<string> WrapText(string text, int maxLineLength)
        {
            var words = text.Split(' ');
            var wrappedLines = new List<string>();
            var currentLine = new StringBuilder();

            foreach (var word in words)
            {
                
                if (currentLine.Length + word.Length + 1 > maxLineLength)
                {
                    wrappedLines.Add(currentLine.ToString());
                    currentLine.Clear();
                }

                
                if (currentLine.Length > 0)
                {
                    currentLine.Append(" ");
                }
                currentLine.Append(word);
            }

            
            if (currentLine.Length > 0)
            {
                wrappedLines.Add(currentLine.ToString());
            }

            return wrappedLines;
        }

        private void buttonShowRecipe_Click(object sender, EventArgs e)
        {
            var selectedRecipeInfo = listBoxResult.SelectedItem.ToString();
            var selectedRecipeName = selectedRecipeInfo.Split('-')[0].Trim();

            var recipeManager = new Recipemanager(@"C:\Users\Sam\Desktop\CloudAzure-Jensen\GrupparbeteFoodapplication\Databases\recipes.json");
            var recipes = recipeManager.LoadRecipes();

            var selectedRecipe = recipes.FirstOrDefault(r => r.Name.Equals(selectedRecipeName, StringComparison.OrdinalIgnoreCase));

            listBoxRecipeDetails.Items.Clear();

            if (selectedRecipe != null)
            {
                listBoxRecipeDetails.Items.Add($"Name: {selectedRecipe.Name}");
                listBoxRecipeDetails.Items.Add($"Type: {selectedRecipe.Type}");
                var wrappedDescription = WrapText(selectedRecipe.Description, 40); 
                foreach (var line in wrappedDescription)
                {
                    listBoxRecipeDetails.Items.Add(line);
                }
            }

            else
            {
                MessageBox.Show("Vänligen välj ett recept från listan");
            }
        }
    }
}
