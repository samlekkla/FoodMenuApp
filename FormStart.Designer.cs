namespace GrupparbeteFoodapplication
{
    partial class FormStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            buttonSearchRecipe = new Button();
            comboBoxRecipeView = new ComboBox();
            label4 = new Label();
            richTextBoxDescription = new RichTextBox();
            comboBoxType = new ComboBox();
            buttonLoginAdmin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(485, 51);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(485, 110);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 176);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(542, 110);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(201, 27);
            textBoxName.TabIndex = 4;
            // 
            // buttonSearchRecipe
            // 
            buttonSearchRecipe.Location = new Point(48, 320);
            buttonSearchRecipe.Name = "buttonSearchRecipe";
            buttonSearchRecipe.Size = new Size(94, 29);
            buttonSearchRecipe.TabIndex = 11;
            buttonSearchRecipe.Text = "Search Recipe";
            buttonSearchRecipe.UseVisualStyleBackColor = true;
            buttonSearchRecipe.Click += buttonSearchRecipe_Click;
            // 
            // comboBoxRecipeView
            // 
            comboBoxRecipeView.FormattingEnabled = true;
            comboBoxRecipeView.Location = new Point(48, 113);
            comboBoxRecipeView.Name = "comboBoxRecipeView";
            comboBoxRecipeView.Size = new Size(191, 28);
            comboBoxRecipeView.TabIndex = 12;
            comboBoxRecipeView.SelectedIndexChanged += comboBoxRecipeView_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 74);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 13;
            label4.Text = "Recipe list";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(485, 199);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(258, 150);
            richTextBoxDescription.TabIndex = 15;
            richTextBoxDescription.Text = "";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(548, 51);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(195, 28);
            comboBoxType.TabIndex = 16;
            // 
            // buttonLoginAdmin
            // 
            buttonLoginAdmin.Location = new Point(48, 12);
            buttonLoginAdmin.Name = "buttonLoginAdmin";
            buttonLoginAdmin.Size = new Size(103, 29);
            buttonLoginAdmin.TabIndex = 17;
            buttonLoginAdmin.Text = "Admin Login";
            buttonLoginAdmin.UseVisualStyleBackColor = true;
            buttonLoginAdmin.Click += buttonLoginAdmin_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoginAdmin);
            Controls.Add(comboBoxType);
            Controls.Add(richTextBoxDescription);
            Controls.Add(label4);
            Controls.Add(comboBoxRecipeView);
            Controls.Add(buttonSearchRecipe);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormStart";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private Button buttonSearchRecipe;
        private ComboBox comboBoxRecipeView;
        private Label label4;
        private RichTextBox richTextBoxDescription;
        private ComboBox comboBoxType;
        private Button buttonLoginAdmin;
    }
}
