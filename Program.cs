using System;

namespace Lab2ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Scrieti o functie care va determina daca un numar este sau nu numar prim. 
             * Apelati-o si afisati-i rezultatul
             */
            /*
             * un numar este prim daca nu e divizibil cu nici un numar prim< radacina lui- prea complicat
             * un numar este prim daca nu e divizibil decat cu el sau 1 - suficient de verificat pana la radacina lui
             * */

            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());

            if (EstePrim(n))
            {
                Console.WriteLine("numarul " + n + " este prim");
            }
            else
            {
                Console.WriteLine("numarul " + n + " nu este prim");
            }
        }

        static bool EstePrim(int n)
        {
            bool result = true;
            int zecimale = n;
            double radacina = Math.Sqrt(n);


            for (int i = 2; i <= radacina ; i++)
            {
                zecimale = n % i;

                if (zecimale==0)
                {
                    result = false;
                    return result;
                }

                
            }

            return result;


        }


    }
}
