using System;
using System.Collections.Generic;

class Program
{
    static List<string> produktet = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Menaxhimi i Produkteve ---");
            Console.WriteLine("1. Shto Produkt");
            Console.WriteLine("2. Shfaq Produktet");
            Console.WriteLine("3. Fshi Produkt");
            Console.WriteLine("4. Dalje");
            Console.Write("Zgjedh opsionin: ");

            string zgjedhja = Console.ReadLine();

            switch (zgjedhja)
            {
                case "1":
                    ShtoProdukt();
                    break;
                case "2":
                    ShfaqProduktet();
                    break;
                case "3":
                    FshiProdukt();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opsion i pavlefshëm, provo përsëri!");
                    break;
            }
        }
    }

    static void ShtoProdukt()
    {
        Console.Write("Shkruaj emrin e produktit: ");
        string produkti = Console.ReadLine();
        produktet.Add(produkti);
        Console.WriteLine("Produkti u shtua me sukses!");
    }

    static void ShfaqProduktet()
    {
        Console.WriteLine("\n--- Lista e Produkteve ---");
        if (produktet.Count == 0)
        {
            Console.WriteLine("Asnjë produkt i disponueshëm!");
            return;
        }

        for (int i = 0; i < produktet.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {produktet[i]}");
        }
    }

    static void FshiProdukt()
    {
        ShfaqProduktet();

        Console.Write("Shkruaj numrin e produktit që dëshiron të fshish: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= produktet.Count)
        {
            produktet.RemoveAt(index - 1);
            Console.WriteLine("Produkti u fshi me sukses!");
        }
        else
        {
            Console.WriteLine("Numër i pavlefshëm!");
        }
    }
}