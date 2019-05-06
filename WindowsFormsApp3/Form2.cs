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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string radi
        {
            get
            {
                return textBox1.Text;
            }
        }
        public string hei
        {
            get
            {
                return textBox2.Text;
            }
        }
        public string den
        {
            get
            {
                return textBox3.Text;
            }
        }
        public bool x
        {
            get
            {
                return Volume.Checked;
            }
        }
        public bool x1
        {
            get
            {
                return Mass.Checked;
            }
        }


        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
