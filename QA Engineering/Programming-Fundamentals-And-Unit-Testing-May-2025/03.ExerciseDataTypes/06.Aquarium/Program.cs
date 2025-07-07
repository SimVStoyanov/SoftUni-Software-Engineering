int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percetange = double.Parse(Console.ReadLine());

double aquariumVolumeInCm = length * width * height;
double aquariumVolumeInLiters = aquariumVolumeInCm * 0.001;

double occupiedSpace = percetange * 0.010;
double result = aquariumVolumeInLiters * (1 - occupiedSpace);

Console.WriteLine($"{result:F2}");

