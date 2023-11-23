using System;
using CSzarpKurs;

var employee = new Employee("Mocarny", "Stefan", 19);
employee.AddGrade("3000");
employee.AddGrade("400");
employee.AddGrade(4);
employee.AddGrade('3');
employee.AddGrade(Math.PI);
employee.AddGrade('m');
employee.AddGrade("Ada");

var statistics = employee.GetStatistics();

 Console.WriteLine($"Averange: {statistics.Average:N2}");
 Console.WriteLine($"Min: {statistics.Min}");
 Console.WriteLine($"Max: {statistics.Max}");