
namespace nflShopSolution.View
{
    partial class AccountingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRendelesSzam = new System.Windows.Forms.Label();
            this.labelBeszerAr = new System.Windows.Forms.Label();
            this.labelEladAr = new System.Windows.Forms.Label();
            this.labelNyereseg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendelések száma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Beszerzési ár:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eladási ár:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nyereség:";
            // 
            // labelRendelesSzam
            // 
            this.labelRendelesSzam.AutoSize = true;
            this.labelRendelesSzam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRendelesSzam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelRendelesSzam.Location = new System.Drawing.Point(145, 13);
            this.labelRendelesSzam.Name = "labelRendelesSzam";
            this.labelRendelesSzam.Size = new System.Drawing.Size(35, 17);
            this.labelRendelesSzam.TabIndex = 0;
            this.labelRendelesSzam.Text = "0db";
            // 
            // labelBeszerAr
            // 
            this.labelBeszerAr.AutoSize = true;
            this.labelBeszerAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBeszerAr.ForeColor = System.Drawing.Color.Green;
            this.labelBeszerAr.Location = new System.Drawing.Point(145, 45);
            this.labelBeszerAr.Name = "labelBeszerAr";
            this.labelBeszerAr.Size = new System.Drawing.Size(26, 17);
            this.labelBeszerAr.TabIndex = 0;
            this.labelBeszerAr.Text = "$0";
            // 
            // labelEladAr
            // 
            this.labelEladAr.AutoSize = true;
            this.labelEladAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEladAr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEladAr.Location = new System.Drawing.Point(144, 79);
            this.labelEladAr.Name = "labelEladAr";
            this.labelEladAr.Size = new System.Drawing.Size(26, 17);
            this.labelEladAr.TabIndex = 0;
            this.labelEladAr.Text = "$0";
            // 
            // labelNyereseg
            // 
            this.labelNyereseg.AutoSize = true;
            this.labelNyereseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNyereseg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelNyereseg.Location = new System.Drawing.Point(144, 112);
            this.labelNyereseg.Name = "labelNyereseg";
            this.labelNyereseg.Size = new System.Drawing.Size(26, 17);
            this.labelNyereseg.TabIndex = 0;
            this.labelNyereseg.Text = "$0";
            // 
            // AccountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 147);
            this.Controls.Add(this.labelNyereseg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelEladAr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelBeszerAr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRendelesSzam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountingForm";
            this.Text = "Könyvelés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRendelesSzam;
        private System.Windows.Forms.Label labelBeszerAr;
        private System.Windows.Forms.Label labelEladAr;
        private System.Windows.Forms.Label labelNyereseg;
    }
}