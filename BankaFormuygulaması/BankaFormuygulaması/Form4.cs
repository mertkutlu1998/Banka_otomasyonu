using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaFormuygulaması
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Evet")
            {
                double garantibireyselfaiz1 = 1.5;
                double tutar1 = Convert.ToDouble(textBox3.Text);
                double vade1 = Convert.ToDouble(textBox4.Text);
                double hesaplama1 = tutar1 + (tutar1 * vade1 * garantibireyselfaiz1 / 120);
                double kalanodeme = hesaplama1 - vade1;
                label6.Text = ($"toplam kredi tutarı {hesaplama1} TL".ToString());
                label7.Text = ($"{kalanodeme} TL".ToString());
            }
            else
            {
                MessageBox.Show("İşleminize Devam Edilemiyor...");               
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
