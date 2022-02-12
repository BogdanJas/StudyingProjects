using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //zadanie1
        //    Opracuj interfejs IGazeta, który będzie zawierał deklaracje właściwości:
        //- RokWydania(tylko do oczytu)
        //- RedaktorNaczelny(do oczytu i zapisu)

        //oraz deklaracje metod:
        //- ObliczLiczbeWydan(z założenia metoda ma zwracać liczbę wydań gazety w roku ubiegłym, na podstawie przekazanej w argumencie zmiennej określającej liczbę miesięcy, kiedy wydanie się nie ukazało[gazeta jest miesięcznikiem])
        //- SprawdzTendencje, wyświetlającej informację o tym, czy gazeta zyskuje, czy traci czytelników(z założenia metoda ma tego dokonywać na podstawie danych o liczbie czytelników w roku ubiegłym i dwa lata wstecz).

        //Przygotuj klasę implementującą interfejs, utwórz jej obiekt i wywołaj działanie składowych odziedziczonych z interfejsu.
    interface IGazeta
    {
        int RokWydania { get; }
        string RedaktorNaczelny { get; set; }
        int ObliczLiczbeWydan(int liczbaMiesiecy);
        string SprawdzTendencje(int liczbaCzytelniko, int liczbaCzytelnikowRokUbiegly);
    }

    class Gazeta :IGazeta
    {
        int rokWydania;
        public int RokWydania 
        { 
            get
            {
                return rokWydania;
            }
        }
        public string RedaktorNaczelny { get; set; }
        
        public Gazeta(int rokWydania)
        {
            this.rokWydania = rokWydania;
        }
        public  int ObliczLiczbeWydan(int liczbaMiesiecy)
        {
            return 12 - liczbaMiesiecy;
        }
        public string SprawdzTendencje( int liczbaCzytelniko, int liczbaCzytelnikowRokUbiegly)
        {
            if (liczbaCzytelniko > liczbaCzytelnikowRokUbiegly)
            {
                return "Gazeta zyskuje";
            }

            else
                return "Gazeta traci czytelnkow";
            
        }
    }
    //zadanie2
        //    Pracujesz nad systemem, który będzie przeznaczony dla turystów i będzie zawierał informacje na temat polskich miast.Wiesz, że system będzie posiadał klasę Miasto, ale nie Ty będziesz ją tworzył.Twoim zadaniem jest stworzenie interfejsu, który będzie implementowany przez klasę Miasto, deklarującego metody pozwalające na:
        //- obliczenie gęstości zaludnienia w mieście
        //- wyświetlenie informacji o tym, od ilu lat sprawuje władzę przezydent(burmistrz) miasta oraz kto nim jest
        //- wyświetlenie n elementów z listy hoteli w mieście(n określone jako argument metody)

    interface IMiasto
    {
        float Gestosc(int liczbaLudzi, float powierzchniaMiasta);
        static void Burmistrz(int rokZaczesciaPracyBurmistrza, string burmistrz) { }
        static void Hotele(int liczbaHotele, List<string> hotele) { }
    }

    class Katowice: IMiasto
    {
        
        public float Gestosc(int liczbaLudzi, float powierzchniaMiasta)
        {
            return liczbaLudzi / powierzchniaMiasta;
        }
        public static void Burmistrz(int rokZaczesciaPracyBurmistrza, string burmistrz)
        {
            
            int czasPracy = DateTime.Now.Year - rokZaczesciaPracyBurmistrza;
            Console.WriteLine("Burmistrzem miasta " + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name + " jest "+burmistrz + ". Sprawia on wladze prezydenta od {0} lat", czasPracy);
        }
        static public void Hotele(int liczbaHotele,List<string> hotele)
        {
            string className = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name;


            Console.WriteLine("Nazwa hotelów miasta {0}:", className);
            for (int i = 0; i < liczbaHotele; i++)
            {
                Console.WriteLine("\t{0}.\t{1}",(i+1),hotele[i]);
            }
        }

    }
    //zadanie3
        //    Przygotuj dwa interfejsy:
        //- IObliczenia(posiada deklarację metody ObliczWysokoscPremii)
        //- IWyswietlanie(posiada deklarację metody WyswietlWszystkieDane oraz metody WyswietlLiczbeDzieci)

        //Następnie przygotuj klasę Pracownik implementującą oba interfejsy.Premia jest obliczana według wzoru: liczba przepracowanych lat* 0.02 * wysokość podstawowego wynagrodzenia.
    interface IObliczenia
    {
        float ObliczWysokoscPremii();
    }

    interface IWyswietlanie
    {
        void WyswietlWszystkieDane();
        void WyswietlLiczbeDzieci();
    }

    class Pracownik: IObliczenia, IWyswietlanie
    {
        int liczbaPrzepracowanychLat; int wysokoscPodstawowychWynagrodzenia;

        public Pracownik(int liczbaPrzepracowanychLat ,int wysokoscPodstawowychWynagrodzenia)
        {
            this.liczbaPrzepracowanychLat = liczbaPrzepracowanychLat;
            this.wysokoscPodstawowychWynagrodzenia = wysokoscPodstawowychWynagrodzenia;
        }
        public float ObliczWysokoscPremii()
        {
            return (float)0.02 * liczbaPrzepracowanychLat * wysokoscPodstawowychWynagrodzenia; 
        }
        public void WyswietlWszystkieDane()
        {
            Console.WriteLine("Premia wynosi {0} zł",ObliczWysokoscPremii());
        }
        public void WyswietlLiczbeDzieci()
        {
            Console.WriteLine("Pracownik ma 10 dzieci");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Gazeta g1 = new Gazeta(2022);
            g1.RedaktorNaczelny = "Pablo Sarah";
            Console.WriteLine( "Liczba wydań w " + g1.RokWydania +" wynosi "+ g1.ObliczLiczbeWydan(2) + ". Redaktor gazety jest: " + g1.RedaktorNaczelny);
            Console.WriteLine( g1.SprawdzTendencje(10,12));
        
            List<string> hotele = new List<string>(10) { "a","aa","a3", "a4", "a5", "a6", "a7", "a8", "a9", "a10" };
            Katowice.Burmistrz(2002,"Bogdan Jasiński");
            Katowice.Hotele(5,hotele);
            */

            Pracownik p1 = new Pracownik(10, 3200);
            p1.WyswietlWszystkieDane();
            p1.WyswietlLiczbeDzieci();
        }
    }
}
