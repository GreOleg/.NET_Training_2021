using System;
using System.Linq;

namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //            Задание 1:
            //1.Создать массив int с рандомно - сгенерированными числами
            //2.Отсортировать массив не используя временных переменных temp(все способы, что знаете)


            int Min = 0;
            int Max = 20;

            int[] arr = new int[5];

            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i + "-" + "Item of Default Array");
            }


            //first case
            Array.Sort(arr);

            foreach (int i in arr)
            {
                Console.WriteLine(i + "-" + "Item of Sort Array");
            }


            //second case
            //Array.Sort<int>(arr, new Comparison<int>(
            //      (i1, i2) => i1.CompareTo(i2)));

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i + "-" + "Item of Sort Array");
            //}


            //third case
            //arr = arr.OrderBy(c => c).ToArray();

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i + "-" + "Item of Sort Array");
            //} 
        }
    }
}
