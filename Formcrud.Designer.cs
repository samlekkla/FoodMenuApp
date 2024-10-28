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
            buttonSave.ForeColor = Color.Navy;
            buttonSave.Location = new Point(56, 463);
            buttonSave.Margin = new Padding(4, 4, 4, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(118, 36);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.ForeColor = Color.Navy;
            buttonUpdate.Location = new Point(201, 463);
            buttonUpdate.Margin = new Padding(4, 4, 4, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(118, 36);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.ForeColor = Color.Navy;
            buttonDelete.Location = new Point(355, 463);
            buttonDelete.Margin = new Padding(4, 4, 4, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(118, 36);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(36, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 3;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(36, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(56, 254);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(16, 174);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 6;
            label4.Text = "Recipe list";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(114, 105);
            comboBoxType.Margin = new Padding(4, 4, 4, 4);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(188, 33);
            comboBoxType.TabIndex = 7;
            // 
            // comboBoxRecipeView
            // 
            comboBoxRecipeView.FormattingEnabled = true;
            comboBoxRecipeView.Location = new Point(114, 171);
            comboBoxRecipeView.Margin = new Padding(4, 4, 4, 4);
            comboBoxRecipeView.Name = "comboBoxRecipeView";
            comboBoxRecipeView.Size = new Size(188, 33);
            comboBoxRecipeView.TabIndex = 8;
            comboBoxRecipeView.SelectedIndexChanged += comboBoxRecipeView_SelectedIndexChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(114, 37);
            textBoxName.Margin = new Padding(4, 4, 4, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(188, 31);
            textBoxName.TabIndex = 9;
            // 
            // TextBoxDescription
            // 
            TextBoxDescription.Location = new Point(56, 297);
            TextBoxDescription.Margin = new Padding(4, 4, 4, 4);
            TextBoxDescription.Name = "TextBoxDescription";
            TextBoxDescription.Size = new Size(417, 149);
            TextBoxDescription.TabIndex = 10;
            TextBoxDescription.Text = "";
            // 
            // buttonRefresh
            // 
            buttonRefresh.ForeColor = Color.Navy;
            buttonRefresh.Location = new Point(333, 254);
            buttonRefresh.Margin = new Padding(4, 4, 4, 4);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(140, 38);
            buttonRefresh.TabIndex = 11;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonTestError
            // 
            buttonTestError.ForeColor = Color.Navy;
            buttonTestError.Location = new Point(658, 526);
            buttonTestError.Margin = new Padding(4, 4, 4, 4);
            buttonTestError.Name = "buttonTestError";
            buttonTestError.Size = new Size(133, 85);
            buttonTestError.TabIndex = 12;
            buttonTestError.Text = "TestError";
            buttonTestError.UseVisualStyleBackColor = true;
            buttonTestError.Click += buttonTestError_Click;
            // 
            // Formcrud
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(804, 624);
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
            Enabled = false;
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 4, 4, 4);
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