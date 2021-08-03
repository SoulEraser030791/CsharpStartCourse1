using System;

namespace Ex3._1 //// Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
                 //// по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
                 ///Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату x1 = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату y1 = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату x2 = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату y2 = ");
            int y2 = int.Parse(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками {0:f}", r);
            
        }
    }
}
