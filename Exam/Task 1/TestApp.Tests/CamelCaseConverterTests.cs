using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        //Arrange

        string input ="";

       //Act
       string result=CamelCaseConverter.ConvertToCamelCase(input);
       //Assert
       Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        //Arrange

        string input = "SOFTUNI";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("softuni"));
    }
    [Test]
    public void Test_ConvertToCamelCase_SingleSighWord_ReturnsLowercaseWord()
    {
        //Arrange

        string input = "S";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("s"));
    }
    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        //Arrange

        string input = "softuni rocks sofia";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("softuniRocksSofia"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsUpperCase_ReturnsCamelCase()
    {
        //Arrange

        string input = "SoftUni Rocks Sofia";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("softuniRocksSofia"));
    }

    [Test]
    public void Test_ConvertToCamelCase_OneWordCamelCase_ReturnsCamelCase()
    {
        //Arrange

        string input = "softUniRocksSofia";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("softunirockssofia"));
    }
    [Test]
    public void Test_ConvertToCamelCase_WithNumbers_ReturnsCamelCase()
    {
        //Arrange

        string input = "Sofia2.0";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("sofia2.0"));
    }
    [Test]
    public void Test_ConvertToCamelCase_WithWhiteSpace_ReturnsCamelCase()
    {
        //Arrange

        string input = " Sofia2.0";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("Sofia2.0"));
    }
    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        // Arrange

        string input = "softuni Study case";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("softuniStudyCase"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordWithMixedCase_ReturnsCamelCase()
    {
        // Arrange

        string input = "softUni StUDy caSE Sofia";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("softuniStudyCaseSofia"));
    }
    [Test]
    public void Test_ConvertToCamelCase_MultipleWordWithSpecialCharacters_ReturnsCamelCase()
    {
        // Arrange

        string input = "Uni_K";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("uni_k"));
    }
    [Test]
    public void Test_ConvertToCamelCase_SingleWordReturnsCamelCase()
    {
        // Arrange

        string input = "test";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("test"));
    }
}
