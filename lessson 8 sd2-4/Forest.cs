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
        public List<int> trees;

        public Forest(List<int> trees)
        {
            this.trees = trees;           
        }

        public void PlantATree()
        {
            trees.Add(1);
        }

        public void ShowAllTrees(TextBox textBox)
        {
            textBox.Text = $"viso: {trees.Count}\r\n";

            if (trees.Count == 0)
            {
                textBox.Text = "miske dar nera medziu";
                return;
            }

            for (int i = 0; i < trees.Count; i++)
            {
                textBox.Text += $"Medis{i}: {trees[i]}; ";
            }
        }
    }
}
