using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Lekcja9
    {
        /*
        //zadanie1
        static int ObliczDelte(int a, int b, int c)
        {
            return b* b - 4 * a * c;
        }

        static void WyznaczPierwiastki(int a, int b, int c)
        {
            float x1 = (-1 * b + ObliczDelte(a, b, c)) / (2 * a);
            Console.WriteLine("Pierwszy pierwiastek wynosi {0}.", x1);
            float x2 = (-1 * b - ObliczDelte(a, b, c)) / (2 * a);
            Console.WriteLine("Drugi pierwiastek wynosi {0}.", x2);
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = -5;
            int c = 6;

            Console.WriteLine("Delta wynosi {0}",ObliczDelte(a,b,c));
            WyznaczPierwiastki(a, b, c);
               
        }
        

        //zadanie2
         static double ObliczPole(double strona)
        {
            return Math.Pow(strona, 2);
        }

        static double ObliczPole(double pierwszaStrona, double drugaStrona, double wysokosc)
        {
            return (pierwszaStrona + drugaStrona) * wysokosc / 2;
        }
        static string ObliczPole()
        {
            string napis = "Umiejętność liczenia pola figur płaskich jest bardzo przydatna w życiu";
            return napis;
        }

        static void Main(string[] args)
        {
            Console.Write("Pole kwadratu ze stroną 10 wynosi ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(ObliczPole(10));
            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine("Pole trapezu ze stronami 10 i 2 oraz wysokością 12 wynosi " + ObliczPole(10,2,12));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(ObliczPole());
            Console.BackgroundColor = ConsoleColor.Black;
        }
        //Zadanie3

        static float ObmianValuty(float suma, float kurs = 0.22f, string waluta = "EURO" )
        {
            string waluta1 = waluta.ToUpper();
            float wynik = suma * kurs;
            Console.WriteLine("{0} PLN to {1} {2}",suma,wynik,waluta1);
            return wynik;
        }
        
        static void Main(string[] args)
        {
            ObmianValuty(10);
            ObmianValuty(2.25f, 0.26f, "USD");
        }
        
        //zadanie5
        static void Identyfikator(string staryIdentyfikator)
        {
            string identyfikatorMaly = staryIdentyfikator.ToLower();
            string nowyIdentyfikator = identyfikatorMaly[0].ToString();
            int pozycja = identyfikatorMaly.IndexOf('_');
            

            for (int i = 0; i < identyfikatorMaly.Length; i++)
            {
                if (identyfikatorMaly[i] == '_')
                {
                    for (int j = i+1; j < identyfikatorMaly.IndexOf('_',pozycja+1); j++)
                    {
                        nowyIdentyfikator += identyfikatorMaly[j];
                    }
                }

                if (char.IsDigit(identyfikatorMaly[i]))
                {
                    nowyIdentyfikator += identyfikatorMaly[i];
                }
            }
            
            Console.WriteLine("Nowy identyfikator - {0}",nowyIdentyfikator);
        }

        static void Main(string[] args)
        {
            Identyfikator("Jan_Nowak_21");
        }
        

        //Zadanie6
        static void RysujKwadrat(int ileWierszy, ConsoleColor kolor = ConsoleColor.DarkGreen)
        {
            Console.ForegroundColor = kolor;

            for (int i = 0; i < ileWierszy; i++)
            {
                for (int j = 0; j < ileWierszy; j++)
                {
                    if(i==j || j==0 || i ==0 || i==ileWierszy-1 || j==ileWierszy-1)
                    {
                        Console.Write("* ");
                    }
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            RysujKwadrat(7, ConsoleColor.Red);
            RysujKwadrat(8);
        }

        */

    }
}
