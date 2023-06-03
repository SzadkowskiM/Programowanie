using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        decimal x, y;
        Console.WriteLine("Podaj argument");
        x = inputValue();
        if (x <= -2)
        {
            y = -1;
            Console.WriteLine($"Wartość dla argumentu {x} wynosi {y}");
        }
        else if (x > -2 && x < -1)
        {
            y = x + 1;
            Console.WriteLine($"Wartość dla argumentu {x} wynosi {y}");
        }
        else if (x >= -1 && x <= 1)
        {
            y = 0;
            Console.WriteLine($"Wartość dla argumentu {x} wynosi {y}");
        }
        else if (x > 1 && x < 2)
        {
            y = x - 1;
            Console.WriteLine($"Wartość dla argumentu {x} wynosi {y}");
        }
        else if (x >= 2)
        {
            y = 2;
            Console.WriteLine($"Wartość dla argumentu {x} wynosi {y}");
        }

    }
    private static decimal inputValue()
    {
        decimal result;
        while (!decimal.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
