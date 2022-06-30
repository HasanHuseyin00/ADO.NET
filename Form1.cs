namespace ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "ADO.NET";
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            FormGoruntule frm = new FormGoruntule();
            frm.Show();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FormEkle frm = new FormEkle();
            frm.Show();
        }
    }
}