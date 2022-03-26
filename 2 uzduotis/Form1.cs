using paskaita_8_darbas_02.Bussines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_uzduotis
{
    public partial class Form1 : Form
    {
        Palme palme;//////

        public Form1()
        {
            InitializeComponent();
            palme = new Palme(0, 0);//////
            textBox1.Text = $"amzius: {palme.Amzius}, vaisiu kiekis: {palme.VaisiuKiekis}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            palme.Prideti1MenAmziaus();
            textBox1.Text = $"amzius: {palme.Amzius}, vaisiu kiekis: {palme.VaisiuKiekis}";
        }
    }
}
