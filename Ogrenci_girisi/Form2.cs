using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_girisi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void kayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 fr = new Form3();
            fr.Show();            
        }

        private void kayıtBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 fr = new Form4();
            fr.Show();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrenciDataSet.Kayit' table. You can move, or remove it, as needed.
            this.kayitTableAdapter.Fill(this.ogrenciDataSet.Kayit);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kayıtSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 fr = new Form5();
            fr.Show();
        }

        private void öğretmenEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 fr = new Form6();
            fr.Show();
        }

        private void öğretmenSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 fr = new Form7();
            fr.Show();
        }

        private void öğretmenBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 fr = new Form8();
            fr.Show();
        }

        private void raporOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 fr = new Form10();
            fr.Show();
        }

        private void raporOluşturToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 fr = new Form11();
            fr.Show();
        }
    }
}
