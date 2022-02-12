using System;

namespace ConsoleApp1
{
    class Program
    {

        //zad1

        static void Metoda(string element)
        {
            Console.WriteLine("Podaj numer saly");
            string numerSaly = Console.ReadLine();
            int licznik = 0;

            char[] sperator = { '.', '.', '.' };
            string[] tablica = element.Split(sperator, StringSplitOptions.RemoveEmptyEntries);

            if (tablica[1] == "TablicaInteraktywna")
            {
                Console.WriteLine("Unikatowy identyfikator elementu z rodzaju \"TablicaInteraktywna\" jest " + tablica[3]);
                Console.WriteLine();
            }

            if (tablica[2] == numerSaly)
            {
                licznik++;
            }

            if (licznik!=0)
                Console.WriteLine("W sale jest {0} element", licznik);
            {

            }

          
            Console.WriteLine("RodzajWyposażenia:\t{0}",tablica[1]);
            Console.WriteLine("NumerSali:\t{0}",tablica[2]);
            Console.WriteLine("UnikatowyIdentyfikator:\t{0}",tablica[3]);
        }


        static void Main(string[] args)
        {
            Metoda("SP1.TablicaInteraktywna.107.15");
        }

        /*
        //zad 4
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
            else if (wyraz > 1)
            {
                wynik = CiagFibonacci(wyraz - 1) + CiagFibonacci(wyraz - 2);
            }

            return wynik;
        }
        
        static void Main(string[] args)
        {
        repeat:;
            Console.WriteLine("Podaj liczbę z zakresu 1-3");
            byte liczba = byte.Parse(Console.ReadLine());

            switch(liczba)
            {
                case 1:
                    {
                        Console.WriteLine("Podaj swój wiek");
                        int rokUrodzenia = DateTime.Now.Year - int.Parse(Console.ReadLine());
                        Console.WriteLine("Urodzieś się w {0} roku", rokUrodzenia);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Podaj współczynnik kierunkowy 1 prostej");
                        int m1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Podaj współczynnik kierunkowy 2 prostej");
                        int m2 = int.Parse(Console.ReadLine());

                        if (m1 == (-1/m2))
                        {
                            Console.WriteLine("Proste są prostopadłe");
                        }
                        else
                            Console.WriteLine("Proste nie są prostopadłe");

                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Wartość 4-tego wyrazu ciągu Fibonacciego {0}",CiagFibonacci(4)); 
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nie podałeś liczbę z zakresu");
                        goto repeat;
                    }
            }
        
        }
        */
    }
}
