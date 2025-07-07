double yearlytTrainingFee = double.Parse(Console.ReadLine());

double sneakersCost = yearlytTrainingFee * 0.6; 
double uniformCost = sneakersCost * 0.8; 
double ballCost = uniformCost * 0.25;
double accessoriesCost = ballCost * 0.2;

double totalCost = yearlytTrainingFee + sneakersCost + uniformCost + ballCost + accessoriesCost;
Console.WriteLine(totalCost);