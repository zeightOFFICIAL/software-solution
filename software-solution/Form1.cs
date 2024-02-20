using System;
using System.Windows.Forms;

using software_solution.models;

namespace software_solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void loadTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                loadGridview.Rows.Add(loadTextbox.Text);
            }
        }
    }
}
