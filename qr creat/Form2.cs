using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;

namespace qr_creat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            textBox3.Text = fbd.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string dayı = textBox3.Text + "\\" + textBox1.Text ;
                if (radioButton1.Checked)
                {
                    QRCodeWriter.CreateQrCode(textBox2.Text, 500, QRCodeWriter.QrErrorCorrectionLevel.Medium).SaveAsPng(dayı + ".png");
                    pictureBox1.Image = Image.FromFile(dayı + ".png");
                    label3.Text = "QR CREATED";
                    progressBar1.Value = 100;
                }
                else if (radioButton2.Checked)
                {
                    QRCodeWriter.CreateQrCode(textBox2.Text, 500, QRCodeWriter.QrErrorCorrectionLevel.Medium).SaveAsPng(dayı + ".png").SaveAsPdf(dayı + ".pdf");
                    pictureBox1.Image = Image.FromFile(dayı + ".png");
                    label3.Text = "QR CREATED";
                    progressBar1.Value = 100;
                }
                else if (radioButton3.Checked)
                {
                    QRCodeWriter.CreateQrCode(textBox2.Text, 500, QRCodeWriter.QrErrorCorrectionLevel.Medium).SaveAsPng(dayı + ".png").SaveAsHtmlFile(dayı + ".html");
                    pictureBox1.Image = Image.FromFile(dayı + ".png");
                    label3.Text = "QR CREATED";
                    progressBar1.Value = 100;
                }
                else
                {
                    label3.Text = "You have to make \n your format choise";
                }
                
            }
            catch (IronBarCode.Exceptions.IronBarCodeEncodingException) 
            {
                label3.Text = "You have to fill \n in the required values.";
            }
            catch(System.IO.IOException)
            {
                label3.Text = "creature before now";
            }
            catch (System.ArgumentException)
            {
                label3.Text = "You have to fill \n in the required values.";
            }
        }
    }
}