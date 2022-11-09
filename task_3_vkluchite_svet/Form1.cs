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
            int step = 100;

            // ����������� ���� Form1 �� ��������� ������, �� ������� �������.
            if (this.Location.X < Screen.PrimaryScreen.Bounds.Width - this.Width &&
                this.Location.Y == 0)
            {
                if ((this.Location.X + step + 300) < Screen.PrimaryScreen.Bounds.Width) // ���� ��� �� ��������� ������ ������
                    this.Location = new Point(this.Location.X + step, this.Location.Y);
                else
                    this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, this.Location.Y);
            }


        }
    }
}