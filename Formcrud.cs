using GrupparbeteFoodapplication.Classes;

namespace GrupparbeteFoodapplication
{
    public partial class Formcrud : Form
    {
        private readonly Recipemanager recipemanager;
        private List<Recipe> recipes;

        public Formcrud()
        {
            InitializeComponent();
            recipemanager = new Recipemanager(@"C:\Users\harit\Source\Repos\GrupparbeteFoodapplicationlocalcopy\Databases\recipes.json");
            LoadRecipes();
            PopulateTypeComboBox();
            PopulateRecipeComboBox();
        }

        private void Log(string message)
        {
            string logFilePath = @"C:\Users\harit\Source\Repos\GrupparbeteFoodapplicationlocalcopy\log.txt";
            Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }

        private void ClearFormFields()
        {
            textBoxName.Clear();
            TextBoxDescription.Clear();
            comboBoxType.SelectedIndex = -1;
        }

        private void PopulateRecipeComboBox()
        {
            try
            {
                var sortedRecipes = recipes
                .OrderBy(r => r.Name) // Sortera efter namn
                .Select(r => r.Name)  // Välj endast namnen
                .ToList();

                comboBoxRecipeView.Items.Clear(); // Rensa befintliga objekt
                comboBoxRecipeView.Items.AddRange(sortedRecipes.ToArray()); // Lägg till sorterade recept
            }

            catch (Exception ex)
            {
                Log($"Ett fel inträffade: {ex.Message}");
                MessageBox.Show("Ett fel inträffade. Kontrollera loggen för mer information.");
            }

        }


        private void PopulateTypeComboBox()
        {
            try
            {
                foreach (var type in recipemanager.LoadRecipeType())
                {
                    comboBoxType.Items.Add(type);
                }
            }
            catch (Exception ex)
            {
                Log($"Ett fel inträffade: {ex.Message}");
                MessageBox.Show("Ett fel inträffade. Kontrollera loggen för mer information.");
            }
        }

        private void LoadRecipes()
        {
            try
            {
                recipes = recipemanager.LoadRecipes();
                comboBoxRecipeView.Items.Clear();
                recipes.ForEach(recipe => comboBoxRecipeView.Items.Add(recipe.Name));
            }
            catch (Exception ex)
            {
                Log($"Failed to load recipes: {ex.Message}");
                MessageBox.Show("Failed to load recipes. Please check the log for more details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxName.Text) || comboBoxType.SelectedItem == null)
                {
                    MessageBox.Show("Vänligen fyll i alla obligatoriska fält innan du sparar receptet.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Är du säker på att du vill spara detta recept?", "Bekräfta sparande", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    recipes.Add(new Recipe
                    {
                        Type = comboBoxType.SelectedItem.ToString(),
                        Name = textBoxName.Text,
                        Description = TextBoxDescription.Text
                    });
                    recipemanager.SaveRecipes(recipes);
                    LoadRecipes();
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                Log($"Failed to save recipe: {ex.Message}");
                MessageBox.Show("Ett fel inträffade vid sparandet av receptet. Se loggen för mer information.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedTitle = comboBoxRecipeView.SelectedItem?.ToString();
                var recipe = recipes.FirstOrDefault(r => r.Name == selectedTitle);

                if (recipe != null && MessageBox.Show($"Är du säker på att du vill uppdatera receptet för:\n{selectedTitle}", "Bekräfta uppdatering", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    recipe.Name = textBoxName.Text;
                    recipe.Description = TextBoxDescription.Text;
                    recipe.Type = comboBoxType.SelectedItem.ToString();
                    recipemanager.SaveRecipes(recipes);
                    LoadRecipes();
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                Log($"Failed to update recipe: {ex.Message}");
                MessageBox.Show("Ett fel inträffade vid uppdateringen av receptet. Se loggen för mer information.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedTitle = comboBoxRecipeView.SelectedItem?.ToString();
                var recipeToRemove = recipes.FirstOrDefault(r => r.Name == selectedTitle);

                if (recipeToRemove != null && MessageBox.Show($"Är du säker på att du vill ta bort receptet för:\n{selectedTitle}", "Bekräfta borttagning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    recipes.Remove(recipeToRemove);
                    recipemanager.SaveRecipes(recipes);
                    LoadRecipes();
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                Log($"Failed to delete recipe: {ex.Message}");
                MessageBox.Show("Ett fel inträffade vid borttagningen av receptet. Se loggen för mer information.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxRecipeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTitle = comboBoxRecipeView.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedTitle))
            {
                // Töm textbågarna om inget val har gjorts
                textBoxName.Clear();
                TextBoxDescription.Clear();
                comboBoxType.SelectedItem = null; // Återställ vald typ
                return;
            }

            // Hämta receptet som matchar det valda namnet
            var recipe = recipes.FirstOrDefault(r => r.Name.Equals(selectedTitle, StringComparison.OrdinalIgnoreCase));

            // Om receptet hittas, fyll i textbågarna
            if (recipe != null)
            {
                textBoxName.Text = recipe.Name;
                TextBoxDescription.Text = recipe.Description;
                comboBoxType.SelectedItem = recipe.Type;
            }
            else
            {

                textBoxName.Clear();
                TextBoxDescription.Clear();
                comboBoxType.SelectedItem = null;
            }

        }



        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void buttonTestError_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("Detta är ett simulerat fel för att testa felhanteringen.");
            }

            catch (Exception ex) 
            {
                Log($"Testfel inträffade: {ex.Message}");
                MessageBox.Show("Ett testfel inträffade. Kontrollera loggen för mer information.", "Test Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
