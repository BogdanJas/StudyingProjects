//using System;

namespace ConsoleApp1
{
    class Progra
    {
        static void Main(string[] args)
        {
            /*
                        1. Napisz program, który poprosi użytkownika o podanie miejsowości, w której mieszka, a następnie wyświetla informację: 
                        "Miejscowość X - tutaj mieszkasz", gdzie X będzie wartością podaną przez użytkownika.

                        System.Console.WriteLine("Prosze podać miejscowość w której mieszkasz");
                        string miejscowosc = System.Console.ReadLine();
                        System.Console.WriteLine("Miejscowość " + miejscowosc + " - tutj mieszkasz");



                                2. Napisz program, który wyświetla w kolejnych liniach:
                            - wynik działania 2+8
                            - wynik działania 4/2
                            - wynik działania 5*6

                        Console.WriteLine("Wynik działania 2+8 = " + (2 +8));
                        Console.WriteLine("Wynik działania 4/2 = " + (4/2));
                        Console.WriteLine("Wynik działania 5*6 = " + (5*6));


                                3.Napisz program, który prosi użytkownika o podanie imienia, a następnie o podanie nazwiska(w dwóch krokach -najpierw samo imię, potem samo nazwisko).
                        Następnie program ma wyświetlić komunikat: "Zalogowany użytkownik: IMIĘ NAZWISKO"

                        Console.WriteLine("Podaj swoje imie");
                        string imie = Console.ReadLine().ToUpper();

                        Console.WriteLine("Podaj swoje nazwisko");
                        string nazwisko = Console.ReadLine().ToUpper();

                        Console.WriteLine("Zalogowany użytkownik: " + imie + " " + nazwisko);

                                4. Napisz program, który oblicza objętość sześcianu o boku długości podanej przez użytkownika, 
                        wynik zapisuje do nowej zmiennej i wyświetla go.

                        Console.WriteLine("Podaj długość boku:");
                        double bok = double.Parse(Console.ReadLine());

                        double objetosc = Math.Pow(bok, 3);

                        //Console.WriteLine();
                        Console.WriteLine("\nObjętość sześcianu wynosi: " + objetosc + "cm^3");

                                5. Napisz program, który liczy "deltę" na podstawie wprowadzonych przez użytkownika wartości parametrów b, a, c

                        Console.Write("Podaj liczbe b ");
                        double b = double.Parse(Console.ReadLine());

                        Console.Write("Podaj liczbe a ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Podaj liczbe c ");
                        double c = double.Parse(Console.ReadLine());

                        double delta = Math.Pow(b, 2) - 4 * a * c;
                        Console.WriteLine("\nDelta = " + delta);

                                6. Napisz program, który liczy pole koła o promieniu podanym przez użytkownika.

                        Console.Write("Podaj wartość promienia ");
                        double promien = double.Parse(Console.ReadLine());
                        double pole = Math.PI * Math.Pow(promien, 2);
                        Console.WriteLine("Pole kola = " + pole);

                                7. Napisz program, liczący pole trapezu o długościach podstaw i wysokości podanej przez użytkownika.

                        Console.Write("Podaj długość dłuższej podstawy ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Podaj długość krótszej podstawy ");
                        double b = double.Parse(Console.ReadLine());

                        Console.Write("Podaj długość wysokości ");
                        double h = double.Parse(Console.ReadLine());

                        double pole = (a + b) * h / 2;
                        Console.WriteLine("\nPole = " + pole);

                                8. Napisz program, który pobierze od użytkownika przejechany dystans w kilometrach oraz czas podróży w minutach, 
                        a następnie obliczy średnią prędkość w km/h.

                        Console.Write("Podaj przejechany dystans w kilometrach ");
                        double km = double.Parse(Console.ReadLine());

                        Console.Write("Podaj czas podróży w minutach ");
                        double minuty = double.Parse(Console.ReadLine());

                        double wynik = km / (minuty / 60);
                        Console.WriteLine("\n Śrenia przędkość w km/h wynosi " + wynik);

                                9.Pobierz od użytkownika liczbę całkowitą. Jeśli będzie to liczba parzysta, wyświetl komunikat "Jest parzysta".
                        W przeciwnym wypadku - komunikat "Nie jest parzysta".

                        Console.Write("Podaj liczbę całkowitą ");
                        int liczba = int.Parse(Console.ReadLine());

                        if (liczba % 2 == 0)
                        {
                            Console.WriteLine("\nLiczba Parzysta");

                        }
                        else
                            Console.WriteLine("\nLiczba nie parzysta");

                                10.Napisz program, który pobiera od użytkownika dwie liczby i wyświetla komunikat o tym, 
                        która z nich jest większa (ewentualnie, że są równe).

                        Console.Write("Podaj I liczbe: ");
                        int liczba1 = int.Parse(Console.ReadLine());

                        Console.Write("Podaj II liczbe: ");
                        int liczba2 = int.Parse(Console.ReadLine());

                        if (liczba1>liczba2)
                        {
                            Console.WriteLine("\nI liczba jest większa od II");
                        }
                        else if (liczba1 == liczba2)
                        {
                            Console.WriteLine("\nLiczbe są równe");
                        }
                        else
                            Console.WriteLine("\nII liczba jest większa od I");
                            /*
                                11. Napisz program, który liczy wartość bezwzględną z dowolnej liczby

                        Random losowe= new Random();
                        int liczba = losowe.Next(234) ;

                        Console.WriteLine("Liczba = "+ liczba);
                        if (liczba<0)
                        {
                            int licba1 = liczba * (-1);
                            Console.WriteLine("Wartość bezwzględna = " + licba1);
                        }
                        else
                            Console.WriteLine("Wartość bezwzględną = " + liczba);

                                12.Napisz program, który wyświetli nazwę dnia tygodnia, odpowiadającego wprowadzonemu przez użytkownika numerowi

                        Random los = new Random();
                        byte dzien = (byte)los.Next(1,10);
                        Console.Write(dzien + " dzień w tygodniu to ");

                        switch (dzien)
                        {
                            case 1:
                                Console.WriteLine("Poniedziałek");
                                break;
                            case 2:
                                Console.WriteLine("Wtorek");
                                break;
                            case 3:
                                Console.WriteLine("Środa");
                                break;
                            case 4:
                                Console.WriteLine("Czwartek");
                                break;
                            case 5:
                                Console.WriteLine("Piątek");
                                break;
                            case 6:
                                Console.WriteLine("Sobota");
                                break;
                            case 7:
                                Console.WriteLine("Niedziela");
                                break;

                            default:
                                Console.WriteLine("Błąd! W tygodniu tylko 7 dni");
                                break;
                        }
                                13. Napisz program, który będzie symulacją systemu przydzielania stypendium studentowi. Program ma wyświetlać informację o tym, 
                        czy użytkownikowi o podanej przez użytkownika średniej ocen (dokładność do dwóch miejsc po przecinku) przysługuje stypendium 
                        i - jeśli tak - to w jakiej wysokości. Przyjmij następujące kryteria:

                        Console.WriteLine("Podaj średnią ocene");
                        double srednia = Math.Round(double.Parse(Console.ReadLine()),2);

                        if (srednia >= 4.56)
                        {
                            Console.WriteLine("Użytkowniku przysługuje stypendium w wysokości 400 zł, ponieważ on ma ocene " + srednia);
                        }
                        else if (srednia >=4.26 && srednia<=4.55)
                        {
                            Console.WriteLine("Użytkowniku przysługuje stypendium w wysokości 300 zł ponieważ on ma ocene " + srednia);
                        }
                        else if (srednia >=4.01 && srednia <=4.25)
                        {
                            Console.WriteLine("Użytkowniku przysługuje stypendium w wysokości 200 zł ponieważ on ma ocene " + srednia);
                        }

                        else
                            Console.WriteLine("Użytkowniku nie przysługuje się stypendium ponieważ on ma ocene " + srednia);

                                14.Napisz program, który sprawdza, czy podany rok jest rokiem przestępnym


                        Console.WriteLine("Podaj rok");
                        int rok = int.Parse(Console.ReadLine());

                        if (rok%4 == 0 && rok%100 !=0 || rok%400 ==0)
                        {
                            Console.WriteLine(rok + " jest przestępnym");
                        }
                        else
                            Console.WriteLine(rok + " nie jest przestępczym");

                                15. Wyznaczyć date wielkanocy 

                        Console.WriteLine("Podaj rok");
                        int rok = int.Parse(Console.ReadLine());

                        int a = rok % 19;
                        int b = rok % 4;
                        int c = rok % 7;

                        int x = 0, y = 0, d = 0, e = 0, f = 0, g = 0;

                        if (rok < 1583)
                        {
                            x = 15;
                            y = 6;
                        }
                        else if (rok >= 1583 && rok < 1700)
                        {
                            x = 22;
                            y = 2;
                        }
                        else if (rok >= 1700 && rok < 1800)
                        {
                            x = 23;
                            y = 3;
                        }
                        else if (rok >= 1800 && rok < 1900)
                        {
                            x = 23;
                            y = 4;
                        }
                        else if (rok >= 1900 && rok < 2100)
                        {
                            x = 24;
                            y = 5;
                        }
                        else if (rok >= 2100 && rok < 2200)
                        {
                            x = 24;
                            y = 6;
                        }

                        d = (19 * a + x) % 30;
                        e = (2 * b + 4 * c + 6 * d + y) % 7;
                        f = 22 + d + e;
                        g = d + e - 9;

                        Console.WriteLine();
                        if (f <= 31)
                        {
                            Console.WriteLine("Wielkanoc będzie {0} marca", f);
                        }
                        else if ((g == 25 || g == 26) && a <=11 )
                        {
                            Console.WriteLine("Wielkanoc będzie 19 kwietnia");
                        }
                        else
                            Console.WriteLine("Wielkanoc będzie {0} kwietnia", g);
            */

        }
    }
}
