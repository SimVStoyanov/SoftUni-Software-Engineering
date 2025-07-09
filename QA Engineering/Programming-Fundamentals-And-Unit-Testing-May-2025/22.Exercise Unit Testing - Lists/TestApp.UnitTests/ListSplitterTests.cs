using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        // Arrange
        List<int> input = new();

        // Acr
        (List<int> even, List<int> odd) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.even, Is.Empty);
        Assert.That(result.odd, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        // Arrange
        List<int> input = new() { 2, 6, 8, 10 };

        // Acr
        (List<int> even, List<int> odd) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.even, Is.EquivalentTo(input));
        Assert.That(result.odd, Is.Empty);

    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        // Arrange
        List<int> input = new() { 1, 3, 5, 33 };


        // Acr
        (List<int> even, List<int> odd) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.even, Is.Empty);
        Assert.That(result.odd, Is.EquivalentTo(input));

    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        // Arrange
        List<int> input = new() { 1, 3, 6, 5, 22, 33, 42 };
        List<int> expectedOdds = new() { 1, 3, 5, 33 };
        List<int> expectedEven = new() { 6, 22, 42 };

        // Acr
        (List<int> even, List<int> odd) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.even, Is.EqualTo(expectedEven));
        Assert.That(result.odd, Is.EquivalentTo(expectedOdds));
    }
}
