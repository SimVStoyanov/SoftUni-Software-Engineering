using NUnit.Framework;
using System.Globalization;
using System.Security.Cryptography;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "a";

        // Act
        string result = StringReverse.Reverse(input);

        // Asset
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "Hllo";
        string expected = "ollH";

        // Acct
        string result = StringReverse.Reverse(input);

        // Asset
        Assert.That(result, Is.EqualTo(expected));
    }
}
