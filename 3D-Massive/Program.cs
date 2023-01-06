using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Massive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string[,] genre = 
            {
                { "Приключения", "Романы", "Стихи"},
                { "Наука", "История", "Образование"},
                { "Мистика", "Ужасы", "Эротика" },
                { "Юмор", "Журналы", "Боевики"},
                { "Политика", "Техника", "Рассказы"}
            };

            while (isOpen)
            {
                Console.WriteLine("Список команд: 1 - найти шкаф с жанрами, 2 - получить полный список жанров, " +
                    "3 - выход");
                int statement = Convert.ToInt32(Console.ReadLine());
                if (statement == 3)
                {
                    Console.WriteLine("Спасибо за использование, до свидания!");
                    isOpen = false;
                }
                else if (statement == 2)
                {
                    Console.WriteLine("Список жанров:");
                    for (int i = 0; i < genre.GetLength(0); i++)
                    {
                        for (int j = 0; j < genre.GetLength(1); j++)
                        {
                            Console.Write(genre[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (statement == 1)
                {
                    Console.WriteLine("Введите интересующий жанр");
                    string inputUser = Console.ReadLine();
                    for (int i = 0; i < genre.GetLength(0); i++)
                    {
                        for (int j = 0; j < genre.GetLength(1); j++)
                        {
                            if(inputUser.ToLower() == genre[i, j].ToLower())
                            {
                                Console.WriteLine($"Интересующий вас жанр - {genre[i, j]} находится " +
                                    $"на шкафу {i + 1}, полке {j + 1}");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Нет такой команды");
                }
                Console.ReadLine();
            }
        }
    }
}

