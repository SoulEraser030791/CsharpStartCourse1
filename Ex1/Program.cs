using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args) //// Студент Вечёрко. Написать программу «Анкета».
                                        //// Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
        ///В результате вся информация выводится в одну строчку:
        ///а) используя склеивание; б) используя форматированный вывод; в) используя вывод со знаком $.


        {
            Console.WriteLine("Анкета");

            Console.Write("1) Введите ваше имя:");
            String name = Console.ReadLine();

            Console.Write("2) Введите вашу фамилию:");
            String secondname = Console.ReadLine();

            Console.Write("3) Введите ваш возраст:");
            String age = Console.ReadLine();

            Console.Write("4) Введите ваш рост:");
            String height = Console.ReadLine();

            Console.Write("5) Введите ваш вес:");
            String weight = Console.ReadLine();

            Console.WriteLine(name + " " + secondname + ": возраст: " + age + " лет, рост: " + height + " см., вес: " + weight + " кг.");
            Console.WriteLine("{0} {1}: возраст: {2} лет, рост: {3} см., вес: {4} кг.", name, secondname, age, height, weight);
            Console.WriteLine($"{name} {secondname}: возраст: {age} лет, рост: {height} см., вес: {weight} кг.");
        }
    }
}