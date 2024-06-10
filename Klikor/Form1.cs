namespace Klikor
{
    public partial class Form1 : Form
    {
        public int Money = 0;
        public bool IsClick = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Tick();
            IsClick = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(420, 346);
            pictureBox1.Location = new Point(188, 12);
            if(IsClick == true)
            {
                Money += 1;
                label1.Text = "Money: " + Money.ToString();
                IsClick = false;
            } 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Tick()
        {
            pictureBox1.Size = new Size(480, 346);
            pictureBox1.Location = new Point(158, 12);
        }
    }
}
