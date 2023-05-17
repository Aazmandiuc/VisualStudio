using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Одномерный_массив
{
    internal class Program
    {//Вариант 15
     //Переставить элементы одномерного массива с чётными индексами в порядке возрастания квадратов их значений.
     //Счёт позиций начинается с единицы, счёт индексации – с нуля.

        static void Main(string[] args)
        {
            //int s = 1000;
            int[] array = new int[] {1, 8, 5, 2, 3, 9};

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    array[i] *= array[i];
                Console.WriteLine(array[i]);
            }
           
            //for (int i = 0; i < array.Length; i++)
            //{
             //   if (i % 2 == 0)
             //       array[i] *= array[i];
             //   Console.WriteLine(array[i]);
            //}
        }
    }
}
