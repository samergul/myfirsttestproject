using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfirsttestproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
            textBox1.Text = "hello";
            DialogResult dr = MessageBox.Show("Are you happy now?",
                      "Mood Test", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes: break;
                case DialogResult.No: break;
            }
        }
    }
}
