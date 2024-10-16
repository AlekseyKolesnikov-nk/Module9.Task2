using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task2
{
    public class Names
    {    
        static List<string> stringList = new List<string> { "Петров", "Борисов", "Сидоров", "Иванов", "Васильев" };

        public static void NameSort(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Выбрана прямая сортировка (1)\n");                                         // Если выбор - 1 - Сортировка по возрастанию
                    var sortedList = stringList.OrderBy(s => s);
                    foreach (var item in sortedList)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 2:
                    Console.WriteLine("Выбрана обратная сортировка (2)\n");                                       // Если выбор - 2 - Сортировка по убыванию
                    sortedList = stringList.OrderByDescending(s => s);
                    foreach (var item in sortedList)
                    {
                        Console.WriteLine(item);
                    }
                    break;
            }
        }
    }





}

