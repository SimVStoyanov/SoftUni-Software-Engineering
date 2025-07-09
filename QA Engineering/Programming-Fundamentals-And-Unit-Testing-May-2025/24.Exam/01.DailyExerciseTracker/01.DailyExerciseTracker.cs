int days = int.Parse(Console.ReadLine());
int sumOfMinutes = 0;

if (days <= 0)
{
    Console.WriteLine(0);
}
else
{
    for (int day = 1; day <= days; day++)
    {
        int minutesThatDay = int.Parse(Console.ReadLine());
        sumOfMinutes += minutesThatDay;
        Console.WriteLine(sumOfMinutes);
    }
}