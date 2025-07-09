using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new();
        int threshold = 3;

        // Acr
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new() { 6, 32, 12, 8 };
        int threshlod = 4;

        // Acr
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshlod);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> input = new() { 6, 32, 12, 8, 44 };
        int threshlod = 44;

        // Acr
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshlod);

        // Assert
        Assert.That(result, Is.EquivalentTo(input));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        // Arrange
        List<int> input = new() { 6, 32, 12, 8, 22, 44 };
        int threshlod = 22;
        List<int> expected = new() { 6, 12, 8, 22 };

        // Acr
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshlod);

        // Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }
}
