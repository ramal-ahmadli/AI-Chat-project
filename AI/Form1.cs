namespace AI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seconds = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            var text = textBox1.Text;

            switch (text.ToLower())
            {
                case "salam":
                    label1.Text = "Salam";
                    break;
                case "sen nesen?":
                    label1.Text = "Men RO, Kicik bir AI proyektem";
                    break;
                case "hansi ozelliklerin var?":
                    label1.Text = "Helelik sadece secilmis bezi suallari cavablandira bilirem";
                    break;
                default:
                    label1.Text = "Sualin cavabi hazirda yoxdur";
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            //label1.Text = seconds.ToString();
            if (seconds >= 5)
            {
                eyelid1.Visible = true;
                eyelid2.Visible = true;

                upperLip.BackColor = Color.White;
                eyelid1.Visible = false;
            }
            if (seconds >= 7)
            {
                eyelid2.Visible = false;

                upperLip.BackColor = Color.Blue;
                lowerLip.BackColor = Color.White;
            }
            if (seconds >= 10)
            {
                eyelid1.Visible = true;
                eyelid2.Visible = true;

                upperLip.BackColor = Color.White;
                lowerLip.BackColor = Color.Blue;
            }
            if (seconds >= 12)
            {
                eyelid1.Visible = false;
                eyelid2.Visible = false;

                upperLip.BackColor = Color.Blue;
                lowerLip.BackColor = Color.White;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
--- Suallar ---
- salam
- sen nesen?
- hansi ozelliklerin var?
");
        }
    }
}
