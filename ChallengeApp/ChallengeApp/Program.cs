using ChallengeApp;

var employee = new Employee("Aleksander", "Orlicz");
employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade(6);
employee.AddGrade(long.MaxValue);
employee.AddGrade(double.MaxValue);
employee.AddGrade(6.55555555555555555555f);
employee.AddGrade(2);
var statistics = employee.GetStatistics();
var statistics2 = employee.GetStatisticsWithDoWhile();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithForEach();
var statistics5 = employee.GetStatisticsWithFor();




Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

