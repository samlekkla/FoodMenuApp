namespace GrupparbeteFoodapplication
{
    partial class Formcrud
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
            buttonSave = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxType = new ComboBox();
            comboBoxRecipeView = new ComboBox();
            textBoxName = new TextBox();
            TextBoxDescription = new RichTextBox();
            buttonRefresh = new Button();
            buttonTestError = new Button();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(172, 325);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(284, 325);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(410, 325);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 132);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 3;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 90);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 181);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(528, 86);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 6;
            label4.Text = "Recipe list";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(172, 129);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(151, 28);
            comboBoxType.TabIndex = 7;
            // 
            // comboBoxRecipeView
            // 
            comboBoxRecipeView.FormattingEnabled = true;
            comboBoxRecipeView.Location = new Point(611, 83);
            comboBoxRecipeView.Name = "comboBoxRecipeView";
            comboBoxRecipeView.Size = new Size(151, 28);
            comboBoxRecipeView.TabIndex = 8;
            comboBoxRecipeView.SelectedIndexChanged += comboBoxRecipeView_SelectedIndexChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(172, 83);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 9;
            // 
            // TextBoxDescription
            // 
            TextBoxDescription.Location = new Point(172, 178);
            TextBoxDescription.Name = "TextBoxDescription";
            TextBoxDescription.Size = new Size(256, 120);
            TextBoxDescription.TabIndex = 10;
            TextBoxDescription.Text = "";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(434, 178);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(112, 41);
            buttonRefresh.TabIndex = 11;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonTestError
            // 
            buttonTestError.Location = new Point(602, 408);
            buttonTestError.Name = "buttonTestError";
            buttonTestError.Size = new Size(160, 57);
            buttonTestError.TabIndex = 12;
            buttonTestError.Text = "TestError";
            buttonTestError.UseVisualStyleBackColor = true;
            buttonTestError.Click += buttonTestError_Click;
            // 
            // Formcrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 477);
            Controls.Add(buttonTestError);
            Controls.Add(buttonRefresh);
            Controls.Add(TextBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxRecipeView);
            Controls.Add(comboBoxType);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSave);
            Name = "Formcrud";
            Text = "Formcrud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxType;
        private ComboBox comboBoxRecipeView;
        private TextBox textBoxName;
        private RichTextBox TextBoxDescription;
        private Button buttonRefresh;
        private Button buttonTestError;
    }
}