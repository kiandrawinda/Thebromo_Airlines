using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiandrawinda10_bromo
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            tiketsayacs obj = new tiketsayacs();
            obj.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listpenerbangan obj = new listpenerbangan();
            obj.clau = comboBox1.Text;
            obj.clauu = comboBox2.Text;
            obj.clia = dateTimePicker1.Text;
            obj.cliau = numericUpDown1.Text;


            obj.Show();
            this.Hide();
        }
    }
}
