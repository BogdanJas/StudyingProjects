using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Lekcja10
    {
        /*
         //zadanie1
        static int CiagFibonacci(int wyraz)
        {
            int wynik = 0;

            if (wyraz == 0)
            {
                wynik = 0;
               
            }
            else
                if (wyraz == 1 || wyraz == 2)
            {
                wynik = 1;
               
            }
            else if (wyraz>1)
            {
                wynik = CiagFibonacci(wyraz - 1) + CiagFibonacci(wyraz - 2);
            }

            return wynik;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("10 wyraz ciągu Fibonacci wynosi {0}",CiagFibonacci(10));
        }
        */

        //zadanie2
        /*
        static int Suma(int n)
        {
            int wynik = n;
            if (n == 1)
            {
                wynik = 0;
            }
            else if (n >1)
            {
                wynik += Suma(n - 1);
            }

            return wynik;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Suma(5));
        }
        
        //Zadanie3
        static void Dlugosc(int liczba, ref int wynik)
        {
            //int wynik = liczba.ToString().Length;
            //Nie wiem jak zrobić to metodą rekurencyjną
            
            
            int zmienna = liczba;
            if (zmienna > 0)
            {
                if (zmienna <= 9)
                {
                    wynik++;
                }
                else
                    wynik++;
                
                
                Dlugosc(liczba / 10,ref wynik);
            }
            
            
            
        }

        static void Main(string[] args)
        {
            int zmiennaDleReferencyjności = 0;//tutaj  będzie zapisywać ilość cyfr w liczbie
            Dlugosc(1982, ref zmiennaDleReferencyjności);
            Console.Write("Wynik: " + zmiennaDleReferencyjności);
        }
        
        
        //zadanie4
        static int Ciag(int n)
        {
            int wynik = n;

            if (n==1)
            {
                wynik = 1;
            }
            else
            {
                wynik = wynik + Ciag(n - 1);
            }
            return wynik;
        }

        static void Main(string[] ags)
        {
            Console.WriteLine(Ciag(15));
        }
        
        //zadanie6

        static void Rysunek(int n)
        {
            if (n > 0)
            {

                if (n == 1)
                {
                    Console.WriteLine("*");
                }
                else
                if (n > 1)
                {
                    int liczba = n;
                    for (int i = 0; i < liczba; i++)
                    {
                        for (int j = 0; j < liczba; j++)
                        {
                            if (i == j || j > i)
                            {
                                Console.Write("* ");
                            }
                            else
                                Console.Write("  ");
                        }
                        Console.WriteLine();
                    }
                }

                Rysunek(n - 1);
            }

            }

            static void Main(string[] args)
            {
                Rysunek(7);
            }
        */
    }
}
