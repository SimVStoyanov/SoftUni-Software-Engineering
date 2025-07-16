var resources = new Dictionary<string, long>();

while (true)
{
    string resource = Console.ReadLine();
    if (resource.ToLower() == "stop")
        break;

    long quantity = long.Parse(Console.ReadLine());

    if (!resources.ContainsKey(resource))
        resources[resource] = 0;

    resources[resource] += quantity;
}

foreach (var item in resources)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}