namespace task_3
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 3. Ќаписать приложение, обладающее следующей 
        /// функциональностью: 
        /// * при нажатии клавиши Enter главное окно позиционируетс€ в 
        /// левый верхний угол экрана с размерами (300х300) и начинает 
        /// перемещатьс€ по периметру экрана с определЄнной скоростью;
        /// * при нажатии клавиши Esc перемещение окна прекращаетс€.
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

                // ѕолучаем разрешение экрана.
                int screenWidth = Screen.PrimaryScreen.Bounds.Width;
                int screenHeight = Screen.PrimaryScreen.Bounds.Height;
                //while (e.KeyChar !=(char)Keys.Escape)
                //{
                // ѕеремещение окна Form1 по периметру экрана.
                while (this.Location.Y < Screen.PrimaryScreen.Bounds.Height - this.Height)
                {
                    this.Location = new Point(this.Location.X, this.Location.Y + 10);
                    Thread.Sleep(1);
                }
                while (this.Location.X < Screen.PrimaryScreen.Bounds.Width - this.Width)
                {
                    this.Location = new Point(this.Location.X + 10, this.Location.Y);
                    Thread.Sleep(1);
                }
                while (this.Location.Y > 0)
                {
                    this.Location = new Point(this.Location.X, this.Location.Y - 10);
                    Thread.Sleep(1);
                }
                while (this.Location.X > 0)
                {
                    this.Location = new Point(this.Location.X - 10, this.Location.Y);
                    Thread.Sleep(1);
                }
                //}
                //this.KeyPreview = true;

                // ¬ыполн€ть пока не будет нажата клавиша Esc



            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }

        }
    }
}