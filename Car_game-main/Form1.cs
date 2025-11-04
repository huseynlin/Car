namespace Car_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            if (!isBackPressed)
            {
                timer1.Start();
                isForwardPressed = true;
            }
        }

        int speed = 0;
        bool isForwardPressed = false, isBackPressed = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (car.Top < -200)
            {
                car.Top = -200;
            }
            else
            {
                speed++;
                car.Top -= speed;
            }
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (car.Left - 20 < 0)
            {
                car.Left = 0;
            }
            else
            {
                car.Left -= 20;
            }
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (car.Left + 20 > 399)
            {
                car.Left = 399;
            }
            else
            {
                car.Left += 20;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (!isForwardPressed)
            {
                timer2.Start();
                isBackPressed = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (car.Top > 671)
            {
                car.Top = 671;
            }
            else
            {
                speed++;
                car.Top += speed;
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            speed = 0;
            timer1.Stop();
            timer2.Stop();
            isForwardPressed = false;
            isBackPressed = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
