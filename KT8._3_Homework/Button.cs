using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT8._3_Homework
{
    /// <summary>
    /// Класс Button
    /// </summary>
    public class Button
    {
        private string text;
        private EventHandler clickEvent;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        /// <summary>
        /// Событие EventHandler Click
        /// </summary>
        public event EventHandler Click
        {
            add
            {
                if (clickEvent == null || clickEvent.GetInvocationList().Length < 3)
                {
                    if (clickEvent != null && Array.IndexOf(clickEvent.GetInvocationList(), value) != -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Подписчик уже присутствует");
                        Console.ForegroundColor = ConsoleColor.Gray;

                    }
                    else
                    {
                        clickEvent += value;
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.WriteLine("Подписка на событие Click");
                        Console.ForegroundColor = ConsoleColor.Gray;

                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Максимальное количество подписчиков достигнуто");
                    Console.ForegroundColor = ConsoleColor.Gray;

                }
            }
            remove
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                clickEvent -= value;
                Console.WriteLine("Отписка от события Click");
                Console.ForegroundColor = ConsoleColor.Gray;

            }
        }

        /// <summary>
        /// Нажатиек кнопки
        /// </summary>
        public void OnClick()
        {
            clickEvent?.Invoke(this, EventArgs.Empty);
        }


    }
}
