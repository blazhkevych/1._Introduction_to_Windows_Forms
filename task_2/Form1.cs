namespace task_2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 2. �������� ����������, � ������� ������ ������� ���������� 
        /// ������� �����, ������ � ������� ������ ����. ����������� ���������� 
        /// ���������� �������� � ��������� ����.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

        }
        int Left = 0, Right = 0, Middle = 0, Other = 0;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;

            // ����� �������� ����.
            if (e.Button == MouseButtons.Left)
            {
                Left++;
                frm.Text = $"����� �������� ����. �����: {Left}, ������: {Right}, �������: {Middle}, ������: {Other}";
            }
            else if (e.Button == MouseButtons.Right)
            {
                Right++;
                frm.Text = $"����� �������� ����. �����: {Left}, ������: {Right}, �������: {Middle}, ������: {Other}";
            }
            else if (e.Button == MouseButtons.Middle)
            {
                Middle++;
                frm.Text = $"����� �������� ����. �����: {Left}, ������: {Right}, �������: {Middle}, ������: {Other}";
            }
            else
            {
                Other++;
                frm.Text = $"����� �������� ����. �����: {Left}, ������: {Right}, �������: {Middle}, ������: {Other}";
            }
        }
    }
}