using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

public class HighestAsciiSumTests
{

    [Test]
    public void Test_FindStringWithHighestAsciiSum_EmptyList_ReturnsEmptyString()
    {
        // Arrange
        List<string> inputStrings = new List<string>();

        // Act
        string result = HighestAsciiSum.FindStringWithHighestAsciiSum(inputStrings);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_FindStringWithHighestAsciiSum_NullList_ReturnsEmptyString()
    {
        List<string> inputStrings = null;

        // Act
        string result = HighestAsciiSum.FindStringWithHighestAsciiSum(inputStrings);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_FindStringWithHighestAsciiSum_OneElementInList_ReturnsThisString()
    {
        // Arrange
        List<string> inputStrings = new List<string> { "test" };
        string expected = "test";

        // Act
        string result = HighestAsciiSum.FindStringWithHighestAsciiSum(inputStrings);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindStringWithHighestAsciiSum_ManyElemenstInList_ReturnsHighestAsciiSumString()
    {
        // Arrange
        List<string> inputStrings = new List<string> { "test", "Test2", "HighSum" };
        string expected = "HighSum";


        // Act
        string result = HighestAsciiSum.FindStringWithHighestAsciiSum(inputStrings);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindStringWithHighestAsciiSum_ManyEqualValueStrings_ReturnsFirstString()
    {
        // Arrange
        List<string> inputStrings = new List<string> { "test", "tset", "tets" };
        string expexted = "test";

        // Act
        string result = HighestAsciiSum.FindStringWithHighestAsciiSum(inputStrings);

        // Assert
        Assert.That(result, Is.EqualTo(expexted));
    }
}
