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
    public partial class ubahstatus : Form
    {
        public ubahstatus()
        {
            InitializeComponent();
        }

        private void ubahstatus_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("IU - 0696", "Super Airlines", "Soekarno - Hatta", "Supadio", "21 - 04 - 2024", "07:25", "01 jam 30 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("IU - 0697", "Super Airlines", "Supadio", "Soekarno - Hatta", "27 - 04 - 2024", "09:40", "01 jam 20 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("ID - 7508", "Batik Airlines", "Juanda", "Halim Perdanakusumah", "22 - 05 - 2024", "05:00", "01 jam 10 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("ID - 6589", "Batik Airlines", "Juanda", "Soekarno - Hatta", "22 - 05 - 2024", "05:00", "01 jam 20 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("JT - 0786", "Lion Airlines", "Juanda", "Soekarno - Hatta", "22 - 05 - 2024", "05:00", "01 jam 30 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("JT-0646", "Lion Airlines", "Juanda", "Soekarno-Hatta", "22-05-2024", "05:55", "01 jam 05 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("QG - 0725", "Citilink", "Juanda", "Soekarno - Hatta", "22 - 05 - 2024", "06:00", "01 jam 35 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("IU - 0706", "Super Airlines", "Juanda", "Soekarno - Hatta", "22 - 05 - 2024", "06:00", "00 jam 45 menit", "Sesuai Jadwal", "-");
            dataGridView1.Rows.Add("IU - 0333", "Super Airlines", "Juanda", "Soekarno - Hatta", "22 - 05 - 2024", "06:00", "01 jam 25 menit", "Sesuai Jadwal", "-");

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
            ubahstatus obj = new ubahstatus();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
    }

