using System;
/// <summary>
/// Студент Вечёрко
/// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
/// где m — масса тела в килограммах, h — рост в метрах.
/// </summary>

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свой вес в (кг): ");
            Double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("m = " + weight + " кг.");

            Console.Write("Введите свой рост в (м): ");
            Double height = double.Parse(Console.ReadLine());
            Console.WriteLine("h = " + height + " м.");
      
            Double I = weight / (height*height);
         
            Console.WriteLine("Ваш индекс массы тела (ИМТ) = " + I);




        }
    }
}
