using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        //Arrange
        string sentence = "";
        List<char> forbiddenChars = new List<char> { 'a', 'e' };

        //Act
        string resultSentence = IgnoreTheChars.IgnoreChars(sentence, forbiddenChars);

        //Assert
        Assert.That(sentence, Is.EqualTo(resultSentence));
    }

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        //Arrange
        string sentence = "Hello world";
        List<char> forbiddenChars = new List<char>();

        //Act
        string resultSentence = IgnoreTheChars.IgnoreChars(sentence, forbiddenChars);

        //Assert
        Assert.That(sentence, Is.EqualTo(resultSentence));
    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        //Arrange
        string sentence = "m";
        List<char> forbiddenChars = new List<char> { 'm' };
        string expectedSentence = "";

        //Act
        string resultSentence = IgnoreTheChars.IgnoreChars(sentence, forbiddenChars);

        //Assert
        Assert.That(expectedSentence, Is.EqualTo(resultSentence));
    }

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
        //Arrange
        string sentence = "Hello world";
        List<char> forbiddenChars = new List<char> { 'l', 'o' };
        string expectedSentence = "He wrd";

        //Act
        string resultSentence = IgnoreTheChars.IgnoreChars(sentence, forbiddenChars);

        //Assert
        Assert.That(expectedSentence, Is.EqualTo(resultSentence));
    }
}
