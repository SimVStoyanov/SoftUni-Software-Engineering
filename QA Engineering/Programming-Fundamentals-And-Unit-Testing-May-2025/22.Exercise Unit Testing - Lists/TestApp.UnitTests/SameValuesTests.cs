using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        //Arrange
        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>() { 1, 2, 3};

        //Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        //Arrange
        List<int> firstList = new List<int>() { 1, 2, 3 };
        List<int> secondList = new List<int>();

        //Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        //Arrange
        List<int> firstLine = new List<int>() { 1, 2, 3 };
        List<int> secondLine = new List<int>() { 4, 5, 6, 7 };

        //Act
        List<int> result = SameValues.FindSameValues(firstLine, secondLine);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        //Arrange
        List<int> firstLine = new List<int>() { 1, 2, 30, 42, 101, 234, 21 };
        List<int> secondLine = new List<int> { 11, 9, 30, 12, 42, 98, 234 };
        List<int> expected = new List<int>() { 30, 42, 234 };

        //Act
        List<int> result = SameValues.FindSameValues(firstLine, secondLine);


        //Assert
        //CollectionAssert.AreEqual(expected, result);
        Assert.That(result, Is.EquivalentTo(expected));
    }
}
