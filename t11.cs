using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" عدد m را وارد کنید:");
        int m = int.Parse(Console.ReadLine());
        
        Console.WriteLine(" عدد n را وارد کنید:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"اعداد اول بین {m} و {n} عبارتند از:");
        for (int i = m; i <= n; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}