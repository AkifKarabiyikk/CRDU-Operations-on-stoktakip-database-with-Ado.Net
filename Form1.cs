using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "1907")
            {
                gbGirisFormu.Visible = false;
                gbMenu.Visible = true;
                MessageBox.Show("Welcome " + txtKullaniciAdi.Text);          
               
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                     
        }
    }
}
