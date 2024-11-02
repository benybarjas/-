using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("متن  را وارد کنید:");
        string input = Console.ReadLine();
        
        string numbersOnly = "";

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                numbersOnly += c; // اضافه کردن عدد به رشته
            }
        }

        Console.WriteLine("اعداد: " + numbersOnly);
    }
}
