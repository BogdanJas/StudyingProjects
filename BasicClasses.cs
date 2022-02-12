using System;

namespace Lektion1
{
    //zadanie1
        //    Opracuj klasę Walec zgodnie z następującymi wytycznymi:

        //Klasa pozwala na reprezentację danych na temat promienia
        //podstawy oraz wysokości bryły

        //Klasa zawiera metody: ObliczPolePodstawy() oraz
        //ObliczObjetosc()

        //Następnie utwórz obiekt tej klasy i wywołaj dla niego działanie
        //utworzonych metod.
    /*
    class Walec
    {
        public float promien;
        public float wysokosc;

        public Walec(float r, float h)
        {
            promien = r;
            wysokosc = h;
        }

        public void ObliczPolePodstawy()
        {
            float odpowiedz = (float)Math.Pow(promien, 2) * (float)Math.PI;
            Console.WriteLine("Pole podstawy wynosi: " + odpowiedz);
        }

        public void ObliczObjetosc()
        {
            float odpowiedz = (float)Math.Pow(promien, 2) * (float)Math.PI * wysokosc;
            Console.WriteLine("Objetosc wynosi: {0}",odpowiedz);
        }
    }
    */
    //zadanie2
    //    Opracuj klasę Punkt, której obiekty będą reprezentowały punkty na
    //płaszczyźnie.Utwórz w klasie niezbędne pola oraz przeciążoną metodę
    //ObliczOdleglosc(). Pierwszy wariant tej metody(bezargumentowy) ma
    //obliczyć odległość punktu od początku układu współrzędnych.Drugi
    //wariant (przyjmujący trzy argumenty – A, B i C) ma obliczyć odległość
    //punktu od prostej o równaniu ogólnym Ax+By+C=0.

    //Następnie utwórz obiekt tej klasy i wywołaj dla niego działanie
    //utworzonych metod.

    //Wskazówka: Math.Abs() – obliczanie wartości bezwzględnej
    /*    class Punkt
    {
        public int x;
        public int y;

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ObliczOdleglosc()
        {
            Console.WriteLine("Odległość punktu od początku układu współrzędnych wynosi: " + Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2)));
        }

        public void ObliczOdleglosc(int a, int b, int c)
        {
            double odpowiedz = (Math.Abs(a * x + b * y + c) ) / (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            Console.WriteLine("Odległość punktu od prostej wynosi: " + odpowiedz);
        }

    }
    */

    //zadanie3
    //    Opracuj klasę Pracownik, zawierającą pola: imię, nazwisko, rok
    //zatrudnienia oraz metody:

    //IlePracuje(), która pozwoli na obliczenie, od ilu lat jest zatrudniony
    //dany pracownik.Program ma być zawsze aktualny, pobierając w
    //metodzie bieżący rok.

    //WyswietlDane(), wyświetlającą imię, nazwisko pracownika oraz
    //informację o tym, od ilu lat jest już zatrudniony pracownik (na
    //podstawie obliczeń w metodzie IlePracuje())

    //Wskazówka: Bieżący rok - DateTime.Now.Year
    /*
    class Pracownik
    {
        public string imie;
        public string nazwisko;
        public int rokZatrudnienia;

        public Pracownik(string imie, string nazwisko, int rokZatrudnienia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokZatrudnienia = rokZatrudnienia;
        }

        public int rok = DateTime.Now.Year;
        public int IlePracuje(int rok)
        {
            return rok - rokZatrudnienia;
        }

        public void WyswietlDane()
        {
            Console.WriteLine("Imie: {0}\nNazwisko: {1}\nPracuje już: {2} lat",imie,nazwisko,IlePracuje(DateTime.Now.Year));
        }
    }
    */

    //zadanie 5
    //    Utwórz klasę Student, zawierającą dane: imię, nazwisko, płeć,
    //wysokość stypendium oraz metodę, wyświetlającą wszystkie dane
    //za pomocą jednego wywołania metody WriteLine().

    //Z poziomu metody Main() utwórz trzyelementową tablicę obiektów
    //tej klasy(zasady tworzenia tablic obiektów są takie same, jak przy
    //dotychczasowym tworzeniu tablic – klasa staje się typem
    //elementów tablicy). Za pomocą pętli foreach wyświetl informacje o
    //wszystkich studentach.
    /*
     class Student
    {
        public string imie;
        public string nazwisko;
        public char plec;
        public int stypendium;

        public Student(string imie, string nazwisko, char plec, int stypendium)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.plec = plec;
            this.stypendium = stypendium;
        }

        public string Wyswietlic()
        {
            return "Imie: " + imie + "\tNazwisko: " + nazwisko + "\t Płec: " + plec + "\t Stypendium: " + stypendium;
            //Console.WriteLine("Imie: {0}\tNazwisko: {1}\t Płeć: {2}\tStypendium: {3}", imie,nazwisko,plec,stypendium);
        }
    }
    */

    //zadanie6
    //    Zaimplementuj klasę Sportowiec posiadającą dane(nazwisko, dyscyplina sportowa,
    //    tablica wyników typu double) oraz przeciążony konstruktor:

    //w pierwszym wariancie jako argumenty przyjmuje: nazwisko, dyscyplinę oraz liczbę
    //całkowitą, będącą długością tablicy wyników(n), zaś do tablicy wyników zapisuje n
    //losowych liczb rzeczywistych z zakresu 0-1 (metoda NextDouble() klasy Random)

    //w drugim wariancie jako argumenty przyjmuje: nazwisko, dyscyplinę i uzupełnioną
    //tablicę wyników.

    //Ponadto klasa ma zawierać metodę, przyjmującą jeden argument typu int (m) i wyświetlić
    //m-ty element tablicy wyników.W metodzie zadbaj o obsługę wyjątków z użyciem
    //konstrukcji try-catch-finally. Zastosuj dwa bloki catch:

    //catch(IndexOutOfRangeException)

    //catch(Exception)
    class Sportowiec
    {
        public string nazwisko;
        public string dyscyplinaSportowa;
        public double[] wyniky;

        public Sportowiec(string nazwisko, string dyscyplinaSportowa, int n)
        {
            this.nazwisko = nazwisko;
            this.dyscyplinaSportowa = dyscyplinaSportowa;

            wyniky = new double[n];
            Random los = new Random();

            for (int i = 0; i < n; i++)
            {
                wyniky[i] = Math.Round(los.NextDouble(),2);
            }
            
        }
        
        public Sportowiec(string nazwisko, string dyscyplinaSportowa, double[] tablica)
        {
            this.nazwisko = nazwisko;
            this.dyscyplinaSportowa = dyscyplinaSportowa;
            wyniky = tablica;
        }        
        public void WyswietlDane()
        {
            
                for (int i = 0; i < wyniky.Length; i++)
                {
                    Console.WriteLine("Nazwisko: {0} \tDyscyplina: {1} \tWyniki: {2}", nazwisko, dyscyplinaSportowa, wyniky[i]);
                }       
        }

        public void Metoda(int m)
        {
            try
            {

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
      
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
                 Walec w1 = new Walec(1.2f, 3.4f);
                w1.ObliczObjetosc();
                w1.ObliczPolePodstawy();


                Punkt p1 = new Punkt(6, 8);
                p1.ObliczOdleglosc();
                p1.ObliczOdleglosc(10,10,2);
            

            Pracownik p1 = new Pracownik("Bogdan", "Jasiński", 2021);
            p1.WyswietlDane();
        

            string[] Tablica = new string[3];
            Student s1 = new Student("Bogdan", "Jasiński", 'M', 1000);
            Student s2 = new Student("Edik", "Galkin", 'M', 1102);
            Student s3 = new Student("Denys", "Dzuga", 'K', 1342);

            Tablica[0] = s1.Wyswietlic();
            Tablica[1] = s2.Wyswietlic();
            Tablica[2] = s3.Wyswietlic();

            foreach (string n in Tablica)
            {
                Console.WriteLine(n);
            }
        */

            double[] tablica = new double[4];
            Random los = new Random();

            for (int i = 0; i < 4; i++)
            {
                double zmienna = los.NextDouble();//zmienna - wylosowana liczba
                tablica[i] = Math.Round(zmienna, 2);//zaokręglenie liczby
            }

            Sportowiec s1 = new Sportowiec("Jasiński", "Siatkówka", 4);
            s1.WyswietlDane();
            
            Console.WriteLine();
            //s1.Metoda(1);

            Sportowiec s2 = new Sportowiec("Jasiński", "Siatkówka", tablica);
            s2.WyswietlDane();
        }
    }
}
