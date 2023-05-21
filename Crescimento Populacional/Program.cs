using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Crescimento_Populacional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double somaPA = 0, somaPB = 0;
            int anos = 0;
            int T = int.Parse(Console.ReadLine());
            for(int i = 0; i < T; i++)
            {
                string[] Populacao = Console.ReadLine().Split(' ');
                 int PA = int.Parse(Populacao[0]);
                 int PB = int.Parse(Populacao[1]);
                 double G1 = double.Parse(Populacao[2], CultureInfo.InvariantCulture);
                 double G2 = double.Parse(Populacao[3], CultureInfo.InvariantCulture);
                while (PA <= PB)
                {
                    somaPA = PA * G1;
                    somaPA /= 100;
                    PA += (int)(somaPA);

                    somaPB = PB * G2;
                    somaPB /= 100;
                    PB += (int)(somaPB);
                    anos++;
                   
                }
                Console.WriteLine(anos > 100 ? "Mais de 1 seculo" : anos + " anos.");
            }
            Console.ReadKey();
        }
    }
}
