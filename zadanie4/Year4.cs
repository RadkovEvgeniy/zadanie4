using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie4
{
    public partial class Year4 : Form
    {
        public Year4()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n, t;
            n = int.Parse(textBox1.Text);
            t = (n % 4);
            if (t == 0)
            {
                textBox2.Text = "Год високосный";
            }

            else
            { 
                textBox2.Text = "Год не високосный";
            }
        }

        private void разницаДатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_picker dp = new Data_picker();
            this.Hide();
            dp.ShowDialog();
        }

        private void времяСутокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Time_of tf = new Time_of();
            this.Hide();
            tf.ShowDialog();
        }

        private void главнаяФормаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }
    }
}
