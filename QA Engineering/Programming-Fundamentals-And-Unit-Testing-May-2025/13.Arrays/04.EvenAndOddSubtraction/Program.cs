﻿int[] numbers = Console.ReadLine()
                       .Split(" ")
                       .Select(int.Parse)
                       .ToArray();

int evenSum = 0;
int oddSum = 0;

foreach (int item in numbers)
{
    if (item % 2 == 0) 
    {
        evenSum += item;
    }
    else 
    {
        oddSum += item;
    }
}

int difference = evenSum - oddSum;

Console.WriteLine(difference);