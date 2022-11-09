namespace task_2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 2. Написать приложение, в котором ведётся подсчёт количества 
        /// «кликов» левой, правой и средней кнопки мыши. Обновляемую статистику 
        /// необходимо выводить в заголовок окна.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

        }
        int Left = 0, Right = 0, Middle = 0, Other = 0;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;

            // Клики кнопками мишы.
            if (e.Button == MouseButtons.Left)
            {
                Left++;
                frm.Text = $"Клики кнопками мишы. Левая: {Left}, Правая: {Right}, Средняя: {Middle}, Другая: {Other}";
            }
            else if (e.Button == MouseButtons.Right)
            {
                Right++;
                frm.Text = $"Клики кнопками мишы. Левая: {Left}, Правая: {Right}, Средняя: {Middle}, Другая: {Other}";
            }
            else if (e.Button == MouseButtons.Middle)
            {
                Middle++;
                frm.Text = $"Клики кнопками мишы. Левая: {Left}, Правая: {Right}, Средняя: {Middle}, Другая: {Other}";
            }
            else
            {
                Other++;
                frm.Text = $"Клики кнопками мишы. Левая: {Left}, Правая: {Right}, Средняя: {Middle}, Другая: {Other}";
            }
        }
    }
}