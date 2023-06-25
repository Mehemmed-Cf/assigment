using System;
using System.ComponentModel.Design;
using System.Net.WebSockets;
using System.Numerics;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task-A

           /* bool IsContinue = true;

            while (IsContinue) // n
            {
                Console.WriteLine("  birinci ededinizi daxil edin  ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("  ikinci ededinizi daxil edin  ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2) // n
                {
                    Console.WriteLine("  ededleriniz yanlisdir , xais olunur yeniden cehd edin  ");
                    continue;
                }

                int sum = 0;

                for (int i = num1; i <= num2; i++) // n
                {
                    sum += i;
                }

                Console.WriteLine(sum);

                // big-O = 0(3n)

            } */


            // Task-B
            Console.WriteLine("neçe edede ehtiyacin var kele?");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] ededler = new int[num];

            for (int i = 0; i < num; i++) //n
            {
                Console.Write($"{i + 1}.eded:");
                ededler[i] = Convert.ToInt32(Console.ReadLine());
            }

            double ortalama = ededler.Sum()/(double)num;
            Console.WriteLine("ortalama:" + ortalama);

        } // big-O = o(n)


          // Task-C

    }
}