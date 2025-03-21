using System;

class Program
{
    static void Main()
    {
        int[] grades = new int[10];
        int max = 0;

        int min = 100;
        int total = 0; 

        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write($"Shkruj noten {i + 1}: ");
            grades[i] = int.Parse(Console.ReadLine());

            total = total + grades[i]; 

            if (grades[i] > max) max = grades[i];
            if (grades[i] < min) min = grades[i];
        }

        Console.WriteLine("\nNotat e futura:");
        for (int i = 0; i < grades.Length; i++)

            Console.WriteLine(grades[i]);


        Console.WriteLine($"\nNota me e larte: {max}");
        Console.WriteLine($"Nota me e ulet: {min}");

        Console.WriteLine($"Mesatarja eshte : {(double)total / grades.Length:F2}");
    }
}
