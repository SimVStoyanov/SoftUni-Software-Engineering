﻿int countNumbers = int.Parse(Console.ReadLine());

int maxNumber = int.MinValue;

for (int count = 1; count <= countNumbers; count++)
{
    int number = int.Parse(Console.ReadLine());

    if (number > maxNumber)
    {
        maxNumber = number;
    }

}

Console.WriteLine(maxNumber);