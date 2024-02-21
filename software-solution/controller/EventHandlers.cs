using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using software_solution.models;
using software_solution.controller;

namespace software_solution
{
    partial class Form1 : Form
    {
        private void loadTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string plainText = loadTextbox.Text;
                var list = Parser.Parse(plainText);
                Console.WriteLine(list.ToString());
            }
        }
    }
}
