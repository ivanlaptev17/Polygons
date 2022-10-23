
namespace Солнечная_система
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.солнце = new System.Windows.Forms.ToolStripMenuItem();
            this.луна = new System.Windows.Forms.ToolStripMenuItem();
            this.сатурн = new System.Windows.Forms.ToolStripMenuItem();
            this.комета = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.солнце,
            this.луна,
            this.сатурн,
            this.комета});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(129, 20);
            this.menu.Text = "Что на небосклоне?";
            // 
            // солнце
            // 
            this.солнце.CheckOnClick = true;
            this.солнце.Name = "солнце";
            this.солнце.Size = new System.Drawing.Size(180, 22);
            this.солнце.Text = "Солнце";
            this.солнце.CheckedChanged += new System.EventHandler(this.солнце_CheckedChanged);
            // 
            // луна
            // 
            this.луна.CheckOnClick = true;
            this.луна.Name = "луна";
            this.луна.Size = new System.Drawing.Size(180, 22);
            this.луна.Text = "Луна";
            this.луна.CheckedChanged += new System.EventHandler(this.луна_CheckedChanged);
            // 
            // сатурн
            // 
            this.сатурн.CheckOnClick = true;
            this.сатурн.Name = "сатурн";
            this.сатурн.Size = new System.Drawing.Size(180, 22);
            this.сатурн.Text = "Сатурн";
            this.сатурн.CheckedChanged += new System.EventHandler(this.сатурн_CheckedChanged);
            // 
            // комета
            // 
            this.комета.CheckOnClick = true;
            this.комета.Name = "комета";
            this.комета.Size = new System.Drawing.Size(180, 22);
            this.комета.Text = "Комета";
            this.комета.CheckedChanged += new System.EventHandler(this.комета_CheckedChanged);
            // 
            // pnl
            // 
            this.pnl.AutoSize = true;
            this.pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl.BackgroundImage")));
            this.pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 24);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(800, 426);
            this.pnl.TabIndex = 1;
            this.pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Солнечная система";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem солнце;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ToolStripMenuItem луна;
        private System.Windows.Forms.ToolStripMenuItem сатурн;
        private System.Windows.Forms.ToolStripMenuItem комета;
    }
}

