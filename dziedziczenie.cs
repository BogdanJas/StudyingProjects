using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //zadanie2
    class IstotaZywa
    {
        byte wiek;
        public byte Wiek
        {
            get
            {
                return wiek;
            }
            set
            {
                wiek = value;
            }
        }
        public virtual void WyswietlWiek()
        {
            Console.WriteLine("Mój wiek " + wiek + " lat");
        }
    }
    class Zwierze : IstotaZywa
    {
    }
    class Czlowiek : IstotaZywa
    {
    }
    class Kobieta : Czlowiek
    {
        public override void WyswietlWiek()
        {
            base.WyswietlWiek();

            if (Wiek >=11 && Wiek <=19)
            {
                Console.WriteLine("Jestem nastolatką");
            }
            else
                Console.WriteLine("Nie jestem nastolatką");
        }
    }
    class Mezczyzna : Czlowiek
    {
        public void PrzedstawSie()
        {
            Console.WriteLine("Jestem mężczyzną");
        }
    }

    //zadanie3
        //    Napisz program, zawierający dwie klasy: Pracownik i Kierownik, przy czym klasa Pracownik dziedziczy po klasie Pracownik.
        //W klasie pracownik:
        //- utwórz pola: imię , nazwisko, data zatrudnienia (DateTime), lista obowiązków (List<string>)
        //- utwórz konstruktor odpowiedzialny za inicjalizację wartości pól
        //- utwórz właściwość do odczytu i zapisu pola lista obowiązków
        //- zdefiniuj metodę ObliczWynagrodzenie, która zwraca (!) wartość wyliczoną zgodnie ze wzorem: (liczba zadań na liście obowiązków) x 500, czyli np. 4 zadania x 500 = 2000.
        //W klasie Kierownik:
        //- utwórz konstruktor, odwołujący się do konstruktora klasy bazowej
        //- przesłoń metodę ObliczWynagrodzenie, która liczy wynagrodzenie tak samo jak w przypadku pracownika, ale dodaje do wyniku jeszcze 1500 zł (base.ObliczWynagrodzenie()+1500)
        //Z poziomu metody Main utwórz obiekt klasy Kierownik i zweryfikuj poprawność działania programu.
        //        - w klasie Kierownik dodaj pole "data objęcia stanowiska kierowniczego" (przez co musisz zmodyfikować konstruktor)
        //- w klasie Kierownik dodaj metodę WyswietlDane, wyświetlającą imię, nazwisko, datę zatrudnienia i datę objęcia stanowiska kierowniczego.Zwróć uwagę, czy pozwalają na to modyfikatory dostępu w klasie bazowej.Jeśli nie - zmodyfikuj je.
    class Pracownik
    {
        protected string imie;
        protected string nazwisko;
        protected DateTime dataZatrudnienia;
        List<string> listaObowiazow= new List<string>();
        List<string> ListaObowiazow
        {
            get
            {
                return listaObowiazow;
            }
            set
            {
                listaObowiazow = value;
            }
        }


        public Pracownik(string imie, string nazwisko, DateTime dataZatrudnienia, List<string> listaObowiazow)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataZatrudnienia = dataZatrudnienia;
            this.listaObowiazow = listaObowiazow;
        }

        public virtual int ObliczWynagrodzenia()
        {
            return 500 * listaObowiazow.Count;
        }
    }

    class Kierownik : Pracownik
    {
        DateTime dataObeciaStanowiskaKierowniczego;
        public Kierownik(string imie, string nazwisko, DateTime dataZatrudnienia, List<string> listaObowiazow, DateTime dataObeciaStanowiskaKierowniczego) :
            base(imie, nazwisko, dataZatrudnienia, listaObowiazow)
        {
            this.dataObeciaStanowiskaKierowniczego = dataObeciaStanowiskaKierowniczego;        
        }

        public override int ObliczWynagrodzenia()
        {
            return base.ObliczWynagrodzenia() + 1500;
        }

        public void WyswietlDane()
        {
            string value = dataZatrudnienia.ToShortDateString();
            Console.WriteLine("Imie " + imie);
            Console.WriteLine("Nazwisko " + nazwisko);
            Console.WriteLine("Data zatrudnienia " + value);
            Console.WriteLine("Data objęcia stanowiska kierowniczego " + dataObeciaStanowiskaKierowniczego);
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Kobieta iz = new Kobieta();
            iz.Wiek = 19;
            iz.WyswietlWiek();
            */
            List<string> f = new List<string>();

            for (int i = 0; i < 103; i++)
            {
                f.Add("Siema");
            }

            Kierownik k = new Kierownik("B","J",DateTime.Now,f,DateTime.Now.AddMonths(-10));
            Pracownik p = new Pracownik("B", "J", DateTime.Now, f);

            Console.WriteLine(k.ObliczWynagrodzenia());
            k.WyswietlDane();
        }
    }
}
