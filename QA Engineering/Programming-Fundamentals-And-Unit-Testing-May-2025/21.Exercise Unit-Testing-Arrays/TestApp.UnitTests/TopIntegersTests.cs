using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{
    TopIntegers topIntegers;

    [SetUp]
    public void SetUp()
    {
        topIntegers = new TopIntegers();

    }
    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        //Arrange
        int[] emptyArray = Array.Empty<int>(); 
        string expectedText = string.Empty; 

        //Act
        string resultText = topIntegers.FindTopIntegers(emptyArray);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        //Аrrange
        int[] inputArray = new int[] { 4, 3, 2 }; 
        string expectedText = "4 3 2";

        //Act
        string resultText = topIntegers.FindTopIntegers(inputArray);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        //Arrange
        int[] inputArray = new int[] { 4 };
        string expectedText = "4";

        //Act
        string resultText = topIntegers.FindTopIntegers(inputArray);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        //Arrange
        int[] inputArray = new int[] { 14, 24, 3, 19, 15, 17 };
        string expectedText = "24 19 17";

        //Act
        string resultText = topIntegers.FindTopIntegers(inputArray);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));
    }
}

