int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());


if (n1 < n2 && n2 < n3)
{
    Console.WriteLine("Ascending");
}
else if (n1 > n2 && n2 > n3)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}
