int time1 = int.Parse(Console.ReadLine());
int time2 = int.Parse(Console.ReadLine());
int time3 = int.Parse(Console.ReadLine());

int totalTimeInSeconds = time1 + time2 + time3;

int minutes = totalTimeInSeconds / 60;
int seconds = totalTimeInSeconds % 60;

if (seconds >= 10)
{
    Console.WriteLine($"{minutes}:{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
