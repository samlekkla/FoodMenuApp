namespace GrupparbeteFoodapplication
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelSearchRecipe = new Label();
            labelRecipeType = new Label();
            comboBoxType = new ComboBox();
            buttonSearch = new Button();
            labelResult = new Label();
            listBoxResult = new ListBox();
            labelRecipeDetails = new Label();
            listBoxRecipeDetails = new ListBox();
            labelTitel = new Label();
            textBoxTitel = new TextBox();
            buttonShowRecipe = new Button();
            buttonLoginAdmin = new Button();
            buttonNewSearch = new Button();
            labelAllRecipes = new Label();
            comboBoxAllRecipes = new ComboBox();
            buttonViewRecipe = new Button();
            SuspendLayout();
            // 
            // labelSearchRecipe
            // 
            labelSearchRecipe.AutoSize = true;
            labelSearchRecipe.ForeColor = Color.Navy;
            labelSearchRecipe.Location = new Point(425, 23);
            labelSearchRecipe.Margin = new Padding(4, 0, 4, 0);
            labelSearchRecipe.Name = "labelSearchRecipe";
            labelSearchRecipe.Size = new Size(120, 25);
            labelSearchRecipe.TabIndex = 0;
            labelSearchRecipe.Text = "Search Recipe";
            // 
            // labelRecipeType
            // 
            labelRecipeType.AutoSize = true;
            labelRecipeType.ForeColor = Color.Navy;
            labelRecipeType.Location = new Point(26, 138);
            labelRecipeType.Margin = new Padding(4, 0, 4, 0);
            labelRecipeType.Name = "labelRecipeType";
            labelRecipeType.Size = new Size(109, 25);
            labelRecipeType.TabIndex = 1;
            labelRecipeType.Text = "Recipe Type:";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(143, 135);
            comboBoxType.Margin = new Padding(4, 4, 4, 4);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(188, 33);
            comboBoxType.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.ForeColor = Color.Navy;
            buttonSearch.Location = new Point(348, 138);
            buttonSearch.Margin = new Padding(4, 4, 4, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(104, 33);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.ForeColor = Color.Navy;
            labelResult.Location = new Point(26, 297);
            labelResult.Margin = new Padding(4, 0, 4, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(59, 25);
            labelResult.TabIndex = 4;
            labelResult.Text = "Result";
            // 
            // listBoxResult
            // 
            listBoxResult.ForeColor = Color.Navy;
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 25;
            listBoxResult.Location = new Point(26, 324);
            listBoxResult.Margin = new Padding(4, 4, 4, 4);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(395, 279);
            listBoxResult.TabIndex = 5;
            // 
            // labelRecipeDetails
            // 
            labelRecipeDetails.AutoSize = true;
            labelRecipeDetails.ForeColor = Color.Navy;
            labelRecipeDetails.Location = new Point(545, 297);
            labelRecipeDetails.Margin = new Padding(4, 0, 4, 0);
            labelRecipeDetails.Name = "labelRecipeDetails";
            labelRecipeDetails.Size = new Size(121, 25);
            labelRecipeDetails.TabIndex = 6;
            labelRecipeDetails.Text = "Recipe Details";
            // 
            // listBoxRecipeDetails
            // 
            listBoxRecipeDetails.ForeColor = Color.Navy;
            listBoxRecipeDetails.FormattingEnabled = true;
            listBoxRecipeDetails.ItemHeight = 25;
            listBoxRecipeDetails.Location = new Point(545, 324);
            listBoxRecipeDetails.Margin = new Padding(4, 4, 4, 4);
            listBoxRecipeDetails.Name = "listBoxRecipeDetails";
            listBoxRecipeDetails.Size = new Size(444, 279);
            listBoxRecipeDetails.TabIndex = 7;
            // 
            // labelTitel
            // 
            labelTitel.AutoSize = true;
            labelTitel.ForeColor = Color.Navy;
            labelTitel.Location = new Point(26, 68);
            labelTitel.Margin = new Padding(4, 0, 4, 0);
            labelTitel.Name = "labelTitel";
            labelTitel.Size = new Size(53, 25);
            labelTitel.TabIndex = 10;
            labelTitel.Text = "Titel: ";
            // 
            // textBoxTitel
            // 
            textBoxTitel.Location = new Point(87, 68);
            textBoxTitel.Margin = new Padding(4, 4, 4, 4);
            textBoxTitel.Name = "textBoxTitel";
            textBoxTitel.Size = new Size(244, 31);
            textBoxTitel.TabIndex = 11;
            // 
            // buttonShowRecipe
            // 
            buttonShowRecipe.ForeColor = Color.Navy;
            buttonShowRecipe.Location = new Point(295, 286);
            buttonShowRecipe.Margin = new Padding(4, 4, 4, 4);
            buttonShowRecipe.Name = "buttonShowRecipe";
            buttonShowRecipe.Size = new Size(126, 36);
            buttonShowRecipe.TabIndex = 12;
            buttonShowRecipe.Text = "Show Recipe";
            buttonShowRecipe.UseVisualStyleBackColor = true;
            buttonShowRecipe.Click += buttonShowRecipe_Click;
            // 
            // buttonLoginAdmin
            // 
            buttonLoginAdmin.ForeColor = Color.Navy;
            buttonLoginAdmin.Location = new Point(866, 13);
            buttonLoginAdmin.Margin = new Padding(4, 4, 4, 4);
            buttonLoginAdmin.Name = "buttonLoginAdmin";
            buttonLoginAdmin.Size = new Size(130, 48);
            buttonLoginAdmin.TabIndex = 18;
            buttonLoginAdmin.Text = "Admin Login";
            buttonLoginAdmin.UseVisualStyleBackColor = true;
            buttonLoginAdmin.Click += buttonLoginAdmin_Click;
            // 
            // buttonNewSearch
            // 
            buttonNewSearch.ForeColor = Color.Navy;
            buttonNewSearch.Location = new Point(868, 286);
            buttonNewSearch.Margin = new Padding(4, 4, 4, 4);
            buttonNewSearch.Name = "buttonNewSearch";
            buttonNewSearch.Size = new Size(121, 36);
            buttonNewSearch.TabIndex = 19;
            buttonNewSearch.Text = "New Search";
            buttonNewSearch.UseVisualStyleBackColor = true;
            buttonNewSearch.Click += buttonNewSearch_Click;
            // 
            // labelAllRecipes
            // 
            labelAllRecipes.AutoSize = true;
            labelAllRecipes.ForeColor = Color.Navy;
            labelAllRecipes.Location = new Point(545, 135);
            labelAllRecipes.Margin = new Padding(4, 0, 4, 0);
            labelAllRecipes.Name = "labelAllRecipes";
            labelAllRecipes.Size = new Size(96, 25);
            labelAllRecipes.TabIndex = 20;
            labelAllRecipes.Text = "All Recipes";
            // 
            // comboBoxAllRecipes
            // 
            comboBoxAllRecipes.FormattingEnabled = true;
            comboBoxAllRecipes.Location = new Point(637, 132);
            comboBoxAllRecipes.Margin = new Padding(4, 4, 4, 4);
            comboBoxAllRecipes.Name = "comboBoxAllRecipes";
            comboBoxAllRecipes.Size = new Size(253, 33);
            comboBoxAllRecipes.TabIndex = 21;
            // 
            // buttonViewRecipe
            // 
            buttonViewRecipe.ForeColor = Color.Navy;
            buttonViewRecipe.Location = new Point(900, 132);
            buttonViewRecipe.Margin = new Padding(4, 4, 4, 4);
            buttonViewRecipe.Name = "buttonViewRecipe";
            buttonViewRecipe.Size = new Size(96, 33);
            buttonViewRecipe.TabIndex = 22;
            buttonViewRecipe.Text = "View";
            buttonViewRecipe.UseVisualStyleBackColor = true;
            buttonViewRecipe.Click += buttonViewRecipe_Click;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1024, 645);
            Controls.Add(buttonViewRecipe);
            Controls.Add(comboBoxAllRecipes);
            Controls.Add(labelAllRecipes);
            Controls.Add(buttonNewSearch);
            Controls.Add(buttonLoginAdmin);
            Controls.Add(buttonShowRecipe);
            Controls.Add(textBoxTitel);
            Controls.Add(labelTitel);
            Controls.Add(listBoxRecipeDetails);
            Controls.Add(labelRecipeDetails);
            Controls.Add(listBoxResult);
            Controls.Add(labelResult);
            Controls.Add(buttonSearch);
            Controls.Add(comboBoxType);
            Controls.Add(labelRecipeType);
            Controls.Add(labelSearchRecipe);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormSearch";
            Text = "FormSearch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearchRecipe;
        private Label labelRecipeType;
        private ComboBox comboBoxType;
        private Button buttonSearch;
        private Label labelResult;
        private ListBox listBoxResult;
        private Label labelRecipeDetails;
        private ListBox listBoxRecipeDetails;
        private Label labelTitel;
        private TextBox textBoxTitel;
        private Button buttonShowRecipe;
        private Button buttonLoginAdmin;
        private Button buttonNewSearch;
        private Label labelAllRecipes;
        private ComboBox comboBoxAllRecipes;
        private Button buttonViewRecipe;
    }
}