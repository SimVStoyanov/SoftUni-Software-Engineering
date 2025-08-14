using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        //Arrange
        string name = "Bread";
        double price = 2.20;
        int quantity = 10;
        string expexted = "Product Inventory:" + Environment.NewLine + "Bread - Price: $2.20 - Quantity: 10";

        //Act
        _inventory.AddProduct(name, price, quantity);

        //Assert
        //Assert.That(_inventory.DisplayInventory(), Does.Contain("Bread - Price: $2.20 - Quantity: 10"));
        Assert.That(_inventory.DisplayInventory(), Is.EqualTo(expexted));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        //Arrange
        string expexted = "Product Inventory:";
        
        //Act
        string result = _inventory.DisplayInventory();

        //Assert
        Assert.That(result, Is.EqualTo(expexted));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        //Arrange
        _inventory.AddProduct("Bread", 2.20, 10);
        _inventory.AddProduct("Water", 1.20, 20);
        string expected = "Product Inventory:"
                           + Environment.NewLine
                           + "Bread - Price: $2.20 - Quantity: 10"
                           + Environment.NewLine
                           + "Water - Price: $1.20 - Quantity: 20";
        //Act
        string result = _inventory.DisplayInventory();

        //Assert
        //Assert.That(result, Does.Contain("Bread - Price: $2.20 - Quantity: 10"));
        //Assert.That(result, Does.Contain("Water - Price: $1.20 - Quantity: 20"));
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        //Arrange
        double expected = 0;

        //Act
        double resulet = _inventory.CalculateTotalValue();

        //Assert
        Assert.That(resulet, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        //Arrange
        _inventory.AddProduct("Bread", 2.20, 10);
        _inventory.AddProduct("Water", 1.20, 20);
        double expected = 46.00;

        //Act
        double resulet = _inventory.CalculateTotalValue();

        //Assert
        Assert.That(resulet, Is.EqualTo(expected));
    }
}
