using System;

namespace ConsoleApp1
{
    class Lekcja7
    {/*
        static void Main(string[] args)
        {
            //Zadanie1
            //Pobierz od uїytkownika dowolny napis i oblicz, ile razy wystкpuje w nim litera 'e'.
            //Wykonaj zadanie w dwуch wariantach

            
            Console.WriteLine("Podaj tekst");
            string tekst = Console.ReadLine();
            string tekstWielki = tekst.ToUpper();
            int licznik = 0;

            for (int i = 0; i < tekst.Length-1; i++)
            {
                if (tekstWielki[i] == 'E')
                {
                    licznik++;
                }
            }


            foreach (var k in tekstWielki)
            {
                if (k == 'E')
                {
                    licznik++;
                }
            }
            Console.WriteLine("W tekście występuję {0} razy litera \"E\"",licznik);

            //zadanie2
            //Pobierz od uїytkownika wyraz i sprawdџ, czy jest on palindromem (czytany od przodu brzmi tak samo, jak czytany wstecz)

            Console.WriteLine("Podaj tekst");
            string tekst = Console.ReadLine();
            string tekstWielki = tekst.ToUpper();

            bool warunek = true;
            for (int i = 0; i < tekst.Length-1; i++)
            {
                if (tekstWielki[i] == tekstWielki[tekst.Length-1 - i])
                {
                    warunek = true;
                }
                else
                {
                    warunek = false;
                    break; 
                }

            }

            if (warunek == true)
            {
                Console.WriteLine("Słowo jest palindromem");
            }
            else
                Console.WriteLine("Słowo nie jest palindromem");

            //Zadanie3
            //Sprawdanie ciągu znaków

            ponownie:;
                Console.WriteLine("Podaj hasło");
                string haslo = Console.ReadLine();

                int liczba = 0;
                int znak = 0;
                int litera = 0;
                bool znak1 = false;



                if (haslo.Length > 8)
                {
                    if (haslo.IndexOf('#') <= haslo.Length || haslo.IndexOf('$') <= haslo.Length || haslo.IndexOf('%') <= haslo.Length)
                    {
                        znak++;
                    }

                    if (haslo.Contains('#') == true || haslo.Contains('$') == true || haslo.Contains('%') == true)
                    {
                        znak1 = true;
                    }

                    foreach (var k in haslo)
                    {
                        if (char.IsDigit(k))
                        {
                            liczba++;
                            continue;
                        }

                        if ((int)k >= 65 && (int)k <= 91)
                        {
                            litera++;
                        }
                    }

                    if (znak1 == true && liczba > 0 && litera > 0)
                    {
                        Console.WriteLine("Dzięki, twoje hasło jest zapisane");
                    }
                    else
                    {
                        Console.WriteLine("Hasło musi mieśczyć conajmniej \n\t1 wielką litere \n\t1 cyfrę \n\t1 znak \nSprawdż poprawność swojego hasła");
                        goto ponownie;
                    }

                }
                else
                {
                    Console.WriteLine("Hasło musi mieśczyć conajmniej \n\t8 znaków\n\t1 wielką litere \n\t1 cyfrę \n\t1 znak \nSprawdż poprawność swojego hasła");
                    goto ponownie;
                }

                //Zadanie4
                //Napisz program, ktуry sumuje wszystkie cyfry pojawiaj№ce siк w tekњcie podanym przez uїytkownika

                Console.WriteLine("Podaj tekst");
                string tekst = Console.ReadLine();

                int suma = 0;
                //sposób1
                for (int i = 0; i < tekst.Length-1; i++)
                {
                    if (char.IsDigit(tekst[i]))
                    {
                        int liczba = int.Parse(tekst[i].ToString());
                        suma += liczba;
                    }
                }
                //sposób2
                foreach (var k in tekst)
                {
                    if (char.IsDigit(k))
                    {
                        int liczba = int.Parse(k.ToString());
                        suma += liczba;
                    }
                }

                Console.WriteLine("Suma liczb wynosi {0}", suma);

            //Zadanie5
            //Napisz program, ktуry sprawdzi, czy towar posiadaj№cy 13-cyfrowy kod kreskowy EAN-13, wprowadzony przez uїytkownika, zostaі wyprodukowany w Polsce 
            //lub jest dystrybuowany przez polskie przedsiкbiorstwo
            ponownie:;
                Console.WriteLine("Podaj cod");
                long code;
                bool sprawdzanie = long.TryParse(Console.ReadLine(), out code);

                if (sprawdzanie == true)
                {

                    string codePisemny = code.ToString();
                    if (codePisemny.Length == 13)
                    {


                        if (codePisemny[0] == '5' && codePisemny[1] == '9' && codePisemny[2] == '0')
                        {
                            Console.WriteLine("Produkt wyprodukowano w Polsce");
                        }
                        else
                            Console.WriteLine("Produkt nie wyprodukowano w Polsce");
                    }
                    else
                    {
                        Console.WriteLine("Zamało liczb");
                        goto ponownie;
                    }
                }
                else
                {
                    Console.WriteLine("Zrobiłeś błąd");
                    goto ponownie;
                }
            //Zadanie6

            Console.WriteLine("Podaj tablice");
            string tablica = Console.ReadLine();
            Console.WriteLine("Podaj ciąg znaków");
            string ciag = Console.ReadLine();
            int liczba = 0;

            foreach (var litera in tablica)
            {
                foreach (var znak in ciag)
                {
                    if (litera == znak)
                    {
                        liczba++;
                    }
                                    }
                Console.WriteLine("\t{0} - {1}", litera, liczba);
                liczba = 0;
                
            }*/
        }
    }

