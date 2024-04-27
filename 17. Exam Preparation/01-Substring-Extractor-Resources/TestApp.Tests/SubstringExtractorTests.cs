using NUnit.Framework;
using System;
using System.Runtime.CompilerServices;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        //Arrange
        string input = "Sofia";
        string startIndex = "o";
        string endIndex = "a";

        string expected = "fi";

        //Act
        string result=SubstringExtractor.ExtractSubstringBetweenMarkers(input, startIndex, endIndex);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
        
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "Sofia";
        string startIndex = "";
        string endIndex = "";

        

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startIndex, endIndex);

        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Sofia";
        string startIndex = "S";
        string endIndex = "";

        

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startIndex, endIndex);

        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Sofia";
        string startIndex = "";
        string endIndex = "";

        

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startIndex, endIndex);

        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "";
        string startIndex = "S";
        string endIndex = "i";

        string expected = "Substring not found";

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startIndex, endIndex);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {// Arrange
        string input = "Sofia";
        string startIndex = "S";
        string endIndex = "S";

        

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startIndex, endIndex);

        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));

    }
}
