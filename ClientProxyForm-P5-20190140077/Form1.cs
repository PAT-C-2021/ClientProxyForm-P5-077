using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxyForm_P5_20190140077
{
    public partial class Form1 : Form
    {
        ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();

        public Form1()

        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelPengurangan_Click(object sender, EventArgs e)
        {

        }

        private void buttonHasil_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textBox1.Text);
            int angka2 = Convert.ToInt32(textBox2.Text);

            double hasilTambah = obj.Tambah(angka1, angka2);
            double hasilKurang = obj.Kurang(angka1, angka2);
            double hasilkali = obj.Kali(angka1, angka2);
            double hasilBagi = obj.Bagi(angka1, angka2);

            labelPenjumlahan.Text = hasilTambah.ToString();
            labelPengurangan.Text = hasilKurang.ToString();
            labelPerkalian.Text = hasilkali.ToString();
            labelPembagian.Text = hasilBagi.ToString();

        }
    }
}
