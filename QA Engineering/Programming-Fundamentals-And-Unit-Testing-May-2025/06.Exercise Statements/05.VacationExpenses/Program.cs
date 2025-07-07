
//1. входни данни
string season = Console.ReadLine(); //"Spring", "Summer", "Autumn", "Winter"
string type = Console.ReadLine(); //"Hotel", "Camping"
int days = int.Parse(Console.ReadLine());
double pricePerNight = 0;

switch (season)
{
    case "Spring":
        if (type == "Hotel")
        {
            pricePerNight = 24;
        }
        else if (type == "Camping")
        {
            pricePerNight = 8;
        }
        break;

    case "Summer":
        if (type == "Hotel")
        {
            pricePerNight = 50;
        }
        else if (type == "Camping")
        {
            pricePerNight = 30;
        }
        break;

    case "Autumn":
        if (type == "Hotel")
        {
            pricePerNight = 14;
        }
        else if (type == "Camping")
        {
            pricePerNight = 10.50;
        }
        break;

    case "Winter":
        if (type == "Hotel")
        {
            pricePerNight = 36;
        }
        else if (type == "Camping")
        {
            pricePerNight = 9;
        }
        break;
}

double totalSum = pricePerNight * days;
Console.WriteLine($"{totalSum:F2}");
