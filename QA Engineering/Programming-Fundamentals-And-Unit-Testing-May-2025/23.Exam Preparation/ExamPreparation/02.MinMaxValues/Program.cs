int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

int n = int.Parse(Console.ReadLine());

int max = int.MinValue;
int min = int.MaxValue;

for (int position = 0; position < n; position++)
{
    int number = numbers[position];
    if (number > max)
    {
        max = number;
    }
    if (number < min)
    {
        min = number;
    }

}

Console.WriteLine(max);
Console.WriteLine(min);




