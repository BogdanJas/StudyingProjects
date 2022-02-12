using System;

namespace ConsoleApp1
{

    //zadanie1
        //    Opracuj klasę Macierz z odpowiednim polem oraz metodami:

        //ObliczWyznacznik(), zwracającą wyznacznik macierzy.Przyjmij w
        //uproszczeniu, że macierz ma wymiary 2x2.

        //SprawdzCzyJednostkowa(), wyświetlającą informację o tym, czy
        //macierz jest macierzą jednostkową.
    class Macierz
    {
        int[,] tablica = new int[2, 2];

        public Macierz(int[,] tablica)
        {
            this.tablica = tablica;
        }

        public void ObliczWyznacznik()
        {
            int wynik = tablica[0, 0] + tablica[1,1] - tablica[1, 0] - tablica[0, 1];
            Console.WriteLine("Wyznacznik macierzy = "+wynik);
        }

        public void SprawdzCzyJednostkowa()
        {
            if (tablica[0,0] == 1 && tablica[1, 1] == 1 && tablica[1, 0] == 0 && tablica[0, 1] == 0)
            {
                Console.WriteLine("Macierz jest jednostkowa");
            }
            else
                Console.WriteLine("Macierz nie jest jednostkowa");
        }

    }

    //zadanie2
        //    Opracuj klasę PracownikSklepu.Klasa ma przechowywać dane na
        //temat: imienia, nazwiska, płci, stanowiska i wysokości zarobków.
        //Zaimplementuj właściwość do odczytu nazwiska oraz właściwość do
        //odczytu i zapisu stanowiska. W klasie umieść również metodę
        //IleZarabia(). Metoda ma wyświetlać informacje zgodnie z
        //założeniami:


        //zarobki do 2500 => „Zarabia mało”


        //zarobki od 2500 do 4000 => „Zarabia średnio”


        //zarobki pow. 4000 => „Zarabia dużo”


        //Pamiętaj o wymogach hermetyzacji.
    class PracownikSklepu
    {
        string imie;
        string nazwisko;
            public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
        }
        char plec;
        string stanowisko;
        public string Stanowisko
        {
            get
            {
                return stanowisko;
            }
            set
            {
                stanowisko = value;
            }
        }
        int wysokoscZarobkow;

        public PracownikSklepu(string imie, string nazwisko, char plec, string stanowisko, int wysokoscZarobkow)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.plec = plec;
            this.stanowisko = stanowisko;
            this.wysokoscZarobkow = wysokoscZarobkow;
        }

        public void IleZarabia()
        {
            if (wysokoscZarobkow <=2500)
            {
                Console.WriteLine("Pracownik {0} zarabia malo",nazwisko);
            }
            else if (wysokoscZarobkow <=4000)
            {
                Console.WriteLine("Pracownik {0} zarabia srednio", nazwisko);
            }
            else
                Console.WriteLine("Pracownik {0} zarabia duzo", nazwisko);
        }
    }
    //zadanie4
        //    Utwórz klasę Stoper, zawierającą pola – czas rozpoczęcia i czas
        //zakończenia oraz metody: Start(), Stop() i WyswietlCzas().
        //Pierwsza i druga metoda ma służyć do pobrania bieżącego czasu i
        //zapisania go do odpowiedniego pola.Metoda WyswietlCzas() ma
        //wyświetlać różnicę pomiędzy czasem zakończenia i czasem
        //rozpoczęcia w sekundach.

        //Utwórz właściwość CzasRozpoczecia, która będzie właściwością
        //tylko do odczytu wartości pola.
    class Stoper
    {
        DateTime czasRozpoczecia;
        public DateTime CzasRozpoczecia
        {
            set { czasRozpoczecia = value; }
        }
        DateTime czasZakonczenia;

        public void Start()
        {
            czasRozpoczecia = DateTime.Now;
        }

        public void Stop()
        {
            czasZakonczenia = DateTime.Now;
        }

        public void WyswietlCzas()
        {
            Console.WriteLine((czasZakonczenia - czasRozpoczecia).Seconds + " sec");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {/*
            int[,] tablica = new int[2, 2];
            tablica[0, 0] = 1;
            tablica[1,1] = 1;
            tablica[0, 1] = 0;
            tablica[0, 1] = 0;

            Macierz m1 = new Macierz(tablica);
            m1.ObliczWyznacznik();
            m1.SprawdzCzyJednostkowa();
            

            PracownikSklepu p1 = new PracownikSklepu("Bogdan","Jasinski",'M',"Pracownik",4099);
            p1.IleZarabia();
            */

            Stoper s = new Stoper();
            s.Start();
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("@*#^");
            }

            Console.ReadLine();
            s.Stop();

            s.WyswietlCzas();

        }
    }
}
