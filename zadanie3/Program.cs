using System;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {



            Random rand = new Random();
            int n = 20;
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 11);
                Console.Write("{0,3} ", i);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,3} ", arr[i]);
            }
            int min = arr[0], i_min = 0, max = arr[19], i_max = 19;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= max)
                {
                    max = arr[i];
                    i_max = i;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    i_min = i;
                }
            }
            Console.WriteLine("\nmin element na indekse {0}. Ego zhachenie {1}", i_min, min);
            Console.WriteLine("max element na indekse {0}. Ego znachenie {1}", i_max, max);
            Console.WriteLine();

            {
                Console.WriteLine("Esli hotite povtorit vvod, vvedite 1, inache lubuyu dr cifru");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) Main();
                return;
            }
            Console.ReadLine();
        }
    }
}
