using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("عدد m را وارد کنید:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("عدد n را وارد کنید:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"اعداد آینه‌ای بین {m} و {n} عبارتند از:");
        for (int i = m; i <= n; i++)
        {
            if (IsPalindrome(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPalindrome(int number)
    {
        string str = number.ToString();
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);
        return str == reversed;
    }
}