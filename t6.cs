string iceCreamFlavor = "";
string toppings = "";

Console.WriteLine("Be bastani forushi ma khosh amadid!");

Console.WriteLine("Aya bastani chocolati mikhori? (y/n)");
var answer = Console.ReadKey().KeyChar;
Console.WriteLine();

if (answer == 'y')
{
    iceCreamFlavor = "Chocolati";
}
else
{
    Console.WriteLine("Pas bastani vanili mikhori? (y/n)");
    answer = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (answer == 'y')
    {
        iceCreamFlavor = "Vanili";
    }
    else
    {
        Console.WriteLine("Bastani toot farangi chetor?? (y/n)");
        answer = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (answer == 'y')
        {
            iceCreamFlavor = "Toot Farangi";
        }
        else
        {
            Console.WriteLine("Be gheyr az inha faghat bastani mozi darim. Barat mozi mizaram!");
            iceCreamFlavor = "Mozi";
        }
    }
}

Console.WriteLine("Aya shokolat rikhtani mikhori? (y/n)");
answer = Console.ReadKey().KeyChar;
Console.WriteLine();

if (answer == 'y')
{
    toppings += "Shokolat Rikhtani, ";
}

Console.WriteLine("Aya shirin del mikhori? (y/n)");
answer = Console.ReadKey().KeyChar;
Console.WriteLine();

if (answer == 'y')
{
    toppings += "Shirin Del, ";
}

Console.WriteLine("Aya badam pakhsh mikoni? (y/n)");
answer = Console.ReadKey().KeyChar;
Console.WriteLine();

if (answer == 'y')
{
    toppings += "Badam, ";
}

if (toppings == "")
{
    Console.WriteLine($"Shoma bastani {iceCreamFlavor}  sefaresh dadi. ");
}
else
{
    Console.WriteLine($"Shoma bastani {iceCreamFlavor} ba {toppings} sefaresh dadi. ");
}