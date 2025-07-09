using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new();
        int threshold = 1;

        // Acr
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, threshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new() { 6, 32, 12, 8 };
        int threshlod = 33;

        // Acr
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, threshlod);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> input = new() { 16, 7, 12, 22, 44 };
        int threshlod = 6;

        // Acr
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, threshlod);

        // Assert
        Assert.That(result, Is.EquivalentTo(input));
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        // Arrange
        List<int> input = new() { 6, 32, 12, 8, 22, 44 };
        int threshlod = 23;
        List<int> expected = new() { 32, 44 };

        // Acr
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, threshlod);

        // Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }
}
