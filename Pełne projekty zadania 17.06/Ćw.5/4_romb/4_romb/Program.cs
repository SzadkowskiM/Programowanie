using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int row_am,attempt=0,a=0,b=0,ran_in,ran_out,mark_am=0,tab_am=0;
        bool condition_1=false;
        char[] mark_out = new char[] { '#', '@', '|', '*' };
        char[] mark_in = new char[] { '.', ':', '-', '+' };
        Random generator = new Random();
        Console.WriteLine("Podaj liczbę wierszy rombu (Większą od 3 i nieparzystą): ");
        row_am = inputValue();
        attempt++;
        if (row_am % 2 == 0 || row_am < 3 )
        {
            while (attempt < 3)
            {
                Console.WriteLine("Podaj liczbę wierszy rombu (Większą od 3 i nieparzystą):  ");
                row_am = inputValue();
                if (row_am % 2 != 0 && row_am >= 3)
                {
                    condition_1 = true;
                    break;
                }
                else
                {
                    attempt++;
                }
            }
            if (attempt == 3)
            {
                condition_1 = false;
            }
        }
        else
        {
            condition_1 = true;
        }
        if(condition_1==false)
        {
            Console.WriteLine("Nie podano prawidłowej wartości 3 razy.");
        }
        else
        {
            b= mark_in.Length;
            ran_in= generator.Next(a,b-1);
            b = mark_out.Length;
            ran_out = generator.Next(a,b-1);
            int temp = 0;
            int indeks = 1;
            int temp_2 = int (Math.Ceiling(row_am / 2));
            while (indeks <= temp_2)
            {
                if (indeks == 1)
                {
                    mark_am = 1;
                    temp = mark_am;
                }
                else
                {
                    mark_am = temp + 2;
                    temp = mark_am;
                }
                tab_am = row_am - indeks;
                Console.WriteLine();
                while (tab_am != 0)
                {
                    Console.Write("     ");
                    tab_am--;
                }
                while (mark_am != 0)
                {
                    Console.Write($"{mark_out[ran_out]}    ");
                    mark_am--;
                }
                indeks++;
            }
            indeks = Math.Ceiling(row_am / 2);
            while(indeks >0)
            {
                if (indeks == 1)
                {
                    mark_am = 1;
                    temp = mark_am;
                }
                else
                {
                    mark_am = temp - 2;
                    temp = mark_am;
                }
                tab_am = row_am - indeks;
                Console.WriteLine();
                while (tab_am != row_am / 2)
                {
                    Console.Write("     ");
                    tab_am++;
                }
                while (mark_am != row_am / 2)
                {
                    Console.Write($"{mark_out[ran_out]}    ");
                    mark_am++;
                }
                indeks--;
            }
        }
    }

    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}
