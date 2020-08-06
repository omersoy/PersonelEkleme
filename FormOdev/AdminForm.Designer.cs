namespace FormOdev
{
    partial class AdminForm
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
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.btnYeniUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Location = new System.Drawing.Point(45, 105);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(291, 28);
            this.btnAnaSayfa.TabIndex = 3;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // btnYeniUser
            // 
            this.btnYeniUser.Location = new System.Drawing.Point(45, 38);
            this.btnYeniUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYeniUser.Name = "btnYeniUser";
            this.btnYeniUser.Size = new System.Drawing.Size(291, 28);
            this.btnYeniUser.TabIndex = 2;
            this.btnYeniUser.Text = "Yeni Kullanıcı Ekle";
            this.btnYeniUser.UseVisualStyleBackColor = true;
            this.btnYeniUser.Click += new System.EventHandler(this.btnYeniUser_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 164);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnYeniUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Button btnYeniUser;
    }
}