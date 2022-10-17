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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double krediTutar = Convert.ToDouble(textBox1.Text);
            double taksit = Convert.ToDouble(textBox2.Text);
            double bireyselFaiz = 1.5;
            double hesap;
            double aylıktaksit;

            hesap = krediTutar + (krediTutar * taksit * bireyselFaiz / 120);
            aylıktaksit = hesap / taksit;

            listBox1.Items.Add("Ödemeniz gereken toplam kredi tutarı: \n" + hesap);

            for (int i = 1; i <= taksit; i++)
            {
                aylıktaksit = aylıktaksit - (aylıktaksit * bireyselFaiz / 100);

                listBox1.Items.Add("Aylık taksit tutarı  = \n" + (hesap / taksit));
                listBox1.Items.Add($"{i}.Faiz tutarı  = \n" + (aylıktaksit));
                listBox1.Items.Add("Anapara  = \n" + (hesap / taksit - aylıktaksit));

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }
    }
}
