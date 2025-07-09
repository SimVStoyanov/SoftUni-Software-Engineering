int firstNumer = int.Parse(Console.ReadLine());
int secondNumer = int.Parse(Console.ReadLine());


int factFirstNumber = CalculateFactorial(firstNumer);
int factSecondNumber = CalculateFactorial(secondNumer);

int result = factFirstNumber / factSecondNumber;

Console.WriteLine(result);  

static int CalculateFactorial (int number)
{
    int fact = 1;
    for (int i = 1; i <= number; i++)
    {
        fact *= i;
    }

    return fact;
}