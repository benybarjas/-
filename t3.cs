using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" عدد n را وارد کنید:");
        int n = int.Parse(Console.ReadLine());

        if (IsFibonacci(n))
        {
            Console.WriteLine($"{n} در  فیبوناچی وجود دارد.");
        }
        else
        {
            Console.WriteLine($"{n} در  فیبوناچی وجود ندارد.");
        }
    }

    static bool IsFibonacci(int num)
    {
        int a = 0, b = 1;

        if (num == a || num == b)
            return true;

        int c = a + b;
        while (c <= num)
        {
            if (c == num)
                return true;
            a = b;
            b = c;
            c = a + b;
        }
        return false;
    }
}