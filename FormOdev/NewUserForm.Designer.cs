namespace FormOdev
{
    partial class NewUserForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.userNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(192, 183);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 37);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Kullanıcı Ekle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(162, 127);
            this.passwordTb.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(209, 20);
            this.passwordTb.TabIndex = 16;
            // 
            // userNameTb
            // 
            this.userNameTb.Location = new System.Drawing.Point(162, 50);
            this.userNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTb.Name = "userNameTb";
            this.userNameTb.Size = new System.Drawing.Size(209, 20);
            this.userNameTb.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kullanıcı Adı: ";
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 310);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.userNameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "NewUserForm";
            this.Text = "NewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox userNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}