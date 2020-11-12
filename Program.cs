using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace budicMarinPonavljanjeZadatak6ž
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niz=new int[100];
            Console.WriteLine("Upisuj brojeve za niz, a za kraj pritisni k ");
            char k;
            int i = 0;
            k = Console.ReadKey().KeyChar;
            while (k!='k')
            {
                niz[i] = Convert.ToInt32(k);
                i++;
                k = Console.ReadKey().KeyChar;
            }
            Array.Sort(niz);
            foreach (int broj in niz)
            {
                Console.WriteLine(broj);
            }

        }
    }
}
