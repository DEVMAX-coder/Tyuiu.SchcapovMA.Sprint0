using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SchcapovMA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.SchcapovMA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            //Пример циклической структуры находится в билиотеке классов в методе AddicationArray
            Console.WriteLine("Сумма элемнтов массива = " + DataService.AdditionArray(numsArray));

            //Пример цикической структуры  находится в билиотеке классов в методе SubtractionArray
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(numsArray));

            //Пример циклической структуры находится в библиотеке классов в методе MultiplicationArray
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
    }
}
