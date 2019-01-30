﻿namespace MineSweeper
{
    partial class MineSweeper
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OptionsDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.RulesDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsDropDown});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OptionsDropDown
            // 
            this.OptionsDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameDropDown,
            this.RulesDropDown,
            this.ExitDropDown});
            this.OptionsDropDown.Name = "OptionsDropDown";
            this.OptionsDropDown.Size = new System.Drawing.Size(73, 24);
            this.OptionsDropDown.Text = "Options";
            // 
            // NewGameDropDown
            // 
            this.NewGameDropDown.Name = "NewGameDropDown";
            this.NewGameDropDown.Size = new System.Drawing.Size(216, 26);
            this.NewGameDropDown.Text = "New Game";
            this.NewGameDropDown.Click += new System.EventHandler(this.NewGameDropDown_Click);
            // 
            // RulesDropDown
            // 
            this.RulesDropDown.Name = "RulesDropDown";
            this.RulesDropDown.Size = new System.Drawing.Size(216, 26);
            this.RulesDropDown.Text = "Rules";
            this.RulesDropDown.Click += new System.EventHandler(this.RulesDropDown_Click);
            // 
            // ExitDropDown
            // 
            this.ExitDropDown.Name = "ExitDropDown";
            this.ExitDropDown.Size = new System.Drawing.Size(216, 26);
            this.ExitDropDown.Text = "Exit";
            this.ExitDropDown.Click += new System.EventHandler(this.ExitDropDown_Click);
            // 
            // MineSweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MineSweeper";
            this.Text = "MineSweeper";
            this.Load += new System.EventHandler(this.MineSweeper_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OptionsDropDown;
        private System.Windows.Forms.ToolStripMenuItem NewGameDropDown;
        private System.Windows.Forms.ToolStripMenuItem RulesDropDown;
        private System.Windows.Forms.ToolStripMenuItem ExitDropDown;
    }
}

