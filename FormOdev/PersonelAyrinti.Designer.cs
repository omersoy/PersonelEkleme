namespace FormOdev
{
    partial class PersonelAyrinti
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbxTcNo = new System.Windows.Forms.TextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.yenile = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1311, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // tbxTcNo
            // 
            this.tbxTcNo.Location = new System.Drawing.Point(386, 15);
            this.tbxTcNo.Name = "tbxTcNo";
            this.tbxTcNo.Size = new System.Drawing.Size(197, 20);
            this.tbxTcNo.TabIndex = 13;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(334, 20);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(41, 13);
            this.lblTc.TabIndex = 14;
            this.lblTc.Text = "TC No:";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(596, 13);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(167, 23);
            this.btnAra.TabIndex = 15;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(821, 15);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(131, 23);
            this.yenile.TabIndex = 16;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(1129, 13);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(131, 23);
            this.silBtn.TabIndex = 17;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // PersonelAyrinti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 521);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.tbxTcNo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PersonelAyrinti";
            this.Text = "PersonelAyrinti";
            this.Load += new System.EventHandler(this.PersonelAyrinti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox tbxTcNo;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button silBtn;
    }
}