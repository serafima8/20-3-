using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обобщенные_классы
{
    class Triangle <T>
    {
        /// <summary>
        /// Обобщенное внутреннее поле a
        /// </summary>
        private T a;
        /// <summary>
        /// Обобщенное внутреннее поле  b
        /// </summary>
        private T b;
        /// <summary>
        /// Обобщенное внутреннее поле c
        /// </summary>
        private T c;
        /// <summary>
        /// Свойство поля a
        /// </summary>
        public T A { get; set; }
        /// <summary>
        /// Свойство поля b
        /// </summary>
        public T B { get; set; }
        /// <summary>
        /// Свойство поля c
        /// </summary>
        public T C { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Triangle() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(T a, T b, T c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        /// <summary>
        /// метод вывода информации о треугольнике
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Сторона A: {A}\nСторона B: {B}\nСторона C: {C}");
        }
        /// <summary>
        /// метод, возвращающий площадь треугольника
        /// </summary>
        /// <returns></returns>
        public string Square()
        {
            dynamic a = A;
            dynamic b = B;
            dynamic c = C;
            if ((a + b) > c && (a + c) > b && (c + b) > a)
            {
                double per = a + b + c;
                double p = per / 2;
                return $"Треугольник существует.\nПлощадь: {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}";
            }
            else
            {
                return "Треульник не существует";
            }
        }
    
    }
}
