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
    public partial class masterjadwalpenerbangan : Form
    {
        public masterjadwalpenerbangan()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aku = textBox2.Text;
            string ma = comboBox2.Text;
            string kan = comboBox1.Text;
            string walker = comboBox3.Text;
            string leaah = dateTimePicker1.Text;
            string cla = textBox1.Text;
            string claa = textBox3.Text;
            string clau = numericUpDown1.Text;
            
            dataGridView1.Rows.Add(aku, ma, kan, walker, leaah, cla, claa, clau);
        }

        private void masterjadwalpenerbangan_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("ID-7518", "Juanda", "Halim Perdanakusumah", "Batik Airlines", "30-05-2024", "19:55", "01 jam 15 menit", "829891");
            dataGridView1.Rows.Add("IP-0203", "Juanda", "Soekarno-Hatta", "Pelita Airlines", "30-05-2024", "19:50", "01 jam 30 menit", "684000");
            dataGridView1.Rows.Add("QG-0719", "Juanda", "Soekarno-Hatta", "Citilink", "30-05-2023", "19:30", "01 jam 10 menit", "1317538");
            dataGridView1.Rows.Add("QG-0173", "Juanda", "Halim Perdanakusuma", "Citilink", "30-05-2023", "19:00", "01 jam 20 menit", "772601");
            dataGridView1.Rows.Add("GA-0325", "Juanda", "Soekarno - Hatta", "Garuda Indonesia", "30 - 05 - 2023", "18:40", "01 jam 30 menit", "1536880");
            dataGridView1.Rows.Add("OG-0737", "Juanda", "Soekarno-Hatta", "Citilink", "30-05-2024", "18:40", "01 jam 10 menit", "1317538");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Ubah")
            {
                belitiket obj = new belitiket();
                obj.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            masterbandara obj = new masterbandara();
            obj.Show();
            this.Hide();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            mastermaskapai obj = new mastermaskapai();
            obj.Show();
            this.Hide();
        }

        private void masterJadwalPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            masterjadwalpenerbangan obj = new masterjadwalpenerbangan();
            obj.Show();
            this.Hide();
        }

        private void masterKodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kodepromo obj = new kodepromo();
            obj.Show();
            this.Hide();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ubahstatus2 obj = new ubahstatus2();
            obj.Show();
            this.Hide();
        }
    }
    }

