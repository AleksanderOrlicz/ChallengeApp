using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine("Oceny powinny być w zakresie od 0 do 100");
Console.WriteLine("Oceny mogą być w prowadzane w formie liter:");
Console.WriteLine("A => 100; B => 80; C => 60; D => 40; E => 20");
Console.WriteLine();

var employee = new Employee("Michał", "Matczak", 'M', 22);
Console.WriteLine(employee.Name);
Console.WriteLine(employee.Surname);
Console.WriteLine(employee.Sex);
Console.WriteLine(employee.Age);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break; 
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception exception)
    {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }
    finally
    {

    }
    
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");



