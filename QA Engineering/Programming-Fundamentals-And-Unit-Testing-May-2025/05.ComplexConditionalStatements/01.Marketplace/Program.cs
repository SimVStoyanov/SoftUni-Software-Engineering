string fruit = Console.ReadLine(); 
string day = Console.ReadLine();

if (fruit == "Banana")
{
    if (day == "Weekday")
    {
        Console.WriteLine("2.50");
    }
    else if (day == "Weekend")
    {
        Console.WriteLine("2.70");
    }
}
else if (fruit == "Apple")
{
    if (day == "Weekday")
    {
        Console.WriteLine("1.30");
    }
    else if (day == "Weekend")
    {
        Console.WriteLine("1.60");
    }
}
else if (fruit == "Kiwi")
{
    if (day == "Weekday")
    {
        Console.WriteLine("2.20");
    }
    else if (day == "Weekend")
    {
        Console.WriteLine("3.00");
    }
}