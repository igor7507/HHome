using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace StupidSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];//заповнюємо масив випадковими числами
            Random rand = new Random();
 
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(0, 100);
 
            Console.WriteLine("Невідсортований масив:");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
 
            Sort(array);
 
            Console.WriteLine("\nВідсортований масив:");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
 
            Console.ReadLine();
        }
 
        static void Sort(int[] arr)
        {
            int i = 0, tmp;
            while (i < arr.Length - 1)
            {
                if (arr[i + 1] < arr[i])
                {
                    tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                    i = 0;
                }
                else i++;
            }
        }
 
    }
}