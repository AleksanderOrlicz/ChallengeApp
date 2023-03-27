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
        public void WhenEmployeeGetsPenaltyGrades_ShouldReturnCorrectValues()
        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade(3);
            employee.AddGrade(-5);
            employee.AddGrade(12);
            employee.AddGrade(-8);
            employee.AddGrade(5);


            var statistics = employee.GetStatistics();


            Assert.AreEqual(statistics.Average, 1.4f);
            Assert.AreEqual(statistics.Max, 12);
            Assert.AreEqual(statistics.Min, -8);
        }
    }
}
