using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6WynikDzieleniaReszta
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 37;
            int b = 11;
            int wynik = 0;
            Console.WriteLine("Program oblicza resztę dzielenia dla liczb 37 i 11");
            wynik = a % b; 
            Console.WriteLine("Reszta z dzielenia liczb wynosi: {0}", wynik);
            Console.ReadLine();
        }
    }
}
