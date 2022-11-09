namespace task_3_vkluchite_svet
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 3. �������� ����������, ���������� ��������� 
        /// �����������������: 
        /// * ��� ������� ������� Enter ������� ���� ��������������� � 
        /// ����� ������� ���� ������ � ��������� (300�300) � �������� 
        /// ������������ �� ��������� ������ � ����������� ���������;
        /// * ��� ������� ������� Esc ����������� ���� ������������
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                timer1.Start();
            }
            if (e.KeyChar == (char)Keys.Escape)
                timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();

            this.Location = new Point(0, 0);
            this.Size = new Size(300, 300);
            this.BackColor = Color.Red;
            this.TopMost = true;

            // ����������� ���� Form1 �� ��������� ������, �� ������� �������.
            while (this.Location.X < Screen.PrimaryScreen.Bounds.Width - this.Width)
            {
                this.Location = new Point(this.Location.X + 10, this.Location.Y);
                Thread.Sleep(1);
            }
            while (this.Location.Y < Screen.PrimaryScreen.Bounds.Height - this.Height)
            {
                this.Location = new Point(this.Location.X, this.Location.Y + 10);
                Thread.Sleep(1);
            }
            while (this.Location.X > 0)
            {
                this.Location = new Point(this.Location.X - 10, this.Location.Y);
                Thread.Sleep(1);
            }
            while (this.Location.Y > 0)
            {
                this.Location = new Point(this.Location.X, this.Location.Y - 10);
                Thread.Sleep(1);
            }
        }
    }
}