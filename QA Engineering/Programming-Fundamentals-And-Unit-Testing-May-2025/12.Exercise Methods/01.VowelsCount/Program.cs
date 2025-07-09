string text = Console.ReadLine();

int countVowels = GetVowelsCount(text);

Console.WriteLine(countVowels);

static int GetVowelsCount (string text)
{
    int count = 0;

    for (int positon = 0; positon <= text.Length - 1; positon++)
    {
        char currentSymbol = text[positon];

        if (currentSymbol == 'A' || currentSymbol == 'a' ||
            currentSymbol == 'E' || currentSymbol == 'e' ||
            currentSymbol == 'O' || currentSymbol == 'o' ||
            currentSymbol == 'I' || currentSymbol == 'i' ||
            currentSymbol == 'U' || currentSymbol == 'u')
        {
            count++;
        }
    }

    return count;
}