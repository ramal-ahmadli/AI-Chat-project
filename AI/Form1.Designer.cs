namespace AI
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            upperLip = new Panel();
            lowerLip = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            eyelid1 = new Panel();
            eyelid2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.eye_robot1;
            pictureBox1.Location = new Point(58, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.eye_robot1;
            pictureBox2.Location = new Point(224, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 105);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // upperLip
            // 
            upperLip.BackColor = Color.MediumBlue;
            upperLip.Location = new Point(140, 209);
            upperLip.Name = "upperLip";
            upperLip.Size = new Size(109, 15);
            upperLip.TabIndex = 2;
            // 
            // lowerLip
            // 
            lowerLip.BackColor = Color.MediumBlue;
            lowerLip.Location = new Point(161, 232);
            lowerLip.Name = "lowerLip";
            lowerLip.Size = new Size(65, 15);
            lowerLip.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(30, 318);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 29);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(268, 318);
            button1.Name = "button1";
            button1.Size = new Size(87, 29);
            button1.TabIndex = 5;
            button1.Text = "Ask";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 359);
            label1.Name = "label1";
            label1.Size = new Size(13, 17);
            label1.TabIndex = 6;
            label1.Text = "_";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.information_icon;
            pictureBox3.Location = new Point(336, 273);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // eyelid1
            // 
            eyelid1.Location = new Point(15, 19);
            eyelid1.Name = "eyelid1";
            eyelid1.Size = new Size(354, 59);
            eyelid1.TabIndex = 8;
            eyelid1.Visible = false;
            // 
            // eyelid2
            // 
            eyelid2.Location = new Point(15, 80);
            eyelid2.Name = "eyelid2";
            eyelid2.Size = new Size(354, 59);
            eyelid2.TabIndex = 9;
            eyelid2.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(385, 399);
            Controls.Add(eyelid2);
            Controls.Add(eyelid1);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lowerLip);
            Controls.Add(upperLip);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel upperLip;
        private Panel lowerLip;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel eyelid1;
        private Panel eyelid2;
        private System.Windows.Forms.Timer timer1;
    }
}
