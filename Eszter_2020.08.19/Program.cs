using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._08._19
{
    class Program
    {
        static void Main(string[] args)
        {
            //13. A program írja ki a felhasználó által megadott szám osztóit, 
            //illetve, hogy az adott számnak hány osztója van egyen és önmagán kívül.
            Console.Write("Kérem adjon meg egy egész számot! ");
            int szam = int.Parse(Console.ReadLine());
            Console.Write($"A {szam} osztói: ");
            int szamlalo = 0;//Összegzés törvénye
            for (int i = 2; i<= szam/2; i++)
            {
                if (szam % i == 0)
                {
                    Console.Write($"{i} ");
                    szamlalo++;
                }

            }
            Console.WriteLine();
            Console.Write($"A {szam}-nak {szamlalo} osztója van.");

            //14. Bekérünk a felhasználótól egy számot, majd a megadott számig kiírja a prímszámokat.
            Console.Write("Kérem adjon meg egy egész számot! ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write($"A prímszámok: ");
            for (int i = 2; i <= szam1; i++)
            {
                int szamlalo1 = 0;
                for (int j = 2;j<=szam1/2;j++)
                {
                    if (i % j == 0)
                    {
                        szamlalo1++;
                    }
                }
                if (szamlalo1 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.ReadKey();
        }
    }
}
