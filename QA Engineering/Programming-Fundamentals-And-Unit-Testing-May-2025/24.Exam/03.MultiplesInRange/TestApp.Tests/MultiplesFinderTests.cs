using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

public class MultiplesFinderTests
{
    [Test]
    public void Test_FindMultiples_StartGreaterThanEndNumber_ReturnsErrorMessage()
    {
        // Arrange
        int startNum = 11;
        int endNum = 8;
        int divisor = 2;
        string expected = "Start number should not be greater than end number.";

        // Act
        string result = MultiplesFinder.FindMultiples(startNum, endNum, divisor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMultiples_NoMultiplesOfTheDevisor_ReturnsEmptyString()
    {
        // Arrange
        int startNum = 11;
        int endNum = 19;
        int divisor = 23;
        string expected = string.Empty;

        // Act
        string result = MultiplesFinder.FindMultiples(startNum, endNum, divisor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMultiples_SingleMultipleOfTheDevisor_ReturnsSingleNumber()
    {
        // Arrange
        int startNum = 3;
        int endNum = 4;
        int divisor = 3;
        string expected = "3";

        // Act
        string result = MultiplesFinder.FindMultiples(startNum, endNum, divisor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMultiples_ManyMultiplesOfTheDevisor_ReturnsCorrectNumbersInRange()
    {
        // Arrange
        int startNum = 5;
        int endNum = 15;
        int divisor = 3;
        string expected = "6 9 12 15";

        // Act
        string result = MultiplesFinder.FindMultiples(startNum, endNum, divisor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMultiples_ZeroInRange_ReturnsZero()
    {
        // Arrange
        int startNum = 0;
        int endNum = 0;
        int divisor = 1;
        string expected = "0";

        // Act
        string result = MultiplesFinder.FindMultiples(startNum, endNum, divisor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}