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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void разницаДатToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Data_picker dp = new Data_picker();
            this.Hide();
            dp.ShowDialog();
        }

        private void високосныйЛиГодToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Year4 y4 = new Year4();
            this.Hide();
            y4.ShowDialog();
        }

        private void времяСутокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Time_of tf = new Time_of();
            this.Hide();
            tf.ShowDialog();
        }
    }
}
