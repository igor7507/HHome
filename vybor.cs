using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication36
{
    class Program
    {
        static int[] ViborSort(int[] mas)
        {
            
            for (int i = 0; i < mas.Length - 1; i++)
            {
                //пошук мінімального числа
                int min=i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                //обмін елементів
                int temp = mas[min];
                mas[min] = mas[i];
                mas[i] = temp;
            }

            return mas;
        }       
        static void Main(string[] args)
        {
            int n = 20;
            int[] mas = new int[n]; //введення масиву
            Random rand = new Random();
            Console.WriteLine("Згенерований масив");
            
            for (int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(1, 100);
                Console.WriteLine("" + mas[i]); //заповнення випадковими числами
            }
            ChooseSort(mas);
            Console.WriteLine("Відсортований масив:");
            
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine( mas[i]);
            }
            Console.ReadLine();
        }
    }
}
  