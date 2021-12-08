using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Paskaita_Uzduotys
{
    internal class Program
    {
        public struct Mokinys
        {
            public string Vardas;
            public string Pavarde;
            public string KursoPradzia;
            public string KursoPabaiga;
        }
        public struct BibliotekosKnyga
        {
            public int ID;
            public string Pavadinimas;
            public string SkaitytojoVardas;
            public static DateTime Data;

            public BibliotekosKnyga(int id, string pavadinimas, string skaitytojoVardas, DateTime data)
            {
                ID = id;
                Pavadinimas = pavadinimas;
                SkaitytojoVardas = skaitytojoVardas;
                Data = data;
            }

            public int KiekDienu()
            {
                DateTime today = DateTime.Today;
                int dienuSkaicius = (today - Data).Days;

                return dienuSkaicius;
            }
        }
        
        static void Main(string[] args)
        {
            //Task1
            Mokinys mokinys = new Mokinys();
            mokinys.Vardas = "Vladas";
            mokinys.Pavarde = "Vladislavas";
            mokinys.KursoPradzia = "Geguzes 1";
            mokinys.KursoPabaiga = "Geguzes 2";
            Console.WriteLine($"{mokinys.Vardas} {mokinys.Pavarde} {mokinys.KursoPradzia} {mokinys.KursoPabaiga}");

            //Task2

            BibliotekosKnyga knyga = new BibliotekosKnyga(007, "Bondo nuotykiai", "Petras", new DateTime(2021,10,01));
            //knyga.Data = new DateTime(2021, 12, 06);
            int dienos = knyga.KiekDienu();
            Console.WriteLine($"Knyga laikote jau {dienos} dienas");






        }
    }
}
