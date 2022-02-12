using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /*class Lekcja8
    {
        //zadanie1
        //Obliczyć pole trójkąta
        
         static int PoleTrojkata(int wysokość, int pierwszaStrona, int drugaStrona)
        {
            int wynik = wysokość * pierwszaStrona * drugaStrona / 2;
            return wynik;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Pole trójkąta ze stronami 10 i 3 oraz wysokością 5 = {0}",PoleTrojkata(10,5,3));
        }
        
        //zadanie2
        //kalkulator

        static float Kalkulator(char znak, float liczba1, float liczba2)
        {
            float wynik;
            switch(znak)
            {
                case '+':
                    wynik = liczba1 + liczba2;
                    break;
                case '-':
                    wynik = liczba1 - liczba2;
                    break;
                case '/':
                    wynik = liczba1 / liczba2;
                    break;
                case '*':
                    wynik = liczba1 * liczba2;
                    break;
                default:
                    wynik = 0;
                    break;
            }
            return wynik;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("wynik = " + Kalkulator('o', 4, 23));
        }
        
        //zadanie3
        //Napisz program zawieraj№cy metodк, ktуra przyjmuje jako argument tablicк liczb caіkowitych, a nastкpnie tworzy now№ tablicк, w ktуrej kolejnoњж elementуw jest odwrotna niї w џrуdіowej 
        //i zwraca now№ tablicк jako wynik.
        static void Tablica(int[] tablica)
        {
            int[] nowaTablica = new int[tablica.Length];

            for (int i = 0; i < tablica.Length-1; i++)
            {
                 nowaTablica[i] = tablica[tablica.Length - 1 - i];
            }

            
        }

        static void Main(string[] args)
        {
            int[] tabel = new int[] { 10, 2, 3 };
            Console.WriteLine(Tablica(tabel)) ;
        }
        
        //zadanie4
        //Rysunek

        static void Rysunek(char znak, int liczba)
        {
            if (liczba % 2 == 1)
            {
                for (int i = 0; i < liczba; i++)
                {
                    if (i % 2 != 1)
                    {
                        for (int j = 0; j <= liczba / 2; j++)
                        {
                            Console.Write(znak);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < liczba / 2; j++)
                        {
                            Console.Write(' ');
                        }

                        for (int j = liczba / 2; j < liczba; j++)
                        {
                            Console.Write(znak);
                        }
                    }

                    Console.WriteLine();
                }

            }
            else
            {
                for (int i = 0; i < liczba; i++)
                {
                    if (i % 2 != 1)
                    {
                        for (int j = 0; j < liczba / 2; j++)
                        {
                            Console.Write(znak);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < liczba / 2; j++)
                        {
                            Console.Write(' ');
                        }

                        for (int j = liczba / 2; j < liczba; j++)
                        {
                            Console.Write(znak);
                        }
                    }

                    Console.WriteLine();
                }

            }
        }

        static void Main(string[] args)
        {
            Rysunek('#',5);
        }
        
        //zadanie5
        //Potęga

        static long LiczPotege(int liczba, int potęga)
        {
            long wynik = 1;
            for (int i = 0; i < potęga; i++)
            {
                wynik = wynik * liczba;
            }
            return wynik;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wynik przez metode = " + LiczPotege(3,5));
            Console.WriteLine("Wynik przez funkcje = " + Math.Pow(3, 5));
        }
    }*/
}
