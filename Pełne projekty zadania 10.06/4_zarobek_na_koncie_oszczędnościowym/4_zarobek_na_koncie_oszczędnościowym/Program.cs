using System;

public class MyProgram
{
    static void Main()
    {
        decimal kp, opr, kz;
        int lm;
        Console.WriteLine("Podaj kwotę początkową");
        kp = inputValue();
        Console.WriteLine("Podaj oprocentowanie w skali roku");
        opr = inputValue();
        Console.WriteLine("Podaj liczbę miesięcy oszczędzania");
        lm = int.Parse(Console.ReadLine());

        kz = Zarobek(kp, opr, lm);

        Console.WriteLine($"Kwota zarobiona (z uwzględnieniem podatku Belki) wynosi {kz}");
    }

    static decimal Zarobek(decimal kp, decimal opr, int lm)
    {
        decimal opm = opr / 12 / 100;
        decimal kz = kp * (decimal)Math.Pow(1 + (double)opm, lm);

        kz = kz - (decimal)(0.19 * (double)(kz - kp));

        return kz;
    }

    private static decimal inputValue()
    {
        decimal result;
        while (!decimal.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}