using CSzarpKurs;

namespace challengeApp.Tests;

public class Tests
{
    
    [Test]
    public void WhenStatisticsCalled_ShouldReturnMax()
    {
        
        //arrange
        var user = new Employee("Klara", "Szybka", 14); 
        user.AddGrade(6);
        user.AddGrade(9);
        user.AddGrade(3);

        var statistics = user.GetStatistics();


        //act
        var min = statistics.Min;


        //assert
        Assert.AreEqual(3, min);
    }
    public void WhenStatisticsCalled_ShouldReturnMin()
    {
        //arrange
        var user = new Employee("Klara", "Szybka", 14); 
        user.AddGrade(6);
        user.AddGrade(9);
        user.AddGrade(3);

        var statistics = user.GetStatistics();


        //act
        var max = statistics.Max;


        //assert
        Assert.AreEqual(9, max);
    }

    public void WhenStatisticsCalled_ShouldReturnAverege()
    {
        //arrange
        var user = new Employee("Klara", "Szybka", 14); 
        user.AddGrade(6);
        user.AddGrade(9);
        user.AddGrade(3);

        var statistics = user.GetStatistics();


        //act
        var ave = statistics.Average;


        //assert
        Assert.AreEqual(6 , ave);
    }
}