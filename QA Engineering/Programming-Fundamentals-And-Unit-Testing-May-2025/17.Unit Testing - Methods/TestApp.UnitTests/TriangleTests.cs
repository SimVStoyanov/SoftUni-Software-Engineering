using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // Arange
        int num = 0;
        string expected = "";

        // Act
        string result = Triangle.PrintTriangle(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arange
        int num = 3;
        string expected = $"1{Environment.NewLine}" +
                          $"1 2{Environment.NewLine}" +
                          $"1 2 3{Environment.NewLine}" +
                          $"1 2{Environment.NewLine}" +
                          $"1";
        // Act
        string result = Triangle.PrintTriangle(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        // Arange
        int num = 5;
        string expected = $"1{Environment.NewLine}" +
                  $"1 2{Environment.NewLine}" +
                  $"1 2 3{Environment.NewLine}" +
                  $"1 2 3 4{Environment.NewLine}" +
                  $"1 2 3 4 5{Environment.NewLine}" +
                  $"1 2 3 4{Environment.NewLine}" +
                  $"1 2 3{Environment.NewLine}" +
                  $"1 2{Environment.NewLine}" +
                  $"1";
        // Act
        string result = Triangle.PrintTriangle(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
