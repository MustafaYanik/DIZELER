using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac;

        string[] isimler = new string[5];
        private void button1_Click(object sender, EventArgs e)
        {
            isimler[sayac] = textBox1.Text;

            sayac++;

            if (sayac == 5) sayac = 0;

            lblİsimGiriniz.Text = (sayac + 1) + ". İsmi Giriniz";

            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstbox1.Items.Clear();

            for (int i = 0; i < isimler.Length; i++)
            {
                try
                {
                    lstbox1.Items.Add(isimler[i]);
                }
                catch (Exception)
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblİsimGiriniz.Text = (sayac + 1) + ". İsmi Giriniz";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
