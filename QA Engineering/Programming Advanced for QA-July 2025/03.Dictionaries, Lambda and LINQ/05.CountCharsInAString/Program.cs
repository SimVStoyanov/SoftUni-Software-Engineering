string input = Console.ReadLine();

Dictionary<char, int> charCount = new Dictionary<char, int>();

foreach (char c in input)
{
    if (c == ' ') continue; 

    if (!charCount.ContainsKey(c))
        charCount[c] = 0;

    charCount[c]++;
}

foreach (var pair in charCount)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}