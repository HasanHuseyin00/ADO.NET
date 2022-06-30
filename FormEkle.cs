using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET
{
    public partial class FormEkle : Form
    {
        public FormEkle()
        {
            InitializeComponent();
            this.Text = "Ekle";
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-S6VQR0U\\SQLEXPRESS;Database=proje123;Integrated Security=True");
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string tarih = dateTimePicker1.Text;
            string tarih2 = Convert.ToString(DateTime.Now);
            string kayit = "INSERT INTO Musteri (Ad , Soyad, Tarih) VALUES (' " + ad + " ' , '" + soyad + "' , '" + tarih + "' , '" + tarih2 + "')";

            Con.Open();
            SqlCommand sc = new SqlCommand(kayit, Con);
            sc.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Eklendi");
        }
    }
}
