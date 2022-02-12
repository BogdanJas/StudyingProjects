using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ConsoleApp1
{
    class Lekcja11
    {/*
        
            //Zadanie1
            
            StreamReader sr = new StreamReader(@"D:\Zaj_7_string.txt");
            string tekst ;
            int literaA = 0;
            int iloscZnakow =0;

            while ((tekst = sr.ReadLine()) !=null)
            {
                for (int i = 0; i < tekst.Length; i++)
                {
                    iloscZnakow++;
                    if (tekst[i] == 'a')
                    {
                        literaA++;
                    }
                }
            }
            
            sr.Close();

            decimal procent = (decimal)literaA / iloscZnakow * 100;
            
            Console.WriteLine("W tekście jest {0}, z nych {1} to litera A. Procentowo " +
                "to około {2}%",iloscZnakow,literaA, Math.Round(procent, 2));
        
        //zadanie2

            static void Tabliczka(string sciezka, int liczba)
            {
            int wynik = 0;

               StreamWriter sw = new StreamWriter(sciezka);
            int x = liczba;
            int y = liczba;
            int [,]tablica = new int[x,y];

            for (int i = 0; i < liczba; i++)
            {
                for (int j = 0; j < liczba; j++)
                {
                    tablica[i, j] = (i + 1) * (j + 1);
                    wynik = tablica[i, j];
                    wynik.ToString();
                    sw.Write("\t{0}",wynik);
                    Console.Write("\t{0}",wynik);
                    
                }
                sw.WriteLine();

                Console.WriteLine();
               
            }
            sw.Close();
            
            }

            static void Main(string[] args)
            {
                
                Tabliczka(@"D:\Pulpit\Studia\2 semestr\Ćwiczenia\Wstęp do programowania\Nowy.txt", 5);
            }
     
        //zadanie3
        static void Main(string[] args)
        {
            int liczba = 0;
            using (StreamReader sr = new StreamReader(@"D:\Pulpit\Studia\2 semestr\Ćwiczenia\Wstęp do programowania\zaj11_lizbona.txt")) 
            {
                string tekst;
                while ((tekst = sr.ReadLine()) != null)
                {
                    for (int i = 0; i< tekst.Length; i++)
                    {
                        if (char.IsDigit(tekst[i]))
                        {
                            liczba += int.Parse(tekst[i].ToString()); 
                        }
                    }
                }
            }

            Console.WriteLine("Suma wszystkich liczb w tekście wynosi {0}",liczba);
        }
        //zadanie4
        static void Main(string[] args)
        {

            using (StreamWriter sw = new StreamWriter(@"D:\Pulpit\Studia\2 semestr\Ćwiczenia\Wstęp do programowania\Książki.txt"))
            {
                sw.WriteLine("Działanie programu rozpoczęto " + DateTime.Now);
                for (int i = 1; i <= 3; i++)
                {
                    sw.WriteLine();
                    sw.WriteLine("Książka {0}", i);
                    Console.WriteLine("Podaj tytuł {0} książki", i);
                    sw.WriteLine("Tytuł: \"{0}\"",Console.ReadLine());
                    Console.WriteLine("Podaj liczbę stron {0} książki", i);
                    sw.WriteLine("Liczba stron: " + Console.ReadLine());
                    Console.WriteLine("Podaj Syngature {0} książki", i);
                    sw.WriteLine("Syngatura: " + Console.ReadLine());
                    
                }
                sw.WriteLine();
                sw.WriteLine("Działanie programu zakończono " + DateTime.Now);
            }

        }
        

        //zadanie5
        static void Main(string[] args)
        {
            string tekst = "To jest tekst";
            char[] sperator = { ' ' };

            string[] tablica = tekst.Split(sperator, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("Tab[{0}]: \"{1}\"",i,tablica[i]);
            }
        }


        //zadanie6
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\Pulpit\Studia\2 semestr\Ćwiczenia\Wstęp do programowania\zaj11_test.txt");
            StreamWriter sw = new StreamWriter(@"D:\Pulpit\Studia\2 semestr\Ćwiczenia\Wstęp do programowania\Test.txt");

            string linia;
            int odpowiedzDobra = 0;
            int pytanie = 1;

            while ((linia = sr.ReadLine()) != null)
            {
                string pytania = string.Empty;
                string odpowiedzPrawidlowa = string.Empty;
                string odpowiedzUzytkownika = string.Empty;
                int tabulacja = linia.IndexOf("\t");
                for (int i = 0; i < tabulacja+1; i++)
                {
                    pytania += linia[i];
                }

                for (int j = tabulacja+1; j < linia.Length; j++)
                {
                    odpowiedzPrawidlowa += linia[j];
                }

                Console.WriteLine("Pytanie: {0} ", pytania);
                odpowiedzUzytkownika = Console.ReadLine();
                if (odpowiedzUzytkownika == odpowiedzPrawidlowa)
                {
                    odpowiedzDobra++;
                }
                else
                {
                    sw.WriteLine("\nDałeś nieprawidłowo odpowiedż na {0} pytanie", pytanie);
                    sw.WriteLine("\nTreść pytania: {0} ", pytania);
                    sw.WriteLine("Twoja odpowiedż: {0} \t Poprawna odpowiedz: {1}", odpowiedzUzytkownika, odpowiedzPrawidlowa);
                }
                pytanie++;
            }
            Console.WriteLine("\nDziękuję za test!");
            sw.WriteLine("\n\nDales łącznę prawidlową odpowiedz na {0} pytań", odpowiedzDobra);

            sr.Close();
            sw.Close();
        }
        */
    }
    
}
