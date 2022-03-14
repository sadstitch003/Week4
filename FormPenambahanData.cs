using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FormPenambahanData : Form
    {
        static DataTable dataDiri = new DataTable();
        public FormPenambahanData()
        {
            InitializeComponent();
            dataDiri.Columns.Add("NAMA");
            dataDiri.Columns.Add("ALAMAT");
            dataDiri.Columns.Add("TELP");
        }


        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (dataDiri.Rows.Count < 10)
            {
                if (TxtBoxNama.Text == "" || TxtBoxAlamat.Text == "" || TxtBoxTelp.Text == "")
                {
                    MessageBox.Show("Ada Data Yang Kosong !");
                }
                else
                {
                    if (TxtBoxTelp.Text.All(char.IsLetter))
                    {
                        MessageBox.Show("No Telp Harus Berisi Angka !");
                    }
                    else if (TxtBoxNama.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("Nama Harus Berisi Huruf !");
                    }
                    else
                    {
                        dataDiri.Rows.Add(TxtBoxNama.Text, TxtBoxAlamat.Text, TxtBoxTelp.Text);
                        TxtBoxNama.Text = null;
                        TxtBoxAlamat.Text = null;
                        TxtBoxTelp.Text = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Data Sudah Penuh !");
            }
        }

        FormTampilanData FormTampilan = new FormTampilanData(dataDiri);
        private void BtnLihatData_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTampilan.ShowDialog();
            this.Show();
        }

        private void FormPenambahanData_Load(object sender, EventArgs e)
        {

        }
    }
}
