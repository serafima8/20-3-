using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обобщенные_классы
{
    class Segment<T>
    {
        /// <summary>
        /// Обобщенное внутреннее поле x1
        /// </summary>
        private T x1;
        /// <summary>
        /// Обобщенное внутреннее поле y1
        /// </summary>
        private T y1;
        /// <summary>
        /// Обобщенное внутреннее поле x2
        /// </summary>
        private T x2;
        /// <summary>
        /// Обобщенное внутреннее поле y2
        /// </summary>
        private T y2;
        /// <summary>
        /// Свойство поля x1
        /// </summary>
        public T X1 { get; set; }
        /// <summary>
        /// Свойство поля y1
        /// </summary>
        public T Y1 { get; set; }
        /// <summary>
        /// Свойство поля x2
        /// </summary>
        public T X2 { get; set; }
        /// <summary>
        /// Свойство поля y2
        /// </summary>
        public T Y2 { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Segment() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        public Segment(T x1, T y1, T x2, T y2)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
        }
        /// <summary>
        /// метод вывода информации об отрезке
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Точка x1: {X1}\nТочка y1: {Y1}\nТочка x2: {X2}\nТочка y2: {Y2}");
        }
        /// <summary>
        /// метод, возвращающий длину отрезка
        /// </summary>
        /// <returns></returns>
        public double Length()
        {
            dynamic dx = Convert.ToDouble(this.X2) - Convert.ToDouble(this.X1);
            dynamic dy = Convert.ToDouble(this.Y2) - Convert.ToDouble(this.Y1);

            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }

    }
}
