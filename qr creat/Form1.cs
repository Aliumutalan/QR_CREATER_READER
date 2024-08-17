namespace qr_creat
{
    public partial class QR : Form
    {
        public QR()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 standar = new Form2();
            standar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 standar = new Form3();
            standar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 standar = new Form4();
            standar.Show();
            this.Hide();
        }
    }
}
