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
        public double R;
        public double H;
        public double D;
        public double V;
        public double M;
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
            R = int.Parse(label1.Text);
            H = int.Parse(label2.Text);
            D = int.Parse(label3.Text);
            V = 3.14 * R*R*H;
            M = ((3.14 * ((R * 2) * (R * 2)) * H) / 4000) * D;
        }

        private void Work_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (checkBox2.Checked == true)
                {
                    MessageBox.Show("Объем "+V+"\nМасса "+M);
                }
                else
                {
                    MessageBox.Show("Объем "+V);
                }
            }
            else
            {
                if (checkBox2.Checked == true)
                {
                    MessageBox.Show("Масса "+M);
                }
                else
                {
                    MessageBox.Show("Не выбрано");
                }

            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
