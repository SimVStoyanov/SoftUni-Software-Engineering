using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> fruitDictionary = new()
            {
                { "Apple", 5 },
                { "Banana", 3 },
                { "Orange", 10 }
            };
        string searchedFruit = "Banana";
        int expexted = 3;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, searchedFruit);

        // Assert
        Assert.That(result, Is.EqualTo(expexted));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitDictionary = new()
            {
                { "Apple", 5 },
                { "Banana", 3 },
                { "Orange", 10 }
            };
        string searchedFruit = "Grape";
        int expexted = 0;

        // Act
        var result = Fruits.GetFruitQuantity(fruitDictionary, searchedFruit);

        // Assert
        Assert.That(result, Is.EqualTo(expexted));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitDictionary = new();
        string searchedFruit = "grape";
        int expected = 0;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, searchedFruit);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitDictionary = null;
        string searchedFruit = "grape";

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, searchedFruit);
        int expected = 0;

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitDictionary = new()
            {
                { "Apple", 5 },
                { "Banana", 3 },
                { "Orange", 10 }
            };
        string searchedFruit = null;
        int expected = 0;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, searchedFruit);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
