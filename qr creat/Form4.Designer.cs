namespace qr_creat
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label6 = new Label();
            textBox3 = new TextBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(430, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("SimSun", 16.2F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(5, 10);
            button1.Name = "button1";
            button1.Size = new Size(190, 50);
            button1.TabIndex = 26;
            button1.Text = "LOGO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(200, 20);
            label6.Name = "label6";
            label6.Size = new Size(27, 28);
            label6.TabIndex = 25;
            label6.Text = ":";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(230, 20);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 38);
            textBox3.TabIndex = 24;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(5, 81);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(380, 106);
            richTextBox1.TabIndex = 27;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Font = new Font("SimSun", 16.2F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(40, 270);
            button2.Name = "button2";
            button2.Size = new Size(190, 50);
            button2.TabIndex = 28;
            button2.Text = "READ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(10, 360);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(400, 50);
            progressBar1.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label10.Location = new Point(10, 200);
            label10.Name = "label10";
            label10.Size = new Size(0, 26);
            label10.TabIndex = 32;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 443);
            Controls.Add(label10);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "READ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label6;
        private TextBox textBox3;
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private Button button2;
        private ProgressBar progressBar1;
        private Label label10;
    }
}