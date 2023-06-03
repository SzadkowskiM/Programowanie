using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a,b,c, srednia;

	Console.WriteLine(Podaj a");
        a = inputValue();
	Console.WriteLine(Podaj b");
        b = inputValue();
	Console.WriteLine(Podaj c");
        c = inputValue();

        srednia = (a + b + c) / 3;
        Console.WriteLine($"Średnia wynosi :{srednia}");
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
