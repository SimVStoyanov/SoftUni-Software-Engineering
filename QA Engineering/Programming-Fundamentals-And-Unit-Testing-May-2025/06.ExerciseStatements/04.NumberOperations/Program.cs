double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
string operation = Console.ReadLine();


switch (operation)
{
    case "+":
        double sum = firstNumber + secondNumber;
        Console.WriteLine($"{firstNumber} + {secondNumber} = {sum:F2}");
        break;

    case "-":
        double diff = firstNumber - secondNumber;
        Console.WriteLine($"{firstNumber} - {secondNumber} = {diff:F2}");
        break;

    case "*":
        double product = firstNumber * secondNumber;
        Console.WriteLine($"{firstNumber} * {secondNumber} = {product:F2}");
        break;

    case "/":
        double division = firstNumber / secondNumber;
        Console.WriteLine($"{firstNumber} / {secondNumber} = {division:F2}");
        break;
}
