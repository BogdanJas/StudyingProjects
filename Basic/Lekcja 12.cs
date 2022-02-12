using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Lekcja12

    {
        //zad1
        /*
         static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\");
           FileInfo[] wykazPlikow = di.GetFiles();
            int licznik = 0;
            
            //A)
            foreach (FileInfo fi in wykazPlikow)
            {
                if (fi.Name.Contains(".txt"))
                {
                    licznik++;
                }
            }
            */
            //B)
            /*
            foreach (FileInfo fi in wykazPlikow)
            {
                if (fi.Extension == ".txt")
                {
                    licznik++;
                }
                
            }
            
            //C)
            
            foreach (var fi in di.GetFiles("*.txt"))
            {
                
                licznik++;
            }
                Console.WriteLine("W katalogu jest {0} plików tekstowych",licznik);
        }
        */

        //zad2

    }
}
