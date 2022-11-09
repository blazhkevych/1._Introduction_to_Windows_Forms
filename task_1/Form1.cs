using Microsoft.VisualBasic;

namespace task_1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 1. �������� ����������, ������� ���������� ���������� 
        /// ������������� ����� �� 1 �� 100. ��� ������� � ������������ 
        /// ������������ ���� ���������. ����� ����, ��� ����� ��������, ���������� 
        /// ������� ���������� �������, ��������������� ��� �����, � ������������ 
        /// ������������ ����������� ������� ��� ���, �� �������� ���������. ���� 
        /// ��������� ������� �������� �������� � �������� � ������������ � 
        /// ���������� ���������.
        /// </summary>

        public Form1()
        {
            InitializeComponent();
            
            DialogResult playMore;
            do
            {
                MessageBox.Show(
                    "��������� ����� �� 1 �� 100, � � �������� ��� ������� (������ - � ������ ���� �����).",
                    "���� \"������ �����.\"");

                int left = 0, right = 100, iteration = 0;
                int N = right;

                do
                {
                    N = (left + right) / 2; // ������� ����� ����� �������.
                    DialogResult result = MessageBox.Show(
                        "\n���� ����� < " + N + " ? " + "(�������� \"���\" ��� ����������� ������.)" +
                        "\n���� ����� == " + N + " ? " + "(�������� \"������\" � ������ ���� ����� !)" +
                        "\n���� ����� > " + N + " ? " + "(�������� \"��\" ��� ����������� ������.)",
                        "���� \"������ �����.\"",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    iteration++;

                    if (result == DialogResult.No) // ���� ������������ ������ ������.
                        right = N - 1;
                    else if (result == DialogResult.Cancel) // ���� ������������ ������ �����.
                    {
                        MessageBox.Show(
                            "� ������ ���� ����� �� " + iteration + " �������.",
                            "���� \"������ �����.\"",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    else if (result == DialogResult.Yes) // ���� ������������ ������ ������.
                        left = N + 1;

                } while (true);

                playMore = MessageBox.Show(
                   "������ ������� ��� ?",
                   "���� \"������ �����.\"",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            } while (playMore == DialogResult.Yes);
        }
    }
}