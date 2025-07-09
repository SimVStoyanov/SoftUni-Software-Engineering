int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

PrintResultType(firstNumber, secondNumber, thirdNumber);


static void PrintResultType(int n1, int n2, int n3)
{
    int result = n1 * n2 * n3;
    if (result < 0)
    {
        Console.WriteLine("negative");
    }

    else if (result > 0)
    {
        Console.WriteLine("positive");
    }

    else 
    {
        Console.WriteLine("zero");
    }
}