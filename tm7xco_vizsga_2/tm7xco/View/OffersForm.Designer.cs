
namespace tm7xco.View
{
    partial class OffersForm
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
            this.phoneContainer = new System.Windows.Forms.Panel();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phoneContainer
            // 
            this.phoneContainer.AutoScroll = true;
            this.phoneContainer.Location = new System.Drawing.Point(13, 13);
            this.phoneContainer.Name = "phoneContainer";
            this.phoneContainer.Size = new System.Drawing.Size(744, 377);
            this.phoneContainer.TabIndex = 0;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(618, 406);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(75, 32);
            this.buttonOrder.TabIndex = 1;
            this.buttonOrder.Text = "Rendelés";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // OffersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.phoneContainer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OffersForm";
            this.Text = "Ajánlatok";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel phoneContainer;
        private System.Windows.Forms.Button buttonOrder;
    }
}