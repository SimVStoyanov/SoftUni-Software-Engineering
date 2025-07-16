int n = int.Parse(Console.ReadLine());
var parking = new Dictionary<string, string>();

for (int i = 0; i < n; i++)
{
    string[] parts = Console.ReadLine().Split();
    string command = parts[0];
    string username = parts[1];

    if (command == "register")
    {
        string licensePlate = parts[2];
        if (parking.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
        }
        else
        {
            parking[username] = licensePlate;
            Console.WriteLine($"{username} registered {licensePlate} successfully");
        }
    }
    else if (command == "unregister")
    {
        if (!parking.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
        else
        {
            parking.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
    }
}

foreach (var entry in parking)
{
    Console.WriteLine($"{entry.Key} => {entry.Value}");
}