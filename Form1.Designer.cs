﻿namespace GrupparbeteFoodapplication
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            recipesToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            logInToolStripMenuItem = new ToolStripMenuItem();
            buttonTest = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { recipesToolStripMenuItem, searchToolStripMenuItem, logInToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // recipesToolStripMenuItem
            // 
            recipesToolStripMenuItem.Name = "recipesToolStripMenuItem";
            recipesToolStripMenuItem.Size = new Size(74, 24);
            recipesToolStripMenuItem.Text = "Recipes";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(67, 24);
            searchToolStripMenuItem.Text = "Search";
            // 
            // logInToolStripMenuItem
            // 
            logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            logInToolStripMenuItem.Size = new Size(64, 24);
            logInToolStripMenuItem.Text = "Log in";
            // 
            // buttonTest
            // 
            buttonTest.Location = new Point(226, 212);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(180, 80);
            buttonTest.TabIndex = 1;
            buttonTest.Text = "Test";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTest);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem recipesToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem logInToolStripMenuItem;
        private Button buttonTest;
    }
}
