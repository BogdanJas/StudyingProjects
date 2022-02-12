using System;

namespace ConsoleApp1
{
    //zadanie1
        //    Napisz program, zawierający statyczną klasę Kalkulator.Klasa nie posiada pól, ale oferuje szereg statycznych metod:
        //- Dodaj(double a, double b)
        //- Odejmij(double a, double b)
        //- Podziel(double a, double b)
        //- Pomnoz(double a, double b)
        //- Potega(int a, int b).
        //Działanie metod ma być takie, jak wskazują ich nazwy.Metodę "Potęga" napisz samodzielnie, nie korzystając z metody klasy Math.
    static class Kalkulator
    {
        public static void Dodaj(double a, double b)
        {
            Console.WriteLine("Suma dodawania jest " + (a+b));
        }

        public static void Odejmij(double a, double b)
        {
            Console.WriteLine("Różnica odejmowania jest " + (a - b));
        }

        public static void Podziel(double a, double b)
        {
            Console.WriteLine("iloczyn dwóch liczb równa się " + (a / b));
        }

        public static void Pomnoz(double a, double b)
        {
            Console.WriteLine("Mnożenie jest " + (a * b));
        }

        public static void Potega(int a, int b)
        {
            int wynik = 0;
            for (int i = 0; i < a; i++)
            {
                wynik = b * b;
            }
            Console.WriteLine("Wynik potęgi jest "+wynik);
        }
    }
    //zadanie2
    class Telefon
    {
       public static int PierwszyTelefon()
        {
            return 1876;
        }
    }

    //zadanie3
        //    Opracuj klasę Telefon zawierającą statyczną właściwość PierwszyTelefon, będącą właściwością tylko do odczytu, przechowującą wartość 1876 - rok powstania pierwszego telefonu.Skorzystaj z możliwości tworzenia automatycznych właściwości.Wyświetl wartość właściwości z poziomu metody Main.

        //3. Opracuj klasę Budynek posiadającą pola: liczbaPieter, liczbaMieszkan, rokBudowy, liczbaMieszkancow.Utwórz właściwości do odczytu roku budowy oraz do odczytu i zapisu liczby mieszkańców.Zaimplementuj bezargumentową metodę ObliczŚrednią zwracającą średnią liczbę mieszkańców przypadających na jedno mieszkanie. Przeciąż metodę, tworząc jej drugi wariant, który przyjmuje liczbę typu float (oplataZaWywozSmieci) i zwraca średnią wysokość opłaty na jednego mieszkańca.Utwórz odpowiedni konstruktor.Do przygotowanej klasy dodaj statyczną metodę IleMieszkancow() przyjmującą jako argument jednowymiarową tablicę obiektów klasy Budynek i wyświetlającą sumę liczby mieszkańców budynków z tablicy.Z poziomu metody Main wywołaj poniższy kod.Wyświetlony wynik powinien wynosić 530.

        //Budynek[] tablicaBudynkow = new Budynek[3];
        //    tablicaBudynkow[0]=new Budynek(5, "1992", 20, 200);
        //    tablicaBudynkow[1]=new Budynek(6, "1999", 25, 230);
        //    tablicaBudynkow[2]=new Budynek(4, "2002", 15, 100);
        //    Budynek.IleMieszkancow(tablicaBudynkow);
    class Budynek
    {
        int liczbaPieter;
        int liczbaMieszkan;
        string rokBudowy;
        public string RokBudowy
        {
            set
            {
                rokBudowy = value;
            }
        }
        int liczbaMieszkancow;
        public int LiczbaMieszkancow
        {
            get { return liczbaMieszkancow; }
            set { liczbaMieszkancow = value; }
        }

        public Budynek(int liczbaPieter, string rokBudowy, int liczbaMieszkan, int liczbaMieszkancow)
        {
            this.liczbaPieter = liczbaPieter;
            this.rokBudowy = rokBudowy;
            this.liczbaMieszkancow = liczbaMieszkancow;
            this.liczbaMieszkan = liczbaMieszkan;
        }

        public float  ObliczSrednia()
        {
            return (float)liczbaMieszkancow / liczbaMieszkan;
        }

        public float ObliczSrednia(float oplataZaWywozSmieci)
        {
            return ObliczSrednia() * oplataZaWywozSmieci;
        }

        public static void IleMieszkancow(Budynek[] tablica)
        {
            int wynik = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                wynik += tablica[i].liczbaMieszkancow;
            }

            Console.WriteLine("Liczba Mieszkancow w budynku wynosi " +wynik );
        }

    }

    //zadanie4
        //    Utwórz statyczną klasę Fibonacci.Klasa nie posiada pól, ale oferuje szereg statycznych metod:
        //- ObliczNtyElement - przyjmującą jeden argument typu int (n) i zwracającą n-ty wyraz ciągu Fibonacciego
        //- WyswietlNelementow - przyjmującą jeden argument typu byte (n) i wyświetlającą n kolejnych wyrazów ciągu Fibonacciego
        //- WyswietlInformacje - bezargumentową, wyświetlającą tekst: "Ciąg Fibonacciego - ciąg liczb naturalnych określony rekurencyjnie w sposób następujący: Pierwszy wyraz jest równy 0, drugi jest równy 1, każdy następny jest sumą dwóch poprzednich.".
    static class Fibonacci
    {
        public static int ObliczNtyElement(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return ObliczNtyElement(n - 1) + ObliczNtyElement(n - 2);
            }
        }

        public static void WyswietlNelementow(byte n)
        {
            for (int i = 0; i <=n; i++)
            {
                Console.WriteLine("wartosc {0} elementu ciagu Fibonacci wynosi {1}",i,ObliczNtyElement(i));
            }
        }

        public static void WyswietlInformacje()
        {
            Console.WriteLine("Ci№g Fibonacciego - ci№g liczb naturalnych okreњlony rekurencyjnie w sposуb nastкpuj№cy: Pierwszy wyraz jest rуwny 0, drugi jest rуwny 1, kaїdy nastкpny jest sum№ dwуch poprzednich.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Kalkulator.Dodaj(10, 2);
            Kalkulator.Odejmij(10, 2);
            Kalkulator.Pomnoz(10, 2);
            Kalkulator.Potega(10, 2);
            Kalkulator.Podziel(10, 2);
                       
            Console.WriteLine(Telefon.PierwszyTelefon());
        
            Budynek[] tablicaBudynkow = new Budynek[3];
            tablicaBudynkow[0] = new Budynek(5, "1992", 20, 200);
            tablicaBudynkow[1] = new Budynek(6, "1999", 25, 230);
            tablicaBudynkow[2] = new Budynek(4, "2002", 15, 100);
            Budynek.IleMieszkancow(tablicaBudynkow);
            */
            Console.WriteLine("10-ty element ciagu fibonacci wynosi " + Fibonacci.ObliczNtyElement(10));
            Console.WriteLine();
            Fibonacci.WyswietlInformacje();
            Console.WriteLine();
            Fibonacci.WyswietlNelementow(10);
        }
    }
}
