using System;
using System.ComponentModel.Design;
using System.Net.WebSockets;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A
            bool IsContinue = true;

            while (IsContinue)
            {
                Console.WriteLine("  birinci ededinizi daxil edin  ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("  ikinci ededinizi daxil edin  ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine("  ededleriniz yanlisdir , xais olunur yeniden cehd edin  ");
                    continue;
                }

                int sum = 0;

                for (int i = num1; i <= num2; i++)
                {
                    sum += i;
                }

                Console.WriteLine(sum);
            }
            //B

        }
    }
}