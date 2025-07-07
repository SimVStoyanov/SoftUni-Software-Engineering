double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
double thirdNumber = double.Parse(Console.ReadLine());

if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
{
    Console.WriteLine("zero");
}
else
{

    int countNegativeNumbers = 0;

    if (firstNumber < 0)
    {
        countNegativeNumbers += 1;
    }

    if (secondNumber < 0)
    {
        countNegativeNumbers += 1;
    }

    if (thirdNumber < 0)
    {
        countNegativeNumbers += 1;
    }

    if (countNegativeNumbers % 2 == 0)
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine("negative");
    }
}
