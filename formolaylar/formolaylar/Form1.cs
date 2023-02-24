namespace formolaylar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "SGK";
            this.BackColor = Color.DarkRed;

            button1.Text = "KAPAT";
            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}