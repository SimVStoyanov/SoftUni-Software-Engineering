var products = new Dictionary<string, decimal[]>();

while (true)
{
    string input = Console.ReadLine();
    if (input.ToLower() == "buy")
        break;

    string[] parts = input.Split(' ');
    string name = parts[0];
    decimal price = decimal.Parse(parts[1]);
    int quantity = int.Parse(parts[2]);

    if (!products.ContainsKey(name))
    {
        products[name] = new decimal[2];
        products[name][0] = price;
        products[name][1] = quantity;
    }
    else
    {
        products[name][1] += quantity;
        if (products[name][0] != price)
            products[name][0] = price;
    }
}

foreach (var product in products)
{
    decimal totalPrice = product.Value[0] * product.Value[1];
    Console.WriteLine($"{product.Key} -> {totalPrice:F2}");
}