﻿int number = int.Parse(Console.ReadLine());

while (number < 1 || number > 100)
{
    number = int.Parse(Console.ReadLine());
}

Console.WriteLine(number);

while (true)
{
    int num = int.Parse(Console.ReadLine());

    if (num >= 1 && num <= 100)
    {
        Console.WriteLine(num);
        break;
    }
}