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
    public partial class tiketsayacs : Form
    {
        public tiketsayacs()
        {
            InitializeComponent();
        }

        private void tiketsayacs_Load(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(" IP - 0203", "Pelita Air Service", "Juanda", "Soekarno Hatta", "22 - 05 - 2023", "19:50 - 21:25", "Delay selama +- 1 jam");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listpenerbangan obj = new listpenerbangan();
            obj.Show();
            this.Hide();
        }
    }
}
