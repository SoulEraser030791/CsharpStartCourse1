using System;

namespace Ex4._1//// Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов. 
///а) с использованием третьей переменной;
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную b");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(" Переменная a = " + a + " Переменная b = " + b);
        }
    }
}
