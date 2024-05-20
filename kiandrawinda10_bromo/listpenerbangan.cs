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
    public partial class listpenerbangan : Form
    {
        public string clau {  get; set; }
        public string clauu { get; set; }
        public string clia { get; set; }
        public string cliau { get; set; }

        public listpenerbangan()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column8")
            {
                belitiket obj = new belitiket();
                obj.lia = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                obj.liIa = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                obj.liOa = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                obj.liPa = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                obj.liKa = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                obj.liRa = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                obj.Show();
                this.Hide();
            }
        }

        private void listpenerbangan_Load(object sender, EventArgs e)
        {
            label2.Text = clau;
            label3.Text = clauu;
            label5.Text = clia;
            label4.Text = cliau;



            dataGridView1.Rows.Add(" IP - 0209", "Pelita Air", "Juanda", "Soekarno Hatta", "634000", "24-05-2023", "15:10 - 16:45");
            dataGridView1.Rows.Add(" IP - 0298", "garuda indonesia", "Juanda", "Soekarno Hatta", "634000", "24-05-2023", "19:10 - 21:45");
            dataGridView1.Rows.Add(" IP - 0309", "lion Air", "Juanda", "Soekarno Hatta", "726000", "24-05-2023", "06:00 - 10:45");
            dataGridView1.Rows.Add(" IP - 0298", "citilink", "Juanda", "Soekarno Hatta", "725000", "24-05-2023", "17:10 - 19:40");
            dataGridView1.Rows.Add(" IP - 0099", "Pelita Air", "Juanda", "Soekarno Hatta", "634000", "24-05-2023", "15:10 - 17:45");
            dataGridView1.Rows.Add(" IP - 0749", "transnusa", "Juanda", "Soekarno Hatta", "725000", "24-05-2023", "10:10 - 11:45");
            dataGridView1.Rows.Add(" IP - 0276", "air asia", "Juanda", "Soekarno Hatta", "634000", "24-05-2023", "08:10 - 09:00");
            dataGridView1.Rows.Add(" IP - 0709", "garuda indonesia", "Juanda", "Soekarno Hatta", "634000", "24-05-2023", "20:46 - 121:55");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            customer obj = new customer();
            obj.Show();
            this.Hide();
        }
    }
}
