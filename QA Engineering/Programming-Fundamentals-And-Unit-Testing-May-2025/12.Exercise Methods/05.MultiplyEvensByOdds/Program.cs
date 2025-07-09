int number = Math.Abs(int.Parse(Console.ReadLine()));    

Console.WriteLine(GetMultipleOfEvenOdds(number));

static int GetSumOfEvenDigits (int number)
{
    int sum = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        if (lastDigit % 2 == 0)
        {
            sum += lastDigit;
        }
        number /= 10;
    }

    return sum;
}

static int GetSumOfOddDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        if (lastDigit % 2 != 0)
        {
            sum += lastDigit;
        }
        number /= 10;
    }

    return sum;
}

static int GetMultipleOfEvenOdds(int number)
{
    return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
}