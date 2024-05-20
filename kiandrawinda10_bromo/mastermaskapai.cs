using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kiandrawinda10_bromo
{
    public partial class mastermaskapai : Form
    {
        public mastermaskapai()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aku = textBox1.Text;
            string ma = textBox2.Text;

            string walker = numericUpDown1.Text;

            string leaah = textBox4.Text;

            dataGridView1.Rows.Add(aku, ma, walker, leaah);
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Text = "";
            textBox4.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    

            private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Text = "";
            textBox4.Text = "";
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

        private void mastermaskapai_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Adam Air", "PT Adam Air", "16", "Adam Air adalah salah satu di antara perusahaan penerbangan yang ada di Indonesia dan menerapkan Low Cost Carrier, Perusahaan bernama lengkap Adam SkyConnection Airlines ini didirikan pada tanggal 22 November 2002 oleh didirikan oleh Agung Laksono dan Sandra Ang");
            dataGridView1.Rows.Add("Aviastar", "PT Aviastar", "12", "Aviastar adalah maskapai penerbangan domestik berjadwal yang berbasis di Jakarta Timur, Jakarta, Indonesia.");
            dataGridView1.Rows.Add("Batavia Air", "PT Batavia Air", "6", "Batavia Air, adalah sebuah maskapai penerbangan di Indonesia. Batavia Air mulai beroperasi pada tanggal 5 Januari 2002, memulai dengan satu buah pesawat Fokker F28 dan dua buah Boeing 737-200.");
            dataGridView1.Rows.Add("Batik Air", "PT Batik Air", "17", "Batik Air adalah maskapai purlayanan swasta Indonesia yang didirikan pada tahun 2013. Maskapai ini merupakan anak perusahaan Lion Air yang berlayanan penuh. Penerbangan perdana dilaksanakan pada hari Jumat, 3 Mei 2013 dari Jakarta ke Manado dan Balikpapan");
            dataGridView1.Rows.Add("Bouraq Indonesia", "PT Bouraq Indonesia", "19", "Bouraq Indonesia Airlines sering disingkat menjadi Bouraq Airlines atau hanya Bouraq adalah maskapai penerbangan swasta Indonesia yang pernah beroperasi.");
        }
    }
}
