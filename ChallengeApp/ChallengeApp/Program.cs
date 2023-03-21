/// 1. stwórz klasę Employee, w której przechowasz jego imie, nazwisko, wiek oraz punkty pracownika w postaci liczb całkowitych.
///
/// 2. Stwórz 3 pracowników i każdemu przydziel po 5 ocen z zakreesu od 1 do 10
///
/// 3. Napisz program, który wyszuka pracownika z najwyższą liczbą ocen a następnie wyświetli jego dane oraz wynkik
using ChallengeApp;

Random rnd = new();

Employee employee1 = new Employee("Jan", "Kowalski", 35);
Employee employee2 = new Employee("Anna", "Kowalik", 20);
Employee employee3 = new Employee("Michał", "Madej", 55);

List<Employee> listEmployees = new List<Employee>();
List<Employee> bestEmployees = new List<Employee>();

listEmployees.Add(employee1);
listEmployees.Add(employee2);
listEmployees.Add(employee3);

int bestResult = 0;

for (int i = 0; i < 5; i++)
{
    employee1.AddScore(rnd.Next(1, 10));
    employee2.AddScore(rnd.Next(1, 10));
    employee3.AddScore(rnd.Next(1, 10));
}

foreach (var employee in listEmployees)
{
    if (employee.Result > bestResult)
    {
        bestResult = employee.Result;
    }
}

foreach (var employee in listEmployees)
{
    if (employee.Result == bestResult)
    {
        bestEmployees.Add(employee);
    }
}

if (bestEmployees.Count == 1)
{
    Console.WriteLine("Pracownik z najlepszym wynikiem:");
    foreach (var employee in bestEmployees)
    {
        employee.ShowEmployee();
        employee.ShowResult();
    }
}
else if (bestEmployees.Count > 1)
{
    Console.WriteLine("Pracownicy z najwyższą sumą ocen: " + bestEmployees.Count);
    foreach (var employee in bestEmployees)
    {
        employee.ShowEmployee();
        employee.ShowResult();
        Console.WriteLine();
    }
}









