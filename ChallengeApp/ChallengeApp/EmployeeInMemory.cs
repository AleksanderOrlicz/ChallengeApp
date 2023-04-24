﻿
namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase // : IEmployee
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {           
        }


        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if(GradeAdded != null)
                {
                   GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(double grade)
        {
            var gradeInFloat = (float)grade;
            AddGrade(gradeInFloat);
        }

        public override void AddGrade(int grade)
        {
            var gradeInFloat = (float)grade;
            AddGrade(gradeInFloat);
        }

        public override void AddGrade(char grade)
        {
            string stringGrade = grade.ToString();

            char charGrade = char.Parse(stringGrade.ToUpper());
            switch (grade)
            {
                case 'A':
                    this.AddGrade(100);
                    break;
                case 'B':
                    this.AddGrade(80);
                    break;
                case 'C':
                    this.AddGrade(60);
                    break;
                case 'D':
                    this.AddGrade(40);
                    break;
                case 'E':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong character");
            }
        }

        public override void AddGrade(string grade)
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

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            
            foreach(var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
