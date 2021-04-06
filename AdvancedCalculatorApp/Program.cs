using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.Write("x: ");
                string x = Console.ReadLine();

                Console.Write("n: ");
                string n = Console.ReadLine();

                int iX = Convert.ToInt32(x);

                int iN = Convert.ToInt32(n);

                int outputFOR = CalculateFOR(iX, iN);

                Console.WriteLine($"S = {outputFOR} /výsledek vypočítán pomocí for cyklu/");

                int outputWhile = CalculateWhile(iX, iN);

                Console.WriteLine($"S = {outputWhile} /výsledek vypočítán pomocí while cyklu/");

                int outputDoWhile = CalculateDoWhile(iX, iN);

                Console.WriteLine($"S = {outputDoWhile} /výsledek vypočítán pomocí do while cyklu/");

                int outputRecursive = CalculateRecursive(iX, iN);

                vysledek = 1;
                i = 1;
                faktorial = 1;

                Console.WriteLine($"S = {outputRecursive} /výsledek vypočítán pomocí rekurze/");

                Console.ReadLine();
            }
        }

        static int CalculateFOR(int inX, int inN)
        {
            int vysledek = 1;
            int faktorial = 1;

            for (int i = 1; i <= inN; i++)
            {
               faktorial *= i;
               vysledek += i * inX / faktorial;
            }

            return vysledek;
        }

        static int CalculateWhile(int inX, int inN)
        {
            int vysledek = 1;
            int i = 1;
            int faktorial = 1;
            while (i <= inN)
            {
                faktorial *= i;
                vysledek += i * inX / faktorial;
                i++;
            }

            return vysledek;
        }

        static int CalculateDoWhile(int inX, int inN)
        {
            int vysledek = 1;
            int i = 1;
            int faktorial = 1;
            do
            {
                faktorial *= i; 
                vysledek += i * inX / faktorial;
                i++;
            } while (i <= inN);

            return vysledek;
        }

        static int vysledek = 1;
        static int i = 1;
        static int faktorial = 1;
        static int CalculateRecursive(int inX, int inN)
        {
            if(i <= inN)
            {
                faktorial *= i;
                vysledek += i * inX / faktorial;
                i++;
            }
            else
            {
                
                return vysledek;
            }
            
            return CalculateRecursive(inX, inN);
        }
    }
}
