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
    public partial class FormGoruntule : Form
    {
        public FormGoruntule()
        {
            InitializeComponent();
            this.Text = "Görüntüle";
            btnListele.PerformClick();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-S6VQR0U\\SQLEXPRESS;Database=proje123;Integrated Security=True");
        private void btnListele_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Musteri", Con);
            DataTable tablo = new DataTable();
            sda.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Con.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Musteri where Ad like'%" + textBox1.Text + "%'", Con);
            DataTable tablo = new DataTable();
            sda.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Con.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgw in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(dgw.Cells[0].Value);
                string kayit = "DELETE FROM Musteri WHERE MusteriID='" + dgw.Cells[0].Value + "'";
                Con.Open();
                SqlCommand sc = new SqlCommand(kayit, Con);
                sc.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter("select * from Musteri", Con);
                DataTable tablo = new DataTable();
                sda.Fill(tablo);
                dataGridView1.DataSource = tablo;
                Con.Close();
                MessageBox.Show("ok");
            }
        }
    }
}
