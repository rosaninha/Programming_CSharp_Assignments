using System;

public class Program
{
    public static void Main()
    {
        int answer;
        int operator1 = 3;
        int operator2 = 4;

        answer = (2 + operator1) * (operator2 + 5);

        Console.WriteLine("Result is: " + answer.ToString());
        Console.ReadKey();
    }

}
