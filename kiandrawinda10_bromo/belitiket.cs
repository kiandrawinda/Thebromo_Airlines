using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiandrawinda10_bromo
{
    public partial class belitiket : Form
    {

        public string lia { get; set; }
        public string liIa { get; set; }
        public string liOa { get; set; }
        public string liPa { get; set; }
        public string liKa { get; set; }
        public string liRa { get; set; }
        public belitiket()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tiketsayacs obj = new tiketsayacs();
            obj.Show();
            this.Hide();
        }

        private void belitiket_Load(object sender, EventArgs e)
        {
            label4.Text = liIa;
            label5.Text = lia;
            label6.Text = liOa;
            label8.Text = liKa;
            label9.Text = liRa;
            label13.Text = liPa;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
