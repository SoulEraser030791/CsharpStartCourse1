using System;

namespace Ex4._2//// Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.   

///б) * без использования третьей переменной.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную b");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;


            Console.WriteLine(" Переменная a = " + a + " Переменная b = " + b);
        }
    }
}
