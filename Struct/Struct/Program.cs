using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Program
    {
        public struct Metinis
        {
            public int Pirmas;
            public int Antras;
            public int Trecias;

            public Metinis(int pirmas, int antras, int trecias)
            {
                Pirmas = pirmas;
                Antras = antras;
                Trecias = trecias;
            }

            public double IsvestiVidurki() => (Pirmas + Antras + Trecias) / 3;

        }
        
        static void Main(string[] args)
        {
            Metinis metinis = new Metinis(10, 10, 9);
            double vidurkis = metinis.IsvestiVidurki();
            Console.WriteLine($"Metinis vidurkis: {vidurkis}");
            Console.ReadKey();
        }
    }
}
