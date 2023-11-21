using CSzarpKurs;

namespace challengeApp.Tests;

public class Tests
{
    [Test]
    public void WhenUserCollectTwoScores_ShouldCorrectResult()
    {
        //arrange
        var user = new Employee("Klara", "Szybka", 14); 
        user.AddScore(6);
        user.AddScore(9);

        //act
        var result = user.Result;

        //assert
        Assert.AreEqual(15, result);
    }

    [Test]
    public void WhenUserCollecNegativeScores_ShouldCorrectResult()
    {
        //arrange
        var user = new Employee("Andrzej", "Blacha", 39); 
        user.AddScore(-6);
        user.AddScore(-9);
        

        //act
        var result = user.Result;

        //assert
        Assert.AreEqual(-15, result);
    }
}