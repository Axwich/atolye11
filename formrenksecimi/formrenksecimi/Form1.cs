namespace formrenksecimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 0, 0);
        }
        int red = 0;
        int green = 0;
        int blue = 0;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            red = trackBar1.Value;
            this.BackColor = Color.FromArgb(red, green, blue);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            green = trackBar2.Value;
            this.BackColor = Color.FromArgb(red, green, blue);
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            blue = trackBar3.Value;
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            red = rnd.Next(0, 255);
            green = rnd.Next(0, 255);
            blue = rnd.Next(0, 255);
            this.BackColor = Color.FromArgb(red, green, blue);
            trackBar1.Value = red;
            trackBar2.Value = green;
            trackBar3.Value = blue;

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            red = rnd.Next(0, 255);
            green = rnd.Next(0, 255);
            blue = rnd.Next(0, 255);
            this.BackColor = Color.FromArgb(red, green, blue);
            trackBar1.Value = red;
            trackBar2.Value = green;
            trackBar3.Value = blue;

        }
    }

}

