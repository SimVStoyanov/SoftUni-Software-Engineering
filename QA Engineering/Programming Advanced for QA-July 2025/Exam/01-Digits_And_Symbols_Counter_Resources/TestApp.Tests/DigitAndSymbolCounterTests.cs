using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TestApp.Tests;

public class DigitAndSymbolCounterTests
{

    [Test]
    public void Test_EmptyStringInput_ReturnsEmptyDictionary()
    {
       //Arrange
        string inputSentence = "";
        Dictionary<string, int> expected = new();

        //Act
        Dictionary<string, int> result = DigitAndSymbolCounter.CountDigitsAndSymbols(inputSentence);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
        //Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_NoDigitsStringInput_ReturnsOnlyNonDigitsCount()
    {
        //Arrange
        string inputSentence = "SoftUni QA Exam";
        Dictionary<string, int> expected = new()
        {
            {"non-digit symbol", 15 }
        };

        //Act
        Dictionary<string, int> result = DigitAndSymbolCounter.CountDigitsAndSymbols(inputSentence);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_NoOddDigitsStringInput_ReturnsOnlyEvenDigitsAndNonDigitsCount()
    {
        //Arrange
        string inputSentence = "August846";
        Dictionary<string, int> expected = new()
        {
            {"even digit", 3 },
            { "non-digit symbol", 6 }
        };

        //Act
        Dictionary<string, int> resuult = DigitAndSymbolCounter.CountDigitsAndSymbols(inputSentence);

        //Assett
        Assert.That(resuult, Is.EqualTo(expected));
    }

    [Test]
    public void Test_NoEvenDigitsStringInput_ReturnsOnlyOddDigitsAndNonDigitsCount()
    {
        //Arrange
        string inputSentence = "QA Exam 17 August";
        Dictionary<string, int> expected = new()
        {
            { "odd digit", 2 },
            { "non-digit symbol", 15 }
        };

        //Act
        Dictionary<string, int> result = DigitAndSymbolCounter.CountDigitsAndSymbols(inputSentence);

        //Assett
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SymbolsEvenAndOddDigitsStringInput_ReturnsAllTypeOfCounts()
    {
        //Arrange
        string inputSentence = "17 8 Exam";
        Dictionary<string, int> expected = new()
            {
                { "even digit", 1 },
                { "odd digit", 2 },
                { "non-digit symbol", 6 }
            };

        //Act
        Dictionary<string, int> result = DigitAndSymbolCounter.CountDigitsAndSymbols(inputSentence);

        //Assett
        Assert.That(result, Is.EqualTo(expected));
    }
}