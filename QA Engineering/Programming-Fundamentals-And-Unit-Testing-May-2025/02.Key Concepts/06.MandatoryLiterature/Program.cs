
int numberOfPage = int.Parse(Console.ReadLine());
int pagesReadInHour = int.Parse(Console.ReadLine());
int daysToFinish = int.Parse(Console.ReadLine());

int totalReadingTimeOfTheBook = numberOfPage / pagesReadInHour;
int requiredHoursPerDay = totalReadingTimeOfTheBook / daysToFinish;

Console.WriteLine(requiredHoursPerDay);