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
    public partial class kodepromo : Form
    {
        public kodepromo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string aku = textBox1.Text;
            string ma = dateTimePicker1.Text;

            string walker = numericUpDown2.Text;
            string walkerr = numericUpDown3.Text;

            string leaah = textBox4.Text;

            dataGridView1.Rows.Add(aku, ma, walker, walkerr, leaah);
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

        private void kodepromo_Load(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add("BROMOAJAYUK", "15", "100000", "09 - 09 - 2023", "Yuk pakai diskon disinii");
            dataGridView1.Rows.Add("NAIKBROMOAIRLINES", "10", "100000", "09 - 09 - 2023", "Bromo Ailines");
        }
    }
}
