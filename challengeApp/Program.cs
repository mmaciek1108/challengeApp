
using System.Net.Mail;
using challengeApp;

Console.WriteLine("Witamy w programie 'OceńToRajd' do oceny pracowników.");
Console.WriteLine("=====================================================");
Console.WriteLine();

var employee = new EmployeeInFile("mm", "mm");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nowa ocenę");
}

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"cos poszło nie tak: {e.Message}");
    }
}
var statistics = employee.GetStatistics();

Console.WriteLine($"Averange: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverangeLetter: {statistics.AverageLetter}");