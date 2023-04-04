using System.ComponentModel.DataAnnotations;

namespace ChallengeApp.Tests
{
    internal class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetsTwoGrades_ShouldReturnCorrectAverage()
        {
            //arrange
            var employee = new Employee("Aleksander", "Orlicz");
            employee.AddGrade(3);
            employee.AddGrade(15);
            float realAverage = 9;
            
            //act
            var statistics = employee.GetStatistics();
            var average = statistics.Average;
            //assert

            Assert.AreEqual(average, realAverage);
        }

        [Test]
        public void WhenEmployeeGetsFiveGrades_ShouldReturnCorrectValues()
        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade(3);
            employee.AddGrade(15);
            employee.AddGrade(12);
            employee.AddGrade(8);
            employee.AddGrade(5);

            var avg = employee.GetStatistics().Average;
            

            var statistics = employee.GetStatistics();
            

            Assert.AreEqual(statistics.Average, 8.6f);
            Assert.AreEqual(statistics.Max, 15f);
            Assert.AreEqual(statistics.Min, 3f);
        }

        [Test]
        public void WhenEmployeeGetsGrades_ShouldReturnCorrectAverage()
        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            


            var statistics = employee.GetStatistics();


            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));            
        }

        [Test]
        public void WhenEmployeeGetsGradesAsLetters_ShouldReturnCorrectStatistics()
        {
            var employee = new Employee();
            employee.AddGrade('A');
            employee.AddGrade('B');
            var realAverage = 90;
            var min = 80;
            var max = 100;

            var statistics = employee.GetStatistics();

            Assert.AreEqual(realAverage, statistics.Average);
            Assert.AreEqual(min, statistics.Min);
            Assert.AreEqual(max, statistics.Max);
        }

        [Test]
        public void WhenEmployeeGetsGradesInStringFormat_ShouldReturnCorrectAverage()
        {
            var employee = new Employee();
            employee.AddGrade("60");
            employee.AddGrade("C");
            employee.AddGrade("e");

            var statistics = employee.GetStatistics();

            Assert.AreEqual(Math.Round(46.666666666d,2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void WhenemployeeGetsGrades_ShouldReturnCorrectAverageLetter()
        {
            var employee = new Employee();
            employee.AddGrade("60");
            employee.AddGrade("C");
            employee.AddGrade("e");

            var statistics = employee.GetStatistics();

            Assert.That(statistics.AverageLetter, Is.EqualTo('C'));
        }
    }
}
