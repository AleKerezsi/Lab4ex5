using System;

namespace Lab4ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n, apelati-o si afisati-i rezultatul.*/

            Console.WriteLine("Introduceti n= ");
            int n = int.Parse(Console.ReadLine());

            int rezultat = CalculeazaSumaNumerelor(1, n);
            Console.WriteLine("Suma numerelor este: "+ rezultat);

        }

        static int CalculeazaSumaNumerelor(int x, int suma)
        {
            if (x == suma)
                return suma;
            return suma + CalculeazaSumaNumerelor(x, suma - 1);
        }
    }

}
