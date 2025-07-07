double depositedAmount = double.Parse(Console.ReadLine()); 
double months = double.Parse(Console.ReadLine()); 
double interestRate  = double.Parse(Console.ReadLine()); 

double accumulatedInterest = depositedAmount * (interestRate / 100);
double interestForMonth = accumulatedInterest / 12;
double totalAmount = depositedAmount + (months * interestForMonth);

Console.WriteLine($"{totalAmount:F2}");
