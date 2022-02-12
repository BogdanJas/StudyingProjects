using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ConsoleApp1
{
    class Kolos_J
    {
        //zad1
        /*
        static void Metoda(out float srednia, int[] tab, string sciezka)
        {
            //U swoim rozwiązaniu podałąś liczbe typu float przez referencje. Jest błądem, a jak wywołałaś metodę w ogóle nie podałaś liczbę
            
            int suma = 0;
            foreach (int liczba in tab)
            {
                suma += liczba;
            }
            srednia = suma / tab.Length;
            StreamWriter sw = new StreamWriter(sciezka);
            sw.WriteLine("Średnia wartość w przekazanej tablicy wynosi: {0}",srednia);
            sw.Close();
        }

        static void Main(string[] args)
        {
            float srednia = 0f;//Wartość zmiennej float kończy się literką f
            int[] tablica = { 1, 2, 3, 5, 234 };
            string sciezka = @"D:\Pulpit\Studia\2 semestr\Ćwiczenia\Wstęp do programowania\Kolosy\Zad1.txt";
            //Wstaw powyżej swoją scieżke
            
            Metoda(out srednia, tablica, sciezka);
        }
        //zad3

        static char[] Metoda(int n)
        {
            char[] tablica = new char[n];
            Random losowe = new Random();
            for (int i = 0; i < n; i++)
            {
               tablica[i] = (char)losowe.Next(97, 123);                
            }
            //tutaj utworzyliśmy tabele

            for (int i = 0; i < n; i++)
            {
                if (tablica[i] == tablica[n - 1 - i])
                {
                        byte liczba = (byte)tablica[i];
                        liczba = (byte)losowe.Next(97, 123);
                        tablica[i] = (char)liczba;
                } 
            }
            //tutaj sprawdzamy, czy niema powtarzającej litery, jeżeli jest, to ponownie losujemy jej numer ASCII. 
            //Nie jest do końca poprawne, ale będzie na 1 bal więcej niż bez tego
            foreach (char x in tablica)
            {
                Console.Write(x+" ");
            }
            
            return tablica;
            
        }

        static void Main(string[] args)
        {
            Metoda(5);
       }

        //zad4
        static bool SprawdzPoprawnosc(string pesel, string plec = "kobieta")
        {
            bool poprawnosc = true;

            if (pesel[pesel.Length -1] %2 == 0)
            {
                if (plec == "kobieta")
                {
                    poprawnosc = true;
                }
                else
                    poprawnosc = false;
            }
            
                if (pesel[pesel.Length - 1] % 2 != 0)
            {
                if (plec == "mężczyzna")
                {
                    poprawnosc = true;
                }
                else
                    poprawnosc = false;
            }
           
            return poprawnosc;

        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\Downloads\dane.txt");
            //Wstawisz swoją scieżke
            
            string linia;
            int index;
            int niepoprawnosc = 0;

            while ((linia = sr.ReadLine()) != null)
            {
                string pessel = string.Empty;
                string plec = string.Empty;
                index = linia.IndexOf("|");
                bool poleMaZnak = linia.Contains("|");

                if (poleMaZnak == true)
                {

                    for (int i = 0; i < index; i++)
                    {
                        pessel += linia[i];
                    }
                    for (int i = index + 1; i < linia.Length; i++)
                    {
                        plec += linia[i];
                    }
                    Console.WriteLine("Pessel: {0} \tplec: {1}", pessel, plec);
                }
                else
                {
                    for (int i = 0; i < linia.Length; i++)
                    {
                        pessel += linia[i];
                    }
                }
                if (SprawdzPoprawnosc(pessel, plec) == false)
                {
                    niepoprawnosc++;
                }
                
            }
            Console.WriteLine("Liczba niezgodności wynosi {0}", niepoprawnosc);

            sr.Close();
        }
        */

    }
}
