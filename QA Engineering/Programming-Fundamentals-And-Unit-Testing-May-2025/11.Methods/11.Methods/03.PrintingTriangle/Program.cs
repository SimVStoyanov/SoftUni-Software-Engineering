internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        PrintTriangle(n);
    }

    private static void PrintTriangle(int side)
    {
        for (int row = 1; row <= side; row++) 
        {
            for (int i = 1; i <= row; i++)   
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        PrintSecondPartTriangle(side);
    }

    private static void PrintSecondPartTriangle(int side)
    {
        for (int row = side - 1; row >= 1; row--) 
        {
            for (int i = 1; i <= row; i++)  
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}