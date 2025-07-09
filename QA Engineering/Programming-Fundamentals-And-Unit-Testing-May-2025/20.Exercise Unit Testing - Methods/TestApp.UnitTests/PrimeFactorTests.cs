using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [TestCase(2)]
    [TestCase(7)]
    [TestCase(11)]
    [TestCase(389)]
    public void Test_FindLargestPrimeFactor_PrimeNumber(int primeNumber)
    {
        // Arrange

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(primeNumber);

        // Assert
        Assert.That(result, Is.EqualTo(primeNumber));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long number = 48625;
        long expected = 389;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
