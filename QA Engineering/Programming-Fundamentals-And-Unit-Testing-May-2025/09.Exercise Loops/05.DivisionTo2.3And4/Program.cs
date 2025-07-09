int countNumbers = int.Parse(Console.ReadLine());

int countDivisible2 = 0;

int countDivisible3 = 0;

int countDivisible4 = 0;

for (int count = 1; count <= countNumbers; count++)
{
    int number = int.Parse(Console.ReadLine());

    if (number % 2 == 0)
    {
        countDivisible2++;
    }

    if (number % 3 == 0)
    {
        countDivisible3++;
    }

    if (number % 4 == 0)
    {
        countDivisible4++;
    }
}


double percentDivisible2 = (countDivisible2 * 1.0 / countNumbers) * 100;
double percentDivisible3 = (countDivisible3 * 1.0 / countNumbers) * 100;
double percentDivisible4 = (countDivisible4 * 1.0 / countNumbers) * 100;

Console.WriteLine($"{percentDivisible2:F2}%");
Console.WriteLine($"{percentDivisible3:F2}%");
Console.WriteLine($"{percentDivisible4:F2}%");