int countOfPensPackages = int.Parse(Console.ReadLine());
int countOfMarkersPackages = int.Parse(Console.ReadLine());
int litersBoardsCleaner = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

double priceForPens = countOfPensPackages * 5.80;
double priceForMarkers = countOfMarkersPackages * 7.20;
double priceForBoardCleaner = litersBoardsCleaner * 1.20;
double priceForAAllMaterials = priceForPens + priceForMarkers + priceForBoardCleaner;

double discount = priceForAAllMaterials * discountPercentage / 100;

double finalPrice = priceForAAllMaterials - discount;

Console.WriteLine(finalPrice);