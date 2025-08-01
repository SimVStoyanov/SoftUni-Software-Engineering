﻿using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        //Arrange
        List<int> emptyList = new(); 
        string expectedText = "";

        //Act
        string resultText = AdjacentEqual.Sum(emptyList);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        //Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        string expectedText = "1 2 3 4 5 6";

        //Act
        string resultText = AdjacentEqual.Sum(numbers);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        //Arrange
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 5 };
        string expectedText = "1 4 3 4 5";

        //Act
        string resultText = AdjacentEqual.Sum(numbers);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        //Arrange
        List<int> numbers = new List<int> { 2, 2, 2, 2 };
        string expectedText = "8";

        //Act
        string resultText = AdjacentEqual.Sum(numbers);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        //Arrange
        List<int> numbers = new List<int> { 2, 2, 3, 4 };
        string expectedText = "4 3 4";

        //Act
        string resultText = AdjacentEqual.Sum(numbers);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        //Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 3 };
        string expectedText = "1 2 6";

        //Act
        string resultText = AdjacentEqual.Sum(numbers);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        //Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 3, 4, 5 };
        string expectedText = "1 2 6 4 5";

        //Act
        string resultText = AdjacentEqual.Sum(numbers);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));
    }
}
