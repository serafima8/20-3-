using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обобщенные_классы
{
    class Point<T>
    {
        /// <summary>
        /// Обобщенное внутреннее поле х
        /// </summary>
        private T x;
        /// <summary>
        /// Обобщенное внутреннее поле у
        /// </summary>
        private T y;
        /// <summary>
        /// Свойство поля х
        /// </summary>
        public T X { get; set; }
        /// <summary>
        ///  Свойство поля у
        /// </summary>
        public T Y { get; set; }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(T x,T y)
        {
            this.X = x;
            this.Y = y;
        }
        /// <summary>
        /// метод, выводящий значения внутренних полей класса.
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Точка х: {X};Точка у: {Y}");
        }

    }
}
