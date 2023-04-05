using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();
        
        public Employee()
        {
        }
        public Employee(string name)
            : base(name)
        {            
        }

        public Employee(string name, string surname)
            : base(name, surname)
        { 
        }

        public Employee(string name, string surname, char sex)
            : base(name, surname, sex)
        {
        }

        public Employee(string name, string surname, char sex, int age)
            : base(name, surname, sex, age)
        {
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char result2))
            {
                this.AddGrade(result2);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public void AddGrade(long grade)
        {
            var gradeInFloat = (float)grade;
            AddGrade(gradeInFloat);
        }

        public void AddGrade(double grade)
        {
            var gradeInFloat = (float)grade;
            AddGrade(gradeInFloat);

        }

        public void AddGrade(int grade)
        {
            var gradeInFloat = (float)grade;
            AddGrade(gradeInFloat);
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }



        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                //break
                //continue
                //goto                
                if (grade >= 0)
                {
                    statistics.Average += grade;
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                }
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;


            }
            return statistics;
        }
    }
}
