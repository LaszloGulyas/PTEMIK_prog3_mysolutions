
namespace nflShopSolution
{
    partial class MainForm
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
            this.openfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.könyvelésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openfileToolStripMenuItem,
            this.kettoToolStripMenuItem,
            this.könyvelésToolStripMenuItem,
            this.névjegyToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openfileToolStripMenuItem
            // 
            this.openfileToolStripMenuItem.Name = "openfileToolStripMenuItem";
            this.openfileToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.openfileToolStripMenuItem.Text = "Fájl betöltés...";
            this.openfileToolStripMenuItem.Click += new System.EventHandler(this.openFileStripMenuItem_Click);
            // 
            // kettoToolStripMenuItem
            // 
            this.kettoToolStripMenuItem.Name = "kettoToolStripMenuItem";
            this.kettoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.kettoToolStripMenuItem.Text = "Rendelés...";
            this.kettoToolStripMenuItem.Click += new System.EventHandler(this.kettoToolStripMenuItem_Click);
            // 
            // könyvelésToolStripMenuItem
            // 
            this.könyvelésToolStripMenuItem.Name = "könyvelésToolStripMenuItem";
            this.könyvelésToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.könyvelésToolStripMenuItem.Text = "Könyvelés...";
            this.könyvelésToolStripMenuItem.Click += new System.EventHandler(this.könyvelésToolStripMenuItem_Click);
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.névjegyToolStripMenuItem.Text = "Névjegy...";
            this.névjegyToolStripMenuItem.Click += new System.EventHandler(this.névjegyToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nflShopSolution.Properties.Resources.shield;
            this.ClientSize = new System.Drawing.Size(1097, 617);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "NFL shop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kettoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem könyvelésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}