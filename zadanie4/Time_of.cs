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
    public partial class Time_of : Form
    {
        public Time_of()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(textBox1.Text);

            if (time >= 0 && time <= 3)
            {
                textBox2.Text = "Сейчас ночь!";
            }
            if (time >= 4 && time <= 11)
            {
                textBox2.Text = "Сейчас утро!";
            }
            if (time >= 12 && time <= 17)
            {
                textBox2.Text = "Сейчас день!";
            }
            if (time >= 18 && time <= 23)
            {
                textBox2.Text = "Сейчас вечер!";
            }
        }

        private void разницаДатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_picker dp = new Data_picker();
            this.Hide();
            dp.ShowDialog();
        }

        private void високосныйЛиГодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Year4 y4 = new Year4();
            this.Hide();
            y4.ShowDialog();
        }

        private void главнаяФормаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
