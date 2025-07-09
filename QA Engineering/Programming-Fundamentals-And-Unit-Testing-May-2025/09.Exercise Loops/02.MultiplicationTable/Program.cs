int n = int.Parse(Console.ReadLine());


for (int number = 1; number <= 10; number++)
{
    int result = n * number;
    Console.WriteLine($"{n} x {number} = {result}");
}