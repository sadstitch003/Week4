namespace WindowsFormsApp7
{
    partial class FormPenambahanData
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
            this.LblNama = new System.Windows.Forms.Label();
            this.LblAlamat = new System.Windows.Forms.Label();
            this.LblTelp = new System.Windows.Forms.Label();
            this.TxtBoxNama = new System.Windows.Forms.TextBox();
            this.TxtBoxAlamat = new System.Windows.Forms.TextBox();
            this.TxtBoxTelp = new System.Windows.Forms.TextBox();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnLihatData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNama
            // 
            this.LblNama.AutoSize = true;
            this.LblNama.Location = new System.Drawing.Point(30, 36);
            this.LblNama.Name = "LblNama";
            this.LblNama.Size = new System.Drawing.Size(50, 16);
            this.LblNama.TabIndex = 0;
            this.LblNama.Text = "Nama :";
            // 
            // LblAlamat
            // 
            this.LblAlamat.AutoSize = true;
            this.LblAlamat.Location = new System.Drawing.Point(30, 75);
            this.LblAlamat.Name = "LblAlamat";
            this.LblAlamat.Size = new System.Drawing.Size(55, 16);
            this.LblAlamat.TabIndex = 1;
            this.LblAlamat.Text = "Alamat :";
            // 
            // LblTelp
            // 
            this.LblTelp.AutoSize = true;
            this.LblTelp.Location = new System.Drawing.Point(29, 117);
            this.LblTelp.Name = "LblTelp";
            this.LblTelp.Size = new System.Drawing.Size(41, 16);
            this.LblTelp.TabIndex = 2;
            this.LblTelp.Text = "Telp :";
            // 
            // TxtBoxNama
            // 
            this.TxtBoxNama.Location = new System.Drawing.Point(92, 33);
            this.TxtBoxNama.Name = "TxtBoxNama";
            this.TxtBoxNama.Size = new System.Drawing.Size(427, 22);
            this.TxtBoxNama.TabIndex = 3;
            // 
            // TxtBoxAlamat
            // 
            this.TxtBoxAlamat.Location = new System.Drawing.Point(92, 72);
            this.TxtBoxAlamat.Name = "TxtBoxAlamat";
            this.TxtBoxAlamat.Size = new System.Drawing.Size(427, 22);
            this.TxtBoxAlamat.TabIndex = 4;
            // 
            // TxtBoxTelp
            // 
            this.TxtBoxTelp.Location = new System.Drawing.Point(92, 114);
            this.TxtBoxTelp.Name = "TxtBoxTelp";
            this.TxtBoxTelp.Size = new System.Drawing.Size(427, 22);
            this.TxtBoxTelp.TabIndex = 5;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(33, 165);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(89, 28);
            this.BtnSimpan.TabIndex = 6;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnLihatData
            // 
            this.BtnLihatData.Location = new System.Drawing.Point(153, 165);
            this.BtnLihatData.Name = "BtnLihatData";
            this.BtnLihatData.Size = new System.Drawing.Size(89, 28);
            this.BtnLihatData.TabIndex = 7;
            this.BtnLihatData.Text = "Lihat Data";
            this.BtnLihatData.UseVisualStyleBackColor = true;
            this.BtnLihatData.Click += new System.EventHandler(this.BtnLihatData_Click);
            // 
            // FormPenambahanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 219);
            this.Controls.Add(this.BtnLihatData);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.TxtBoxTelp);
            this.Controls.Add(this.TxtBoxAlamat);
            this.Controls.Add(this.TxtBoxNama);
            this.Controls.Add(this.LblTelp);
            this.Controls.Add(this.LblAlamat);
            this.Controls.Add(this.LblNama);
            this.Name = "FormPenambahanData";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.FormPenambahanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNama;
        private System.Windows.Forms.Label LblAlamat;
        private System.Windows.Forms.Label LblTelp;
        private System.Windows.Forms.TextBox TxtBoxNama;
        private System.Windows.Forms.TextBox TxtBoxAlamat;
        private System.Windows.Forms.TextBox TxtBoxTelp;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnLihatData;
    }
}

