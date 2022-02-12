using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Lekcja13
    {/*
        //zad2
        static void Main(string[] args)
        {
            Random losowe = new Random();

            int min = losowe.Next(1, 701);
            int licznik = 0;

            for (int i = 1; i < 100; i++)
            {
                int liczba = losowe.Next(1, 701);
                if (liczba<min)
                {
                    min = liczba;
                }

                if (liczba >200)
                {
                    licznik++;
                }
            }

            Console.WriteLine("Najmnijszą liczbą jest: {0}", min);
            Console.WriteLine("Spośród wylosowanych liczb było {0} większych niż 200",licznik);
        }
        

        //zad3
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg znaków");
            string ciag = Console.ReadLine();

            string wielkaLitera = string.Empty;
            string malaLitera = string.Empty;

            string wielkiciag = ciag.ToUpper();
            string malyciag = ciag.ToLower();

            for (int i = 0; i < ciag.Length/2; i++)
            {
                wielkaLitera += wielkiciag[i]; 
            }

            for (int i = ciag.Length / 2; i < ciag.Length; i++)
            {
                malaLitera += malyciag[i];
            }

            Console.Write(wielkaLitera+malaLitera);
        }

        //zad4
        static int PozycjaZnaku(string napis, char litera)
        {
            int pozycja = 0;

            if (napis.Contains(litera))
            {
                for (int i = 0; i < napis.Length; i++)
                {
                    if (napis[i] == litera)
                    {
                        pozycja = i;
                        break;
                    }
                    
                    
                }
            }
            else
            {
                pozycja = -1;
            }
        
            return pozycja;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Odp: "+PozycjaZnaku("programowanie", 'x'));
        }
        
        //zad5
        static void Rysunek(byte liczba, char znak)
        {
            for (byte i = 0; i < liczba; i++)
            {
                for (byte j = 0; j < liczba; j++)
                {
                    if (i == 0 || i== liczba/2 || i == liczba-1)
                    {
                        Console.Write("{0} ", znak);
                    }
                    else
                    if (j == 0  && i<liczba/2)
                    {
                        Console.Write("{0} ", znak);
                    }
                    else
                    if (j == liczba - 1 && i>liczba/2)
                    {
                        Console.Write("{0} ", znak);
                    }
                    else
                        Console.Write("  ");
                    
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Rysunek(7, '*');
        }

        //zad6
        static string FragmentTekstu(int a, int b, string napis)
        {
            string tekst = string.Empty;
            for (int i = a; i <=b; i++)
            {
                tekst += napis[i];
            }
            return tekst;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FragmentTekstu(0, 3, "Program"));
        }

        //zad7 
        static void Metoda(bool[] tablica)
        {
            int za = 0;
            int przeciw = 0;


            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] == true)
                {
                    za++;
                }
                else
                if (tablica[i] == false)
                {
                    przeciw++;
                }
            }
            int zaProcentowo = za*100/tablica.Length ;
            int przeciwProcentowo = przeciw*100/tablica.Length;
            StreamWriter sw = new StreamWriter(@"D:\Pulpit\protokol.txt");
            sw.WriteLine("{0}% - za \n{1}% - przeciw", zaProcentowo, przeciwProcentowo);
            sw.Close();

            Console.WriteLine("{0}% - za \n{1}% - przeciw",zaProcentowo,przeciwProcentowo);
        }
        static void Main(string[] args)
        {
            bool[] tablica = new bool[4];
            tablica[0] = true;
            tablica[1] = false;
            tablica[2] = true;
            tablica[3] = false;
            
            
            Metoda(tablica);
        }
        */
    }
}
