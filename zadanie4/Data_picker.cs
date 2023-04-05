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
    public partial class Data_picker : Form
    {
        public Data_picker()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void главнаяФормаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = (DateTime)dateTimePicker1.Value;
                DateTime endDate = (DateTime)dateTimePicker2.Value;

                TimeSpan ts = endDate.Subtract(startDate);

                textBox1.Text = ts.Days.ToString();
                textBox2.Text = (Convert.ToDouble(textBox1.Text) / 365).ToString();
            }
            catch
            {

            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = (DateTime)dateTimePicker1.Value;
                DateTime endDate = (DateTime)dateTimePicker2.Value;

                TimeSpan ts = endDate.Subtract(startDate);

                textBox1.Text = ts.Days.ToString();
                textBox2.Text = (Convert.ToDouble(textBox1.Text) / 365).ToString();
            }
            catch
            {

            }
        }

        private void високосныйЛиГодToolStripMenuItem_Click(object sender, EventArgs e)
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
