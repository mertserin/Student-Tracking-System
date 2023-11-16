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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UOM81GH\\SQLEXPRESS;Initial Catalog=Ogrenci;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Kayit where Sinif like '%" + textBox1.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CrystalReport1 rapor = new CrystalReport1();
            rapor.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Kayit", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CrystalReport1 rapor = new CrystalReport1();
            rapor.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rapor;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Kayit where No like '%" + textBox1.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CrystalReport1 rapor = new CrystalReport1();
            rapor.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Kayit where Ad_Soyad like '%"+textBox1.Text+"%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CrystalReport1 rapor = new CrystalReport1();
            rapor.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Kayit where Adres like '%" + textBox1.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CrystalReport1 rapor = new CrystalReport1();
            rapor.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 fr = new Form2();
            fr.Show();
        }
    }
}
