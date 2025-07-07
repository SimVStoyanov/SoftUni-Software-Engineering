double chickenMenu = 10.35;
double fishMenu = 12.40;
double vegetarianMenu = 8.15;
double delivery = 2.50;

double chickenMenuOrderQuantity = double.Parse(Console.ReadLine());
double fishMenuOrderQuantity = double.Parse(Console.ReadLine());
double vegetarianMenuOrderQuantity = double.Parse(Console.ReadLine());

double chickenOrderCost = chickenMenuOrderQuantity * chickenMenu;
double fishOrderCost = fishMenuOrderQuantity * fishMenu;
double vegeterianOrderCost = vegetarianMenuOrderQuantity * vegetarianMenu;

double totalMenuOrderCost = chickenOrderCost + fishOrderCost + vegeterianOrderCost;

double desertOrderPercentage = 0.2;
double totalDesertOrderCost = totalMenuOrderCost * desertOrderPercentage;

double totalCost = totalMenuOrderCost + totalDesertOrderCost + delivery;
Console.WriteLine(totalCost);