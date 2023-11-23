using CSzarpKurs;

var employee = new Employee("Mocarny", "Stefan", 19);
employee.AddGrade(2);
employee.AddGrade(3);
employee.AddGrade(4);

var statistics = employee.GetStatistics();

 Console.WriteLine($"Averange: {statistics.Average:N2}");
 Console.WriteLine($"Min: {statistics.Min}");
 Console.WriteLine($"Max: {statistics.Max}");