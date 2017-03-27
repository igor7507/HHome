using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


        
namespace ConsoleApplication35
{
        class Program
    {
            static int[] BubbleSort(int[] mas)  //vvedennya function sortyvannya "Bubbles"
            {
                int temp;
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] > mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }
                return mas;
            }
        static void Main(string[] args)
        {
            int n = 20;
            int[] mas = new int[n]; //vvedennya massivu
            Random rand = new Random();
            Console.WriteLine("Zgenerovanniy massiv");
            for (int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(1, 100);
                Console.WriteLine("" + mas[i]); //zapovnennya rand 4islami
            }
            BubbleSort(mas);
            Console.WriteLine("Vivedennya sorted massive:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadLine();
        }
    }
}
