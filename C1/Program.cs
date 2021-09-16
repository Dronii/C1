using System;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson С1. Вывод данных по формату
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("20 ");
            }
            Console.WriteLine(" ");
            int x, y;
            Console.WriteLine(" ");
            Console.Write("Input X, how mach times print Y ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Input Y who will printed ");
            y = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<x;i++)
            {
                Console.Write($"{y} ");
            }

            Console.WriteLine(" ");
            
            for (int i=20;i<35;i++)
            {
                Console.WriteLine($"{i}\t");
            }

            int b;
            Console.WriteLine(" ");
            Console.Write("Input B ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine($"{i*i}\t ");
            }
            if (b < 10)
            {
                Console.WriteLine("error");
            }

            int a;
            Console.WriteLine(" ");
            Console.Write("Input A ");
            a = Convert.ToInt32(Console.ReadLine());
            for ( ;a<=50;a++)
            {
                Console.WriteLine($"{a*a*a}");
            }
            if (a>50)
            {
                Console.WriteLine("error! A must be <50 ");
            }
            int a1;
            Console.WriteLine(" ");
            Console.Write("Input A1 ");
            a1 = Convert.ToInt32(Console.ReadLine());
            int a2;
            Console.WriteLine(" ");
            Console.Write("Input A2 ");
            a2 = Convert.ToInt32(Console.ReadLine());
            for (; a1 <= a2; a1++)
                {
                Console.WriteLine($"{a1}");
            }


        }
    }
}
