using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Podaj liczbe naturalną");
        a = inputValue();
        if (a > 0)
        {
            b = a;
            c = a % 10;
            Console.WriteLine($"Ostatnia cyfra liczby {b} to {c}");
        } else
        {
            Console.WriteLine("Podana liczba nie jest liczbą naturalną");
        }
    }
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
