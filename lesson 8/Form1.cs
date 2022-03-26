using _8_lesson_8.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Saskaita saskaita = new Saskaita("gavejas1", "siuntejas1", 10);

            textBox1.Text = $"{saskaita.SaskaitosNumeris}, {saskaita.Gavejas}, {saskaita.Siuntejas}, {saskaita.MoketiViso}";
        }
    }
}
