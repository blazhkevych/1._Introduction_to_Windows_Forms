namespace task_3_vkluchite_svet
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 3. Написать приложение, обладающее следующей 
        /// функциональностью: 
        /// * при нажатии клавиши Enter главное окно позиционируется в 
        /// левый верхний угол экрана с размерами (300х300) и начинает 
        /// перемещаться по периметру экрана с определённой скоростью;
        /// * при нажатии клавиши Esc перемещение окна прекращается
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.Location = new Point(0, 0);
                this.Size = new Size(300, 300);
                this.BackColor = Color.Red;
                this.TopMost = true;
                timer1.Start();
            }
            if (e.KeyChar == (char)Keys.Escape)
                timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
            int step = 10;

            // Перемещение окна Form1 по периметру экрана, по часовой стрелке.
            if (this.Location.X < Screen.PrimaryScreen.Bounds.Width - this.Width && this.Location.Y == 0)
            {
                if ((this.Location.X + step + 300) < Screen.PrimaryScreen.Bounds.Width)     // Если шаг не превышает ширину экрана.
                    this.Location = new Point(this.Location.X + step, this.Location.Y);
                else                                                                        // Если шаг превышает ширину экрана.
                    this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, this.Location.Y);
            }
            else if (this.Location.X == Screen.PrimaryScreen.Bounds.Width - this.Width && this.Location.Y < Screen.PrimaryScreen.Bounds.Height - this.Height)
            {
                if ((this.Location.Y + step + 300) < Screen.PrimaryScreen.Bounds.Height)    // Если шаг не превышает высоту экрана.
                    this.Location = new Point(this.Location.X, this.Location.Y + step);
                else                                                                        // Если шаг превышает высоту экрана.
                    this.Location = new Point(this.Location.X, Screen.PrimaryScreen.Bounds.Height - this.Height);
            }
            else if (this.Location.X > 0 && this.Location.Y == Screen.PrimaryScreen.Bounds.Height - this.Height)
            {
                if ((this.Location.X - step) > 0)                                           // Если шаг не превышает ширину экрана.
                    this.Location = new Point(this.Location.X - step, this.Location.Y);
                else                                                                        // Если шаг превышает ширину экрана.
                    this.Location = new Point(0, this.Location.Y);
            }
            else if (this.Location.X == 0 && this.Location.Y > 0)
            {
                if ((this.Location.Y - step) > 0)                                           // Если шаг не превышает высоту экрана.
                    this.Location = new Point(this.Location.X, this.Location.Y - step);
                else                                                                        // Если шаг превышает высоту экрана.
                    this.Location = new Point(this.Location.X, 0);
            }
        }
    }
}