﻿using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PersonTests
{
    private Person _person;

    [SetUp]
    public void SetUp()
    {
        _person = new Person();
    }

    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Ann A001 35" };

        Person firstPerson = new Person();
        firstPerson.Name = "Ann";
        firstPerson.Age = 35;
        firstPerson.Id = "A001";

        Person secondPerson = new Person()
        {
            Name = "Bob",
            Age = 30,
            Id = "B002"
        };

        List<Person> expectedPeopleList = new List<Person>();
        expectedPeopleList.Add(firstPerson);
        expectedPeopleList.Add(secondPerson);

        // Act
        List<Person> resultPeopleList = this._person.AddPeople(peopleData);

        // Assert
        Assert.That(resultPeopleList, Has.Count.EqualTo(2));
        for (int i = 0; i < resultPeopleList.Count; i++)
        {
            Assert.That(resultPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
            Assert.That(resultPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
            Assert.That(resultPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
            }
        }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // Arrange
        List<Person> persons = new List<Person>()
        {
            new Person()
            {
                Name = "Pesho",
                Id = "A001",
                Age = 35
            },
            new Person()
            {
                Name = "Gosho",
                Id = "B002",
                Age = 25
            },
            new Person()
            {
                Name = "Dimitrichko",
                Id = "C003",
                Age = 15
            }
        };

        string expected = $"Dimitrichko with ID: C003 is 15 years old.{Environment.NewLine}" +
                          $"Gosho with ID: B002 is 25 years old.{Environment.NewLine}" +
                          $"Pesho with ID: A001 is 35 years old.";

        // Act
        string result = _person.GetByAgeAscending(persons);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
