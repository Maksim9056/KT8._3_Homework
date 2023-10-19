namespace KT8._3_Homework
{
    class Program
    {
        /// <summary>
        /// Напишите класс Button, который имеет свойство Text типа string и событие типа EventHandler с именем Click, которое возникает при нажатии на кнопку. 
        /// Затем напишите аксессоры для этого события: add и remove, которые контролируют, сколько подписчиков может иметь это событие.
        /// Например, вы можете ограничить максимальное количество подписчиков до трех или запретить добавлять один и тот же подписчик дважды.
        /// Затем напишите несколько методов, которые могут быть подписаны на это событие, например, выводящие на консоль текст кнопки или меняющие его цвет. 
        /// Продемонстрируйте работу этих методов в методе Main.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Button button = new Button();

            button.Click += Button_Click;
            button.Click += Button_ChangeColor;
            button.Click += Button_OutputText;

            button.Text = "Нажми меня!";
            button.OnClick();

            button.Click -= Button_Click;
            button.Click -= Button_ChangeColor;
            button.Click -= Button_OutputText;

            button.OnClick();

            Console.ReadLine();
        }

        /// <summary>
        /// Кнопка нажата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Button_Click(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Нажата кнопка!");
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        /// <summary>
        /// Меняет цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Button_ChangeColor(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Изменение цвета кнопки");
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        /// <summary>
        /// Текст кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Button_OutputText(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Button button = (Button)sender;
            Console.WriteLine($"Текст кнопки: {button.Text}");
        }
    }
}