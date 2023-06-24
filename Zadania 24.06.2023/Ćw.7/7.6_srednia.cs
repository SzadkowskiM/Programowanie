using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj wielkość tablicy:");
        int wielkosc = int.Parse(Console.ReadLine());
        double[] tablica = new double[wielkosc];
        Random rand = new Random();
        for (int i = 0; i < wielkosc; i++)
        {
            tablica[i] = rand.NextDouble() * 100;
        }
        Console.WriteLine("Wyrazy z tablicy to:");
        Console.WriteLine();
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write("\t" + tablica[i]);
        }
        double srednia = ObliczSrednia(tablica, wielkosc);
        Console.WriteLine("\nŚrednia arytmetyczna: " + srednia);

    }
    public static double ObliczSrednia(double[] tablica, int rozmiar)
    {
        if (rozmiar == 0)
        {
            return 0;
        }
        double suma = ObliczSrednia(tablica, rozmiar - 1) * (rozmiar - 1) + tablica[rozmiar - 1];
        return suma / rozmiar;
    }
}