using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Input_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            label1.Text = f.radi;
            label2.Text = f.hei;
            label3.Text = f.den;
            checkBox1.Checked = f.x;
            checkBox2.Checked = f.x1;

        }
    }
}
