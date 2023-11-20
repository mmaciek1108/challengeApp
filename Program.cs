
using CSzarpKurs;

Employee user1 = new("Maciej", "Maciej", 38);
Employee user2 = new("Beata", "Marek", 12);
Employee user3 = new("Stefan", "Marek", 99);

user1.AddScore(1);
user1.AddScore(1);
user1.AddScore(1);
user1.AddScore(2);
user1.AddScore(1); 

user2.AddScore(9);
user2.AddScore(9);
user2.AddScore(9);
user2.AddScore(5);
user2.AddScore(5);

user3.AddScore(10);
user3.AddScore(10);
user3.AddScore(10);
user3.AddScore(10);
user3.AddScore(1);

List<Employee> users = new List<Employee>()
{
    user1, user2, user3
};

int maxResult = -1;
Employee userWithMaxResult = null;

foreach(var user in users)
{
    if(user.Result > maxResult)
    {
        maxResult = user.Result;
        userWithMaxResult = user;
    }
}

Console.WriteLine("Pracownik z największą liczbą punktów: ");
Console.WriteLine("Imię: " + userWithMaxResult.Name);
Console.WriteLine("Nazwisko: " + userWithMaxResult.Surname);
Console.WriteLine("Wiek: " + userWithMaxResult.Age);
Console.WriteLine("Liczba punktów: " + userWithMaxResult.Result);