using GrupparbeteFoodapplication.Classes;
using System.Text;

namespace GrupparbeteFoodapplication
{
    public partial class FormSearch : Form
    {
        private readonly Recipemanager recipemanager;
        private List<Recipe> recipes;

        public FormSearch()
        {
            InitializeComponent();
            recipemanager = new Recipemanager(@"C:\Users\harit\Source\Repos\GrupparbeteFoodapplicationlocalcopy\Databases\recipes.json");
            PopulateTypeComboBox();

            LoadRecipes();
            PopulateRecipeListComboBox();
        }



        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxResult.Items.Clear();

                if (!string.IsNullOrWhiteSpace(textBoxTitel.Text))
                {
                    var searchTitle = textBoxTitel.Text.Trim();
                    var filteredRecipes = recipes
                        .Where(r => r.Name.Contains(searchTitle, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    DisplayRecipes(filteredRecipes);
                }
                else if (comboBoxType.SelectedItem != null)
                {
                    var selectedType = comboBoxType.SelectedItem.ToString();
                    var filteredRecipes = recipes
                        .Where(r => r.Type.Equals(selectedType, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    DisplayRecipes(filteredRecipes);
                }
                else
                {
                    MessageBox.Show("Vänligen ange ett receptnamn eller välj en recepttyp.", "Ingen sökning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"Error in buttonSearch_Click: {ex.Message}");
                MessageBox.Show("Ett fel inträffade vid sökningen. Kontrollera loggen för mer information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRecipes()
        {
            try
            {
                recipes = recipemanager.LoadRecipes();
                comboBoxType.Items.Clear();
                comboBoxType.Items.AddRange(recipes.Select(r => r.Type).Distinct().ToArray());
            }
            catch (Exception ex)
            {
                Logger.Log($"Failed to load recipes in FormSearch: {ex.Message}");
                MessageBox.Show("Failed to load recipes. Please check the log for more details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateTypeComboBox()
        {
            try
            {
                var recipeTypes = recipemanager.LoadRecipeType();
                comboBoxType.Items.AddRange(recipeTypes.ToArray());
            }
            catch (Exception ex)
            {
                Logger.Log($"Error in PopulateTypeComboBox: {ex.Message}");
                MessageBox.Show("Ett fel inträffade vid inläsning av typer. Kontrollera loggen för mer information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateRecipeListComboBox()
        {
            var sortedRecipes = recipes.OrderBy(r => r.Name).Select(r => r.Name).ToList();
            comboBoxAllRecipes.Items.Clear();
            comboBoxAllRecipes.Items.AddRange(sortedRecipes.ToArray());
        }



        private void buttonShowRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxResult.SelectedItem == null)
                {
                    MessageBox.Show("Vänligen välj ett recept från listan innan du visar detaljer.", "Ingen markering", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRecipeName = listBoxResult.SelectedItem.ToString().Split('-')[0].Trim();
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
                    MessageBox.Show("Receptet kunde inte hittas.");
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"Error in buttonShowRecipe_Click: {ex.Message}");
                MessageBox.Show("Ett fel inträffade vid visning av receptdetaljer. Kontrollera loggen för mer information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (currentLine.Length > 0) currentLine.Append(" ");
                currentLine.Append(word);
            }

            if (currentLine.Length > 0) wrappedLines.Add(currentLine.ToString());
            return wrappedLines;
        }

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                new FormLogin(this).ShowDialog();
            }
            catch (Exception ex)
            {
                Logger.Log($"Error in buttonLoginAdmin_Click: {ex.Message}");
                MessageBox.Show("Ett fel inträffade vid öppning av admininloggning. Kontrollera loggen för mer information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayRecipes(List<Recipe> filteredRecipes)
        {
            try
            {
                if (filteredRecipes.Any())
                {
                    foreach (var recipe in filteredRecipes)
                    {
                        listBoxResult.Items.Add($"{recipe.Name} - {recipe.Type}");
                    }
                }
                else
                {
                    MessageBox.Show("Inga recept hittades som matchar din sökning.");
                }
            }

            catch (Exception ex)
            {
                Logger.Log($"Error in buttonLoginAdmin_Click: {ex.Message}");
                MessageBox.Show("Ett fel inträffade vid visningen av receptet. Kontrollera loggen för mer information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonNewSearch_Click(object sender, EventArgs e)
        {
            textBoxTitel.Clear();
            comboBoxType.SelectedIndex = -1;
            listBoxResult.Items.Clear();
            listBoxRecipeDetails.Items.Clear();

        }

        private void buttonViewRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAllRecipes.SelectedItem == null)
                {
                    MessageBox.Show("Vänligen välj ett recept från listan.", "Ingen markering", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRecipeName = comboBoxAllRecipes.SelectedItem.ToString();
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
            }

            catch (Exception ex)
            {
                Logger.Log($"Error in buttonLoginAdmin_Click: {ex.Message}");
                MessageBox.Show("Ett fel inträffade vid visningen av receptet. Kontrollera loggen för mer information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


    }
}
