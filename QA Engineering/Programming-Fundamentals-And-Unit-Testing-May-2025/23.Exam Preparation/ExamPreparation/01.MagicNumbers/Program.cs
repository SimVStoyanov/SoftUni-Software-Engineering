int n = int.Parse(Console.ReadLine());

bool isFoundMagicNumber = false;

for (int number = 1; number <= n; number++)
{
    int initialNumber = number;
    bool AreAllDigitsPrime = true;
    int sumDigits = 0;

    while (initialNumber > 0)
    {
        int lastDigit = initialNumber % 10;
        if (IsPrime(lastDigit) == false)
        {
            AreAllDigitsPrime = false;
            break;
        }

        sumDigits += lastDigit;

        initialNumber = initialNumber / 10 ;
    }


    if (AreAllDigitsPrime && sumDigits % 2 == 0)
    {
        Console.Write(number + " ");
        isFoundMagicNumber = true;
    }
}

if (isFoundMagicNumber == false)
{
    Console.WriteLine("no");
}

static bool IsPrime(int digit)
{
    int count = 0;

    for (int number = 1; number <= digit; number++)
    {
        if (digit % number == 0)
        {
            count++;
        } 
    } 

    return count == 2;
}