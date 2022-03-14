namespace WindowsFormsApp7
{
    partial class FormTampilanData
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
            this.TxtBoxTelp = new System.Windows.Forms.TextBox();
            this.TxtBoxAlamat = new System.Windows.Forms.TextBox();
            this.TxtBoxNama = new System.Windows.Forms.TextBox();
            this.LblTelp = new System.Windows.Forms.Label();
            this.LblAlamat = new System.Windows.Forms.Label();
            this.LblNama = new System.Windows.Forms.Label();
            this.BtnKembali = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxTelp
            // 
            this.TxtBoxTelp.Enabled = false;
            this.TxtBoxTelp.Location = new System.Drawing.Point(93, 110);
            this.TxtBoxTelp.Name = "TxtBoxTelp";
            this.TxtBoxTelp.Size = new System.Drawing.Size(427, 22);
            this.TxtBoxTelp.TabIndex = 11;
            // 
            // TxtBoxAlamat
            // 
            this.TxtBoxAlamat.Enabled = false;
            this.TxtBoxAlamat.Location = new System.Drawing.Point(93, 68);
            this.TxtBoxAlamat.Name = "TxtBoxAlamat";
            this.TxtBoxAlamat.Size = new System.Drawing.Size(427, 22);
            this.TxtBoxAlamat.TabIndex = 10;
            // 
            // TxtBoxNama
            // 
            this.TxtBoxNama.Enabled = false;
            this.TxtBoxNama.Location = new System.Drawing.Point(93, 29);
            this.TxtBoxNama.Name = "TxtBoxNama";
            this.TxtBoxNama.Size = new System.Drawing.Size(427, 22);
            this.TxtBoxNama.TabIndex = 9;
            // 
            // LblTelp
            // 
            this.LblTelp.AutoSize = true;
            this.LblTelp.Location = new System.Drawing.Point(31, 110);
            this.LblTelp.Name = "LblTelp";
            this.LblTelp.Size = new System.Drawing.Size(41, 16);
            this.LblTelp.TabIndex = 8;
            this.LblTelp.Text = "Telp :";
            // 
            // LblAlamat
            // 
            this.LblAlamat.AutoSize = true;
            this.LblAlamat.Location = new System.Drawing.Point(32, 68);
            this.LblAlamat.Name = "LblAlamat";
            this.LblAlamat.Size = new System.Drawing.Size(55, 16);
            this.LblAlamat.TabIndex = 7;
            this.LblAlamat.Text = "Alamat :";
            // 
            // LblNama
            // 
            this.LblNama.AutoSize = true;
            this.LblNama.Location = new System.Drawing.Point(32, 29);
            this.LblNama.Name = "LblNama";
            this.LblNama.Size = new System.Drawing.Size(50, 16);
            this.LblNama.TabIndex = 6;
            this.LblNama.Text = "Nama :";
            // 
            // BtnKembali
            // 
            this.BtnKembali.Location = new System.Drawing.Point(35, 161);
            this.BtnKembali.Name = "BtnKembali";
            this.BtnKembali.Size = new System.Drawing.Size(85, 29);
            this.BtnKembali.TabIndex = 12;
            this.BtnKembali.Text = "Kembali";
            this.BtnKembali.UseVisualStyleBackColor = true;
            this.BtnKembali.Click += new System.EventHandler(this.BtnKembali_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Location = new System.Drawing.Point(148, 161);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(85, 29);
            this.BtnPrev.TabIndex = 13;
            this.BtnPrev.Text = "Prev Data";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(257, 161);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(85, 29);
            this.BtnNext.TabIndex = 14;
            this.BtnNext.Text = "Next Data";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // FormTampilanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 224);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnKembali);
            this.Controls.Add(this.TxtBoxTelp);
            this.Controls.Add(this.TxtBoxAlamat);
            this.Controls.Add(this.TxtBoxNama);
            this.Controls.Add(this.LblTelp);
            this.Controls.Add(this.LblAlamat);
            this.Controls.Add(this.LblNama);
            this.Name = "FormTampilanData";
            this.Text = "FormTampilanData";
            this.Load += new System.EventHandler(this.FormTampilanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxTelp;
        private System.Windows.Forms.TextBox TxtBoxAlamat;
        private System.Windows.Forms.TextBox TxtBoxNama;
        private System.Windows.Forms.Label LblTelp;
        private System.Windows.Forms.Label LblAlamat;
        private System.Windows.Forms.Label LblNama;
        private System.Windows.Forms.Button BtnKembali;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
    }
}