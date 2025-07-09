using System.Globalization;

string password = Console.ReadLine();

if (IsValidLength(password) && IsValidContent(password) && IsValidCountDigits(password))
{
    Console.WriteLine("Password is valid");
}

else
{
    if (!IsValidLength(password))
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }

    if (!IsValidContent(password))
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }

    if (!IsValidCountDigits(password)) 
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}


static bool IsValidLength (string password)
{
    if (password.Length >= 6  && password.Length <= 10)
    {
        return true;
    }

    else
    {
        return false;
    }
}

static bool IsValidContent (string password)
{
    foreach (char symbol in password)
    {
        if (char.IsLetterOrDigit(symbol) == false)
        {
            return false;
        }
    }

    return true;

}

static bool IsValidCountDigits (string password)
{
    int count = 0;
    foreach (char symbol in password)
    {
        if (char.IsDigit(symbol))
        {
            count++;
        }
    }
    return count >= 2;
}