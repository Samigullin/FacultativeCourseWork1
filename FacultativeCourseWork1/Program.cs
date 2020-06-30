﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultativeCourseWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Наша курсовая работа ***");
            while (true)
            {
                Console.WriteLine("Выберите домашнюю работу для показа (q-выход):");
                string line = Console.ReadLine();
                if (String.Equals(line,"q"))
                    break;
                int.TryParse(line, out int numberHomeWork);
                switch (numberHomeWork)
                {
                    default:
                        Console.WriteLine("Нет домашней работы под таким номером!");
                        break;
                }
            }
            Console.WriteLine("Нажмите любую кнопку для выхода ...");
            Console.ReadKey();
        }
    }
}
