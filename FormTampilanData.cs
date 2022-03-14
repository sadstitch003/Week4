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
    public partial class FormTampilanData : Form
    {
        DataTable dataDiri = new DataTable();
        int rowNum = 0;

        public FormTampilanData(DataTable table)
        {
            InitializeComponent();
            dataDiri = table;
        }

        private void FormTampilanData_Load(object sender, EventArgs e) 
        {;
            if (dataDiri.Rows.Count > 0)
            {
                TxtBoxNama.Text = dataDiri.Rows[0].ItemArray[0].ToString();
                TxtBoxAlamat.Text = dataDiri.Rows[0].ItemArray[1].ToString();
                TxtBoxTelp.Text = dataDiri.Rows[0].ItemArray[2].ToString();
            }
        }
                    
            
        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if(rowNum == 0)
            {
                MessageBox.Show("Data sudah data pertama");
            }
            else
            {
                rowNum--;
                TxtBoxNama.Text = dataDiri.Rows[rowNum].ItemArray[0].ToString();
                TxtBoxAlamat.Text = dataDiri.Rows[rowNum].ItemArray[1].ToString();
                TxtBoxTelp.Text = dataDiri.Rows[rowNum].ItemArray[2].ToString();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (rowNum == dataDiri.Rows.Count - 1)
            {
                MessageBox.Show("Data sudah data terakhir");
            }
            else
            {
                rowNum++;
                TxtBoxNama.Text = dataDiri.Rows[rowNum].ItemArray[0].ToString();
                TxtBoxAlamat.Text = dataDiri.Rows[rowNum].ItemArray[1].ToString();
                TxtBoxTelp.Text = dataDiri.Rows[rowNum].ItemArray[2].ToString();
            }
        }
    }
}
