using System;

namespace Ex5 ////  Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
              ////  б) Сделать задание, только вывод организовать в центре экрана.
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Напишите ваше имя:");
            String name = Console.ReadLine();

            Console.Write("Напишите вашу фамилию:");
            String secondname = Console.ReadLine();

            Console.Write("Напишите ваш город ипроживания:");
            String city = Console.ReadLine();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);


            Console.WriteLine(name + " " + secondname + " г. " + city);
                    Console.ReadKey();









                }
            }
        }
