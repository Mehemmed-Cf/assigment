using System;
using System.Linq;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Xos geldiz, eli bos geldiz ayibdir axi, nie bele edirsiniz? xais edirik bide bele etmeyin");

        bool isContinue = true;

        while (isContinue == true)
        {
            Console.WriteLine("prablemin nedir kele?");
            Console.WriteLine("1. toplama");
            Console.WriteLine("2. cixma");
            Console.WriteLine("3. bolme");
            Console.WriteLine("4. vurma");
            Console.WriteLine("5. pragramdan cixis edin");

            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    Console.WriteLine("neçe eded daxil edeceksiniz?");
                    int numc1 = Convert.ToInt32(Console.ReadLine());

                    int[] ededsayi = new int[numc1];

                    for (int i = 0; i < numc1; i++)
                    {
                        Console.Write($"{i + 1}.eded:");
                        ededsayi[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    double cem = ededsayi.Sum() + (double)numc1;
                    Console.WriteLine("cem:" + cem);

                    break;

                case "2":
                    Console.WriteLine("neçe eded daxil edeceksiniz?");
                    int numc2 = Convert.ToInt32(Console.ReadLine());

                    int[] ededsayi2 = new int[numc2];

                    for (int i = 0; i < numc2; i++)
                    {
                        Console.Write($"{i + 1}. eded:");
                        ededsayi2[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    int difference = ededsayi2[0];
                    for (int i = 1; i < numc2; i++)
                    {
                        difference -= ededsayi2[i];
                    }

                    Console.WriteLine("ferq: ");
                    Console.WriteLine(difference);

                    break;



                case "3":
                    Console.WriteLine("neçe eded daxil edeceksiniz?");
                    int numc3 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("1 ci ededinizi daxil edin");
                    int EDed1 = Convert.ToInt32(Console.ReadLine());

                    int quotient = EDed1;
                    for (int i = 1; i < numc3; i++)
                    {
                        Console.WriteLine($"{i + 1} ci ededinizi daxil edin");
                        int EDed = Convert.ToInt32(Console.ReadLine());
                        if (EDed != 0)
                        {
                            quotient /= EDed;
                        }
                        else
                        {
                            Console.WriteLine("Sıfıra bölme xətası!");
                            break;
                        }
                    }

                    Console.WriteLine("qismet: ");
                    Console.WriteLine(quotient);

                    break;


                case "4":
                    Console.WriteLine("neçe eded daxil edeceksiniz?");
                    int numc4 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("1 ci ededinizi daxil edin");
                    int EDEd1 = Convert.ToInt32(Console.ReadLine());

                    int product = EDEd1;
                    for (int i = 1; i < numc4; i++)
                    {
                        Console.WriteLine($"{i + 1} ci ededinizi daxil edin");
                        int EDEd = Convert.ToInt32(Console.ReadLine());
                        product *= EDEd;
                    }

                    Console.WriteLine("hasil: ");
                    Console.WriteLine(product);

                    break;


                case "5":
                    isContinue = false;
                    Console.WriteLine("Görüşərik hormetli müştərimiz, gələn dəfə eli dolu gəlin, gəlməsəniz almıyacam içəri bizdə adamıq yemey zad yeməliyiy ya yo?");

                    break;

                default:
                    Console.WriteLine("Üzür istəyirik, belə bir xidmətimiz yoxdur, qor deilsiniz ki? Xidmətləri yazmışıqda əlimiz qırıla qırıla");

                    break;
            }
        }
    }
}