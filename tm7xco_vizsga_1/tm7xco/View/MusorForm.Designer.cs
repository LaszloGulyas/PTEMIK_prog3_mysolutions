
namespace tm7xco.View
{
    partial class MusorForm
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
            this.eloadasokListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIrta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.szereposztasListBox = new System.Windows.Forms.ListBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // eloadasokListBox
            // 
            this.eloadasokListBox.FormattingEnabled = true;
            this.eloadasokListBox.Location = new System.Drawing.Point(12, 33);
            this.eloadasokListBox.Name = "eloadasokListBox";
            this.eloadasokListBox.Size = new System.Drawing.Size(231, 394);
            this.eloadasokListBox.TabIndex = 0;
            this.eloadasokListBox.SelectedIndexChanged += new System.EventHandler(this.eloadasokListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Előadások:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kép";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cím:";
            // 
            // textBoxCim
            // 
            this.textBoxCim.Location = new System.Drawing.Point(267, 368);
            this.textBoxCim.Name = "textBoxCim";
            this.textBoxCim.ReadOnly = true;
            this.textBoxCim.Size = new System.Drawing.Size(235, 20);
            this.textBoxCim.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Írta:";
            // 
            // textBoxIrta
            // 
            this.textBoxIrta.Location = new System.Drawing.Point(267, 412);
            this.textBoxIrta.Name = "textBoxIrta";
            this.textBoxIrta.Size = new System.Drawing.Size(235, 20);
            this.textBoxIrta.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Szereposztás:";
            // 
            // szereposztasListBox
            // 
            this.szereposztasListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.szereposztasListBox.Enabled = false;
            this.szereposztasListBox.FormattingEnabled = true;
            this.szereposztasListBox.Location = new System.Drawing.Point(520, 50);
            this.szereposztasListBox.Name = "szereposztasListBox";
            this.szereposztasListBox.Size = new System.Drawing.Size(268, 379);
            this.szereposztasListBox.TabIndex = 8;
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(267, 79);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(235, 122);
            this.imageBox.TabIndex = 9;
            this.imageBox.TabStop = false;
            // 
            // MusorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.szereposztasListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxIrta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eloadasokListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusorForm";
            this.Text = "Műsor";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox eloadasokListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIrta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox szereposztasListBox;
        private System.Windows.Forms.PictureBox imageBox;
    }
}