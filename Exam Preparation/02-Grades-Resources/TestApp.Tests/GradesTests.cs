using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        //Arrange
        Dictionary<string,  int> grades = new Dictionary<string,int>()
        {
            {"Sasho", 5},
            {"Ivo", 6 },
            {"Pesho", 3}
            //["Dicho"]=4,
        };

        string expected = $"Ivo with average grade 6.00{Environment.NewLine}Sasho with average grade 5.00{Environment.NewLine}" +
            $"Pesho with average grade 3.00";  ;

        //Act
        string result=Grades.GetBestStudents(grades) ;

        //Assert

        Assert.AreEqual(expected, result) ;
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        //Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>();     
              

        //Act
        string result = Grades.GetBestStudents(grades);

        //Assert

        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        //Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            {"Sasho", 5},
            {"Gosho", 4},
            
        };

        string expected = $"Sasho with average grade 5.00{Environment.NewLine}Gosho with average grade 4.00";

        //Act
        string result = Grades.GetBestStudents(grades);

        //Assert

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        //Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            
            {"Gosho", 6},
            {"Ivo", 6 },
            
        };

        string expected = $"Gosho with average grade 6.00{Environment.NewLine}Ivo with average grade 6.00";


        //Act
        string result = Grades.GetBestStudents(grades);

        //Assert

        Assert.AreEqual(expected, result);
    }
}
