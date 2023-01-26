
using System;

namespace Polygon
{
    partial class Polygon
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
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efficiencyGraphicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figureTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithmTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jarvisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.figureTypeToolStripMenuItem,
            this.algorithmTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
            this.efficiencyGraphicToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeColorToolStripMenuItem.Text = "Change Color";
            this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // efficiencyGraphicToolStripMenuItem
            // 
            this.efficiencyGraphicToolStripMenuItem.Name = "efficiencyGraphicToolStripMenuItem";
            this.efficiencyGraphicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.efficiencyGraphicToolStripMenuItem.Text = "Efficiency Graphic";
            this.efficiencyGraphicToolStripMenuItem.Click += new System.EventHandler(this.efficiencyGraphicToolStripMenuItem_Click);
            // 
            // figureTypeToolStripMenuItem
            // 
            this.figureTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circleToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.triangleToolStripMenuItem});
            this.figureTypeToolStripMenuItem.Name = "figureTypeToolStripMenuItem";
            this.figureTypeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.figureTypeToolStripMenuItem.Text = "Figure Type";
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Checked = true;
            this.circleToolStripMenuItem.CheckOnClick = true;
            this.circleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.FigureToolStripMenuItem_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.FigureToolStripMenuItem_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.FigureToolStripMenuItem_Click);
            // 
            // algorithmTypeToolStripMenuItem
            // 
            this.algorithmTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jarvisToolStripMenuItem,
            this.standardToolStripMenuItem});
            this.algorithmTypeToolStripMenuItem.Name = "algorithmTypeToolStripMenuItem";
            this.algorithmTypeToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.algorithmTypeToolStripMenuItem.Text = "Algorithm Type";
            // 
            // jarvisToolStripMenuItem
            // 
            this.jarvisToolStripMenuItem.Checked = true;
            this.jarvisToolStripMenuItem.CheckOnClick = true;
            this.jarvisToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jarvisToolStripMenuItem.Name = "jarvisToolStripMenuItem";
            this.jarvisToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.jarvisToolStripMenuItem.Text = "Jarvis";
            this.jarvisToolStripMenuItem.Click += new System.EventHandler(this.AlgorithmToolStripMenuItem_Click);
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.AlgorithmToolStripMenuItem_Click);
            // 
            // Polygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Polygon";
            this.Text = "Polygons";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem figureTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorithmTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jarvisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efficiencyGraphicToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
    }
}

