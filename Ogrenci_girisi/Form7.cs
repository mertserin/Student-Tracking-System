using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ogrenci_girisi
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UOM81GH\\SQLEXPRESS;Initial Catalog=Ogrenci;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Ogretmen where ogr_id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            textBox1.Clear();
            MessageBox.Show("Kaydınız başarıyla silinmiştir.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 fr = new Form2();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form9 fr = new Form9();
            fr.Show();
        }
    }
}
