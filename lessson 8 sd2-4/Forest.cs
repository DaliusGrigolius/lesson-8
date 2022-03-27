using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lessson_8_sd2_4
{
    internal class Forest
    {
        public List<int> Trees;

        public Forest()
        {
            Trees = new List<int>();           
        }

        public void PlantATree(TextBox textBox)
        {
            Trees.Add(1);
            textBox.Text += "New Tree has been planted succesfully!\r\n";
        }

        public void ShowAllTrees(TextBox textBox)
        {
            textBox.Text = $"{Trees.Count}";

            if (Trees.Count == 0) // null?
            {
                textBox.Text = "miske dar nera medziu";
                //return;
            }

            //for (int i = 0; i < Trees.Count; i++)
            //{
            //    textBox.Text += $"{i} : {Trees[i]}; ";
            //}
        }
    }
}
