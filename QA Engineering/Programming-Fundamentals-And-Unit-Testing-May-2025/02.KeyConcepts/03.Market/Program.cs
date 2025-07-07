double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPricee = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

double sumTomato = tomatoQuantity * tomatoPrice;
double sumCucumber = cucumberQuantity * cucumberPricee;

double totalPrice = sumTomato + sumCucumber;

Console.WriteLine($"{totalPrice:F2}");


