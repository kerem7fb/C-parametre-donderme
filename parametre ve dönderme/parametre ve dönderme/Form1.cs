using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parametre_ve_dönderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Toplam1() 
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int topla = sayi1 + sayi2;
            textBox3.Text = topla.ToString();
        }
        public int Toplam2() 
        {
            int sayi1 = Convert.ToInt32(textBox6.Text);
            int sayi2 = Convert.ToInt32(textBox5.Text);
            int topla = sayi1 + sayi2;
            return topla;
        }
        public void Toplam3(int num1, int num2) 
        {
            int toplam = num1 + num2;
            textBox7.Text = toplam.ToString();
        }
        public int Toplam4(int num1, int num2) 
        {
            int toplam = num1 + num2;
            return toplam;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Toplam1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = Toplam2().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox9.Text);
            int sayi2 = Convert.ToInt32(textBox8.Text);
            Toplam3(sayi1, sayi2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox12.Text);
            int sayi2 = Convert.ToInt32(textBox11.Text);
            int sonuç = Toplam4(sayi1, sayi2);
            textBox10.Text = sonuç.ToString();
        }
    }
}
