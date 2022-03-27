using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lessson_8_sd2_4
{
    internal struct Forest
    {
        public List<int> Trees;

        public Forest(List<int> trees)
        {
            Trees = trees;
        }

        public void PlantATree(TextBox textBox)
        {
            Trees = new List<int>(); // vis nauja sukuria
            //textBox.Text = "";
            Trees.Add(1);
            for (int i = 0; i < Trees.Count; i++)
            {
                textBox.Text += $"{i} : {Trees[i]}; ";
            }
        }

        public void ShowAllTrees(TextBox textBox)
        {
            textBox.Text = "";

            if (Trees.Count == 0) // null?
            {
                textBox.Text = "miske dar nera medziu";
                return;
            }

            for (int i = 0; i < Trees.Count; i++)
            {
                textBox.Text += $"{i} : {Trees[i]}\r\n";
            }
        }
    }
}
