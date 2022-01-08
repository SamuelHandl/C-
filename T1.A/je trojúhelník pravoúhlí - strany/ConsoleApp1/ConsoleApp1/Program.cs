using System;
//Handl Samuel
//tento program bere input od uživatele a vypočítá z něho jestli se z konstanty dá vytvořit pravoúhlý trojúhelník
namespace Seminárka
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vložte konstanty pro tři strany trojúhelníku");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            // Kontrola zda jsou všechny strany větší než nula
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Neplatný vstup, žádná strana nesmí mít nulovou nebo zápornou délku");
            }

            // kontrola zda lze trojúhelník sestavit
            else if ((a + b > c && b + c > a && a + c > b) == false)
            {
                Console.WriteLine("Neplatný vstup trojúhelník nelze sestrojit");
            }

            // Kontrola zda je trojúhelník pravoúhlý
            else if (Program.isRightAngle(a, b, c))
            {
                Console.WriteLine("Zadané strany tvoří pravoúhlý trojúhelník");

            }

            else
            {
                Console.WriteLine("Zadané strany netvoří pravoúhlý trojúhelník");

            }
        }   
        static bool isRightAngle(int a, int b, int c)
        {
            bool isRightAngle = false;
            int longestSide = Program.max(a, b, c);
            int sideC = longestSide;
            int sideB;
            int sideA;
            if (longestSide == a)
            {
                sideA = b;
                sideB = c;

            }
            else if (longestSide == b)
            {
                sideA = a;
                sideB = c;

            }
            else
            {
                sideA = a;
                sideB = b;    
            }

            if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2))
            {
                isRightAngle = true;

            }
            return isRightAngle;
        }
        static int max(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);

        }
    }
}
