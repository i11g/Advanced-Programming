using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        //Arrange
        int input = 0;
        Dictionary<int, int> expected = new();

        //Act
        
        Dictionary<int, int> result = NumberFrequency.CountDigits(input); 
        
        //Assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        //Arrange
        int input = 5;
        Dictionary<int, int> expected = new()
        {
            [5] = 1
        };

        //Act

        Dictionary<int, int> result = NumberFrequency.CountDigits(input);

        //Assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        //Arrange
        int input = 5342;
        Dictionary<int, int> expected = new()
        {
            [5] = 1,
            [3] = 1,
            [4] = 1,
            [2] = 1
        };

        //Act

        Dictionary<int, int> result = NumberFrequency.CountDigits(input);

        //Assert

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        //Arrange
        int input = -5333442;
        Dictionary<int, int> expected = new()
        {
            [5] = 1,
            [3] = 3,
            [4] = 2,
            [2] = 1
        };

        //Act

        Dictionary<int, int> result = NumberFrequency.CountDigits(input);

        //Assert

        Assert.That(result, Is.EqualTo(expected));
    }
}
