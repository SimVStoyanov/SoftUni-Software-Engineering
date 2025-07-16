var companies = new Dictionary<string, List<string>>();

while (true)
{
    string input = Console.ReadLine();
    if (input == "End")
        break;

    string[] parts = input.Split(" -> ");
    string company = parts[0];
    string employeeId = parts[1];

    if (!companies.ContainsKey(company))
    {
        companies[company] = new List<string>();
    }


    if (!companies[company].Contains(employeeId))
    {
        companies[company].Add(employeeId);
    }
}

foreach (var company in companies)
{
    Console.WriteLine(company.Key);
    foreach (var employee in company.Value)
    {
        Console.WriteLine($"-- {employee}");
    }
}
