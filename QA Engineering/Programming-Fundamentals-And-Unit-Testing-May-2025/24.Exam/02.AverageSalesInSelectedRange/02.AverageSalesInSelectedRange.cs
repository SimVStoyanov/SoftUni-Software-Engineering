int[] amounts = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

int startIndex = int.Parse(Console.ReadLine());
int endIndex = int.Parse(Console.ReadLine());

int sum = 0;
int count = 0;

for (int sale = startIndex; sale <= endIndex; sale++)
{
    sum += amounts[sale];
    count++;
}

double average = (double)sum / count;
Console.WriteLine($"{average:F2}");

