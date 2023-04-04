using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine("Oceny powinny być w zakresie od 0 do 100");
Console.WriteLine("Oceny mogą być w prowadzane w formie liter:");
Console.WriteLine("A => 100; B => 80; C => 60; D => 40; E => 20");
Console.WriteLine();

var employee = new Employee();


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break; 
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");



