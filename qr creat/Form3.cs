using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;
using IronSoftware.Drawing;

namespace qr_creat
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog hacı = new OpenFileDialog();
            hacı.Filter = "png file |*.png";
            hacı.ShowDialog();
            textBox3.Text = hacı.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            textBox4.Text = fbd.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string location = textBox4.Text + "\\" + textBox1.Text;
                QRCodeLogo qrCodeLogo = new QRCodeLogo(textBox3.Text);
                GeneratedBarcode myQRCodeWithLogo = QRCodeWriter.CreateQrCodeWithLogo(textBox2.Text, qrCodeLogo);
                myQRCodeWithLogo.ResizeTo(500, 500).SetMargins(10).ChangeBarCodeColor(label9.ForeColor);
                if (radioButton1.Checked)
                {
                    myQRCodeWithLogo.SaveAsPng(location + ".png");
                    pictureBox1.Image = Image.FromFile(location + ".png");
                    progressBar1.Value = 100;
                }
                else if (radioButton2.Checked)
                {
                    myQRCodeWithLogo.SaveAsPdf(location + ".pdf");
                    myQRCodeWithLogo.SaveAsPng(location + ".png");
                    pictureBox1.Image = Image.FromFile(location + ".png");
                    progressBar1.Value = 100;
                }
                else if (radioButton3.Checked)
                {
                    myQRCodeWithLogo.SaveAsHtmlFile(location + ".html");
                    myQRCodeWithLogo.SaveAsPng(location + ".png");
                    pictureBox1.Image = Image.FromFile(location + ".png");
                    progressBar1.Value = 100;
                }
                else
                {
                    label10.Text = "You have to make your format choise";
                }
                label10.Text = "QR CREATED";
            }
            catch (IronBarCode.Exceptions.IronBarCodeEncodingException)
            {
                label10.Text = "You have to fill \n in the required values.";
            }
            catch (System.IO.IOException)
            {
                label10.Text = "creature before now";
            }
            catch (System.ArgumentException)
            {
                label10.Text = "You have to fill \n in the required values.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.FullOpen = false;
            color.ShowDialog();
            label9.Text = "Your color this";
            label9.BackColor = System.Drawing.Color.Gray;
            label9.ForeColor = color.Color;

        }
    }
}
