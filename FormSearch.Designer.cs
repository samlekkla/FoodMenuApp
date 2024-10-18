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
            comboBox1 = new ComboBox();
            buttonSearch = new Button();
            labelResult = new Label();
            listBoxResult = new ListBox();
            labelRecipeDetails = new Label();
            listBoxRecipeDetails = new ListBox();
            buttonClose = new Button();
            labelTitel = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // labelSearchRecipe
            // 
            labelSearchRecipe.AutoSize = true;
            labelSearchRecipe.Location = new Point(38, 9);
            labelSearchRecipe.Name = "labelSearchRecipe";
            labelSearchRecipe.Size = new Size(102, 20);
            labelSearchRecipe.TabIndex = 0;
            labelSearchRecipe.Text = "Search Recipe";
            // 
            // labelRecipeType
            // 
            labelRecipeType.AutoSize = true;
            labelRecipeType.Location = new Point(38, 83);
            labelRecipeType.Name = "labelRecipeType";
            labelRecipeType.Size = new Size(92, 20);
            labelRecipeType.TabIndex = 1;
            labelRecipeType.Text = "Recipe Type:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(293, 79);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(38, 118);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(49, 20);
            labelResult.TabIndex = 4;
            labelResult.Text = "Result";
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.Location = new Point(38, 141);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(245, 64);
            listBoxResult.TabIndex = 5;
            listBoxResult.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // labelRecipeDetails
            // 
            labelRecipeDetails.AutoSize = true;
            labelRecipeDetails.Location = new Point(38, 228);
            labelRecipeDetails.Name = "labelRecipeDetails";
            labelRecipeDetails.Size = new Size(104, 20);
            labelRecipeDetails.TabIndex = 6;
            labelRecipeDetails.Text = "Recipe Details";
            // 
            // listBoxRecipeDetails
            // 
            listBoxRecipeDetails.FormattingEnabled = true;
            listBoxRecipeDetails.Location = new Point(38, 251);
            listBoxRecipeDetails.Name = "listBoxRecipeDetails";
            listBoxRecipeDetails.Size = new Size(280, 164);
            listBoxRecipeDetails.TabIndex = 7;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(645, 386);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(143, 29);
            buttonClose.TabIndex = 8;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += button1_Click;
            // 
            // labelTitel
            // 
            labelTitel.AutoSize = true;
            labelTitel.Location = new Point(38, 48);
            labelTitel.Name = "labelTitel";
            labelTitel.Size = new Size(45, 20);
            labelTitel.TabIndex = 10;
            labelTitel.Text = "Titel: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 11;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 467);
            Controls.Add(textBox1);
            Controls.Add(labelTitel);
            Controls.Add(buttonClose);
            Controls.Add(listBoxRecipeDetails);
            Controls.Add(labelRecipeDetails);
            Controls.Add(listBoxResult);
            Controls.Add(labelResult);
            Controls.Add(buttonSearch);
            Controls.Add(comboBox1);
            Controls.Add(labelRecipeType);
            Controls.Add(labelSearchRecipe);
            Name = "FormSearch";
            Text = "FormSearch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearchRecipe;
        private Label labelRecipeType;
        private ComboBox comboBox1;
        private Button buttonSearch;
        private Label labelResult;
        private ListBox listBoxResult;
        private Label labelRecipeDetails;
        private ListBox listBoxRecipeDetails;
        private Button buttonClose;
        private Label labelTitel;
        private TextBox textBox1;
    }
}