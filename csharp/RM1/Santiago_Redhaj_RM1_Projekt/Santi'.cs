using System;

class Program
{
    static void Main()
    {
    
        decimal pragKalimi = 60m; 

        do
        {
         
            decimal piketDetyra = MerrPiket("detyrat");
            decimal piketKuiz = MerrPiket("kuizet");
            decimal piketProvim = MerrPiket("provimin");

        
            decimal notaMesatare = LlogaritNotaMesatare(piketDetyra, piketKuiz, piketProvim);

            ShfaqNotaMesatare(notaMesatare);

            KontrolloMesazhinKalimit(notaMesatare, pragKalimi);

            ShfaqNota(notaMesatare);

            Console.Write("Do llogarisesh nxenes tjeter (po/jo): ");
        } while (Console.ReadLine().Trim().ToLower() == "po");
    }

    static decimal MerrPiket(string tipi)
    {
        Console.Write($"Shkruani pikët për {tipi}: ");
        return Convert.ToDecimal(Console.ReadLine());
    }

    static decimal LlogaritNotaMesatare(decimal piketDetyra, decimal piketKuiz, decimal piketProvim)
    {
        return (piketDetyra + piketKuiz + piketProvim) / 3;
    }

    static void ShfaqNotaMesatare(decimal notaMesatare)
    {
        Console.WriteLine($"\nPiket jane: {notaMesatare:F2}");
    }

    static void KontrolloMesazhinKalimit(decimal notaMesatare, decimal pragKalimi)
    {
        if (notaMesatare >= pragKalimi)
        {
            Console.WriteLine("Nxenesi kalon klasen");
        }
        else
        {
            Console.WriteLine("Nxenesi nuk kalon");
        }
    }

    static void ShfaqNota(decimal notaMesatare)
    {
        char nota;

        if (notaMesatare >= 90 && notaMesatare <= 100)
        {
            nota = 'A';
        }
        else if (notaMesatare >= 80 && notaMesatare < 90)
        {
            nota = 'B';
        }
        else if (notaMesatare >= 70 && notaMesatare < 80)
        {
            nota = 'C';
        }
        else if (notaMesatare >= 60 && notaMesatare < 70)
        {
            nota = 'D';
        }
        else
        {
            nota = 'F';
        }

        Console.WriteLine($"Nota: {nota}");
    }
}
