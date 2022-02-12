using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    1. Napisz program, który będzie pobierał od użytkownika liczby i sumował je tak długo, aż użytkownik wpisze 0. Na końcu ma zostać wyświetlona suma.
                    2. Rozbuduj kod powyższego programu tak, by oprócz sumy wprowadzonych liczb program wyliczył również ich średnią (wpisane na końcu 0 również wlicza się do średniej).

            int liczba = 0;
            int suma = 0;
            int ilosc = 0;
            do
            {
                Console.Write("Podaj liczbę ");
                liczba = int.Parse(Console.ReadLine());
                suma += liczba;
                ilosc++;
            } while (liczba != 0);

            double srednia = (double)suma / ilosc;
            Console.WriteLine("\nPodałeś liczbe 0 \nSuma wszystkich liczb = {0} \nŚrednia = {1}",suma,srednia  );

                    3.Napisz program, który liczy wartość silni z liczby podanej przez użytkownika.


            Console.Write("Podaj liczbe: ");
            int liczba = int.Parse(Console.ReadLine());
            int silnia = 1;

            for (int i = 1; i <= liczba; i++)
            {
                silnia *= i;
            }

            Console.WriteLine("Wartość silni = {0}",silnia );

                    4.Napisz program, który wyświetla tabliczkę mnożenia w tradycyjnej formie tabeli, gdzie wynik mnożenia znajduje się na przecięciu odpowiedniego wiersza i kolumny. Wartość n podaje użytkownik na wejściu.


            Console.Write("Podaj liczbe: ");
            int liczba = int.Parse(Console.ReadLine());
            int iloczyn = 1;

            for (int i = 1; i <= liczba ; i++)
            {
                for (int j = 1; j <= liczba; j++)
                {
                    iloczyn = i * j;
                    Console.Write("\t{0}", iloczyn);
                }
                Console.WriteLine();
            }

                    5.Napisz programy, których efekty działania będą następujące(liczba wierszy pobierana od użytkownika na wejściu):

            Console.Write("Podaj liczbe: ");
            int liczba = int.Parse(Console.ReadLine());

            Console.WriteLine("a)");
            Console.WriteLine();

            for (int i = 0; i < liczba; i++)
            {
                for (int j = 0; j < liczba; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nb)");

            for (int i = 0; i < liczba; i++)
            {
                for (int j = 0; j < liczba; j++)
                {
                    if (j<=i)
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nc)");

            for (int i = 0; i < liczba; i++)
            {
                for (int j = 0; j < liczba; j++)
                {
                    if (j <= i)
                    {
                        Console.Write("  ");
                    }
                    else Console.Write("* ");
                }
                Console.WriteLine();
            }

                    6.Napisz prostą grę, której zasady są następujące:
                        - Program losuje dowolną liczbę całkowitą z zakresu 1 - 50.
                        - Użytkownik próbuje odgadnąć, jaka liczba została wylosowana i podaje swój typ
                        - Program wyświetla komunikat "Za dużo" lub "Za mało" i użytkownik zgaduje dalej
                        -Gdy liczba zostanie odgadnięta, program wyświetla komunikat: "Gratulacje!"

            Random los = new Random();
            int zmienna = los.Next(1, 51);
            int liczba = 0;
            int i = 0;

            do
            {
                Console.Write("Podaj liczbe: ");
                liczba = int.Parse(Console.ReadLine());

                if (liczba > zmienna)
                {
                    Console.WriteLine("Za dużo");
                }
                else if(liczba<zmienna)
                {
                    Console.WriteLine("Za mało");
                }
                Console.WriteLine();
                i++;
            } while (liczba != zmienna);

            Console.WriteLine("Gratulacje! \nPodjęto prób {0}",i);

                    7. Napisz program, który sprawdza, czy liczba wprowadzona przez użytkownika jest liczbą pierwszą

            Console.Write("Podaj liczbe");
            int i = int.Parse(Console.ReadLine());

            if (i <= 3 && i >= 1)
            {
                Console.WriteLine("Liczba jest liczbą pierwszą");

            }
            else
            {

                for (int a = 2; a <= Math.Sqrt(i); a++)
                {
                    double b = i % a;

                    Console.WriteLine(b);

                    if (b != 0)
                    {
                        Console.WriteLine("Liczba jest liczbą pierwszą");
                        break;
                    }

                    else if (b == 0)
                    {
                        Console.WriteLine("Liczba jest liczbą złożoną");
                        break;
                    }
                }
            }

                    8. Napisz program, który do zmiennej tekstowej dodaje kolejne wprowadzane przez użytkownika znaki. W momencie, kiedy użytkownik wpisze znak 'x' lub gdy poda 6 znaków, program ma wyświetlić sklejony tekst.

            Console.WriteLine("Podaj znak");
            string słowo = Console.ReadLine();
            char znak;
            do
            {
                znak = char.Parse(Console.ReadLine());
                słowo += znak;

            } while (znak !='x' && słowo.Length !=6 );

            string słowo1 = słowo.ToUpper();
            Console.WriteLine("twoje słowo to {0}",słowo1);

                    9. Użytkownik ma możliwość wyboru ustalenia stawki dziennej systemu wynagrodzeń
                            Wariant 1: za każdą przepracowaną godzinę otrzymuje 50 zł,
                            Wariant 2: za pierwszą przepracowaną godzinę otrzymuje 10 groszy, za każdą następną podwojoną kwotę do tej pory zarobionych pieniędzy.

                        Użytkownik podaje liczbę przepracowanych godzin (1-12). Program ma wskazać, który wariant jest dla niego bardziej korzystny

             początek:;
                Console.Write("Podaj ilość przepracowanych godzin ");
                int godziny = int.Parse(Console.ReadLine());
                double wariant1 = 0;
                double wariant2 = 0.1;
                double poprzednia = 0;

                if (godziny >12 || godziny <1)
                {
                    Console.WriteLine("Podałeś błędną liczbę");
                    goto początek;
                }
                else
                {
                    wariant1 = 50 * godziny;
                    do
                    {

                        wariant2 = (2 * poprzednia) + wariant2;
                        poprzednia = wariant2;
                        godziny--;

                    } while (godziny != 0);

                    if (wariant1>wariant2)
                    {
                        Console.WriteLine("Lepiej wybrać wariant1, Pan zarobie na {0} zł więcej", (Math.Round(wariant1,2)-Math.Round(wariant2,2)));
                    }
                    else if (wariant1<wariant2)
                    {
                        Console.WriteLine("Lepiej wybrać wariant2, Pan zarobie na {0} zł więcej", (Math.Round(wariant2, 2) - Math.Round(wariant1, 2)));
                    }
                    else
                        Console.WriteLine("Zarobisz jednakową kwote");
                }

                        10.Napisz program, który wyświetla wartość pierwiastka z liczby całkowitej podanej przez użytkownika.

            begin:;
                Console.Write("Podaj liczbę ");
                int zmienna = 0;
                bool logiczna = int.TryParse(Console.ReadLine(), out zmienna);

                if (logiczna == true)
                    Console.WriteLine(Math.Sqrt(zmienna));
                else
                {
                    Console.WriteLine("Nie podałes liczbe całkowitą\n");
                    goto begin;
                }
                    11. Napisz program, który liczy wartość n-tego elementu ciągu Fibonacciego. Wartość n podaje użytkownik.

            begin:;
                Console.Write("Podaj liczbę ");
                int zmienna = 0;
                int wartosc = 1;
                int poprzedni = 0;
                bool logiczna = int.TryParse(Console.ReadLine(), out zmienna);

                if (logiczna == false)
                {
                    Console.WriteLine("Nie podałes liczbe całkowitą\n");
                    goto begin;
                }
                else
                {
                    if (zmienna < 0)
                    {
                        Console.WriteLine("Niema takiego elementu w ciągu");
                    }
                    else
                        if (zmienna == 0)
                    {
                        Console.WriteLine("Wartość {0}-tego elementu wynosi 0",zmienna);
                    }
                    else if (zmienna == 1 || zmienna == 2)
                    {
                        Console.WriteLine("Wartość {0}-tego elementu wynosi 1", zmienna);
                    }
                    else
                    {
                        for (int i = 2; i <= zmienna; i++)
                        {
                            wartosc += poprzedni;
                            poprzedni =wartosc-poprzedni;

                        }

                        Console.WriteLine("Wartość {0}-tego elementu wynosi {1}", zmienna,wartosc);
                    }
                }

                        12. Napisz program, który obliczy sumę cyfr z liczby wprowadzonej przez użytkownika 

            Console.Write("Podaj liczbę ");
            int liczba = int.Parse(Console.ReadLine());
            int liczba1 = liczba;
            int suma = 0;

            do
            {
                int zmienna = liczba % 10;
                suma += zmienna;
                liczba /= 10;
            } while (liczba%10 !=0);

            Console.WriteLine("Suma cyfr z {0} = {1}",liczba1,suma);
            
                    13.Napisz program, który pobiera od użytkownika 10 imion, a następnie wyświetla te imiona, których długość jest większa niż 5 liter.
        
            string[] imiona = new string[10];
            Console.WriteLine("Podaj nazwiska");

            for (int i = 0; i < imiona.Length; i++)
            {
                imiona[i] = Console.ReadLine();
            }

            for (int i = 0; i < imiona.Length; i++)
            {
                if (imiona[i].Length > 5)
                {
                    Console.WriteLine("Imie {0}: {1}",(i+1),imiona[i]);
                }
            }
            
                    14.Napisz program, który pobiera od użytkownika 5 liczb typu byte i zapisuje je w tablicy, a następnie tworzy nową tablicę, w której kolejność elementów jest odwrotna niż w pierwszej.
                
            byte[] tablica = new byte[5];
            byte[] nowa = new byte[tablica.Length];

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = byte.Parse(Console.ReadLine());
                
            }

            for (int i = 0; i< tablica.Length; i++)
            {
                nowa[i] = tablica[tablica.Length-i-1];
            }

                    15. Do 10-elementowej tablicy typu int zapisz dowolne wartości - dodatnie i niedodatnie. Następnie do nowej tablicy program ma zapisać tylko te elementy, które są dodatnie, zaś zamiast pozostałych ma wpisać wartość 0.
            
            int[] tablica = new int[10];
            int[] nowa = new int[tablica.Length];

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = int.Parse(Console.ReadLine());
                
            }

            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] < 0)
                {
                    nowa[i] = 0;
                }
                else
                nowa[i] = tablica[i];
            }
            Console.Write("\t Tablica1: ");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write("\t{0} ",tablica[i]);
            }
            Console.WriteLine();
            Console.Write("\t Tablica2: ");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write("\t{0} ", nowa[i]);
            }
                    16. Napisz program, który będzie wyszukiwał maksymalny i minimalny element tablicy 10-elementowej. Zakładamy, że wartości w tablicy się nie powtarzają.

            int[] tablica = new int[10];
            tablica[0] = int.Parse(Console.ReadLine());
            int min = tablica[0];
            int max = tablica[0];

            for (int i = 1; i < tablica.Length-1; i++)
            {
                tablica[i] = int.Parse(Console.ReadLine());

                if (tablica[i] > max)
                {
                    max = tablica[i];
                }
                else if (tablica[i] < min)
                    min = tablica[i];
            }
            Console.Write("Min: {0};\nMax: {1}",min,max);

            */

        }
    }
}
