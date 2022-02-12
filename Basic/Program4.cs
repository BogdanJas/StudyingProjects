using System;

namespace ConsoleApp2
{
    class Program
    {
        /*
        static float Cash()
        {
            float cash;

            do
            {
                Console.WriteLine("Podaj liczbe");
                cash = float.Parse(Console.ReadLine());
            } while (cash < 0);
            return cash;
        }
        static void Main(string[] args)
        {
            int licznik = 0;
            float cash = MathF.Round(Cash(),2);
            

            while (cash >=0.25f)
            {
                cash = MathF.Round(cash - 0.25f, 2);
                licznik++;
            }

            while (cash>=0.1f)
            {
                cash = MathF.Round(cash - 0.1f, 2);
                licznik++;
            }

            while (cash >= 0.05f)
            {
                cash = MathF.Round(cash - 0.05f, 2);
                licznik++;
            }

            while (cash >= 0.01f)
            {
                cash = MathF.Round(cash - 0.01f, 2);
                licznik++;
            }

          
            Console.WriteLine("Cah: " + cash);
            Console.WriteLine(licznik);
        }
    

        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
        }
        */
        static int SingleNumber(int[] nums)
        {
            int numContains = 0;
            int answear = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                numContains = nums[i];

                for (int j = i + 1; j <= nums.Length; j++)
                {
                    if (numContains == nums[j-1])
                        answear = nums[i];
                }
            }

            return answear;

            

        }

        static void Main(string[] args)
        {
            int[] tablica = { 4, 1, 2, 1, 2 };
            Console.WriteLine(SingleNumber(tablica));
        }





    }

}
