namespace FormOdev
{
    partial class Personel
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
            this.btnYeniPerGirisi = new System.Windows.Forms.Button();
            this.btnPerGor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYeniPerGirisi
            // 
            this.btnYeniPerGirisi.Location = new System.Drawing.Point(16, 15);
            this.btnYeniPerGirisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYeniPerGirisi.Name = "btnYeniPerGirisi";
            this.btnYeniPerGirisi.Size = new System.Drawing.Size(291, 28);
            this.btnYeniPerGirisi.TabIndex = 0;
            this.btnYeniPerGirisi.Text = "Yeni Personel Girişi";
            this.btnYeniPerGirisi.UseVisualStyleBackColor = true;
            this.btnYeniPerGirisi.Click += new System.EventHandler(this.btnYeniPerGirisi_Click);
            // 
            // btnPerGor
            // 
            this.btnPerGor.Location = new System.Drawing.Point(16, 50);
            this.btnPerGor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPerGor.Name = "btnPerGor";
            this.btnPerGor.Size = new System.Drawing.Size(291, 28);
            this.btnPerGor.TabIndex = 1;
            this.btnPerGor.Text = "Personel Görüntüleme";
            this.btnPerGor.UseVisualStyleBackColor = true;
            this.btnPerGor.Click += new System.EventHandler(this.btnPerGor_Click);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 98);
            this.Controls.Add(this.btnPerGor);
            this.Controls.Add(this.btnYeniPerGirisi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Personel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniPerGirisi;
        private System.Windows.Forms.Button btnPerGor;
    }
}