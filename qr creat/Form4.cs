using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;

namespace qr_creat
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog hacı = new OpenFileDialog();
            hacı.Filter = "png file |*.png";
            hacı.ShowDialog();
            textBox3.Text = hacı.FileName;
            pictureBox1.Image = Image.FromFile(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BarcodeResults result = BarcodeReader.Read(textBox3.Text, new BarcodeReaderOptions() { ExpectBarcodeTypes = BarcodeEncoding.QRCode });
                if (result != null)
                {
                    richTextBox1.Text = result.First().Value;
                }
                progressBar1.Value = 100;
            }
            catch (System.ArgumentException)
            {
                label10.Text = "You have to fill \n in the required values.";
            }
        }
    }
}
