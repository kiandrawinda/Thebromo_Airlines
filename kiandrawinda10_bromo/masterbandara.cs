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
    public partial class masterbandara : Form
    {
        public masterbandara()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void masterbandara_Load(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add("Abdul Rachman Saleh", "MLG", "Malang", "Indonesia", "2", "Malang");
            dataGridView1.Rows.Add("Abresso", "RSK", "Manokwari", "Indonesia", "2", "Manokwari");
            dataGridView1.Rows.Add("Achmad Yani", "SRG", "Semarang", "Indonesia", "2", "Semarang");
            dataGridView1.Rows.Add("Adi Sucipto", "JOG", "Yogyakarta", "Indonesia", "2", "Yogyakarta");
            dataGridView1.Rows.Add("Adisumarmo", "SOC", "Solo", "Indonesia", "2", "Solo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aku = textBox1.Text;
            string ma = textBox2.Text;
            string kan = textBox3.Text;
            string walker = comboBox1.Text;
            string clau = numericUpDown1.Text;
            string leaah = numericUpDown1.Text;

            dataGridView1.Rows.Add(aku, ma, kan, walker, clau, leaah);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            numericUpDown1.Text = "";
            numericUpDown1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            numericUpDown1.Text = "";
            numericUpDown1.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column7")
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                numericUpDown1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                numericUpDown1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column8")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
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
