using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaziFeladat20240129
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Szavak = new List<string> { "fuvola", "csirke", "adatok", "asztal", "fogoly", "bicska", "farkas", "almafa", "babona", "gerinc", "dervis", "bagoly", "ecetes", "angyal", "boglya" };
            Random random = new Random();
            string Cel;
            string Tipp;
            string Valasz;
            int TippekSzama = 0;

            Cel = Szavak[random.Next(Szavak.Count)];
            while (true)
            {
                Console.Write("Tipp: ");
                Tipp = Console.ReadLine();
                if (Tipp == "stop")
                {
                    Console.WriteLine("Játék leállítva.");
                    Console.ReadKey();
                    break;
                }
                Valasz = valaszAdas(Cel, Tipp);
                Console.WriteLine("Válasz: " + Valasz);
                TippekSzama++;
                if (Valasz == Cel)
                {
                    Console.WriteLine($"Gratulálunk!\n Sikeresen kitaláltad a rejtettszavat!\n A rejtett szó ez volt: {Cel}\n És ennyit tippeltél:\n Tippek száma: {TippekSzama}");
                    Console.ReadKey();
                    break;
                }
            }
        }

        static string valaszAdas(string Cel, string Tipp)
        {
            string Valasz = "";
            for (int i = 0; i < Cel.Length; i++)
            {
                if (Cel[i] == Tipp[i])
                {
                    Valasz += Cel[i];
                }
                else
                {
                    Valasz += ".";
                }
            }
            return Valasz;
        }
    }
}

