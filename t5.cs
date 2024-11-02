using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("متن  را وارد کنید:");
        string input = Console.ReadLine();
        
        string lettersOnly = "";

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (char.IsLetter(c))
            {
                lettersOnly += c;
            }
        }

        Console.WriteLine("حروف شما: " + lettersOnly);
    }
}
