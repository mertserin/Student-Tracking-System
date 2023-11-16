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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 fr = new Form2();
            fr.Show();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UOM81GH\\SQLEXPRESS;Initial Catalog=Ogrenci;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Kayit where No=@numara", baglanti);
            komut.Parameters.AddWithValue("@numara", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            textBox1.Clear();
            MessageBox.Show("Kaydınız başarıyla silinmiştir.");
        }
    }
}
