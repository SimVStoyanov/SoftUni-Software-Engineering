using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new();
        Dictionary<string, int> dict2 = new();

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new();
        Dictionary<string, int> dict2 = new()
        {
            { "Ivan", 5 },
            { "Delger", 8 }
        };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "Katy", 3 },
            { "Avrama", 9 }
        };
        ;
        Dictionary<string, int> dict2 = new()
        {
            { "Ivan", 5 },
            { "Delger", 8 }
        };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "Katy", 3 },
            { "Avrama", 9 }
        };
        ;
        Dictionary<string, int> dict2 = new()
        {
            { "Katy", 3 },
            { "Delger", 8 }
        };

        Dictionary<string, int> expected = new()
        {
            { "Katy", 3 }
        };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That (result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "Katy", 4 },
            { "Avrama", 9 }
        };
        ;
        Dictionary<string, int> dict2 = new()
        {
            { "Katy", 3 },
            { "Delger", 8 }
        };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);

    }
}
