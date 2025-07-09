using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{

    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "level", "omo", "radar", "refer", "racecar" };
        
        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> input = new();

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "racecar" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> input = new() { "palindrome", "hello", "word" };

        // Act
        bool resuult = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(resuult, Is.False);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "levEl", "omO", "rADar", "rEfer", "raCecar" };

        // Act
        bool resuult = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(resuult, Is.True);
    }
}
