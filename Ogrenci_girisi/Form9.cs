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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrenciDataSet4.Ogretmen' table. You can move, or remove it, as needed.
            this.ogretmenTableAdapter.Fill(this.ogrenciDataSet4.Ogretmen);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 fr = new Form6();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 fr = new Form7();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 fr = new Form8();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 fr = new Form2();
            fr.Show();
        }
    }
}
