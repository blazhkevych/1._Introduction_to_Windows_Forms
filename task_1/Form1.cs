using Microsoft.VisualBasic;

namespace task_1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 1. Написать приложение, которое «угадывает» задуманное 
        /// пользователем число от 1 до 100. Для запроса к пользователю 
        /// использовать окна сообщений. После того, как число отгадано, необходимо 
        /// вывести количество попыток, потребовавшихся для этого, и предоставить 
        /// пользователю возможность сыграть еще раз, не завершая программу. Окна 
        /// сообщений следует оформить кнопками и иконками в соответствии с 
        /// конкретной ситуацией.
        /// </summary>

        public Form1()
        {
            InitializeComponent();
            
            DialogResult playMore;
            do
            {
                MessageBox.Show(
                    "Загадайте число от 1 до 100, а я попробую его угадать (отмена - я угадал Ваше число).",
                    "Игра \"Угадай число.\"");

                int left = 0, right = 100, iteration = 0;
                int N = right;

                do
                {
                    N = (left + right) / 2; // Средина между двумя числами.
                    DialogResult result = MessageBox.Show(
                        "\nВаше число < " + N + " ? " + "(выберите \"нет\" для продолжения поиска.)" +
                        "\nВаше число == " + N + " ? " + "(выберите \"отмена\" Я угадал Ваше число !)" +
                        "\nВаше число > " + N + " ? " + "(выберите \"да\" для продолжения поиска.)",
                        "Игра \"Угадай число.\"",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    iteration++;

                    if (result == DialogResult.No) // Если пользователь выбрал меньше.
                        right = N - 1;
                    else if (result == DialogResult.Cancel) // Если пользователь выбрал равно.
                    {
                        MessageBox.Show(
                            "Я угадал Ваше число за " + iteration + " попыток.",
                            "Игра \"Угадай число.\"",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    else if (result == DialogResult.Yes) // Если пользователь выбрал больше.
                        left = N + 1;

                } while (true);

                playMore = MessageBox.Show(
                   "Хотите сыграть еще ?",
                   "Игра \"Угадай число.\"",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            } while (playMore == DialogResult.Yes);
        }
    }
}