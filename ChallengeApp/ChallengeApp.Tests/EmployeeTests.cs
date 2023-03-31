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
    }
}
