namespace qr_creat
{
    partial class QR
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 10);
            label1.Name = "label1";
            label1.Size = new Size(184, 40);
            label1.TabIndex = 0;
            label1.Text = "QR creater";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(90, 70);
            button1.Name = "button1";
            button1.Size = new Size(200, 60);
            button1.TabIndex = 1;
            button1.Text = "STANDART QR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button2.Location = new Point(90, 140);
            button2.Name = "button2";
            button2.Size = new Size(200, 60);
            button2.TabIndex = 2;
            button2.Text = "LOGO QR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button3.Location = new Point(90, 210);
            button3.Name = "button3";
            button3.Size = new Size(200, 60);
            button3.TabIndex = 3;
            button3.Text = "READ QR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // QR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 453);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QR";
            Text = "MENU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
