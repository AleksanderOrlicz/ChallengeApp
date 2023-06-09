﻿namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("Invalid grade value!");
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade((float)result);
            }
            else if (char.TryParse(grade, out char result2))
            {
                this.AddGrade((char)result2);
            }
            else
            {
                throw new Exception("String is not float");
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


        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.StatisticsFromFile();
            var statistics = new Statistics();

            foreach(var grade in gradesFromFile)
            {
                statistics.AddGrade(grade);
            }
            
            return statistics;

        }

        private List<float> StatisticsFromFile()
        {
            var gradesFromFile = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var grade = float.Parse(line);
                        gradesFromFile.Add(grade);
                        line = reader.ReadLine();
                    }
                }
            }
            return gradesFromFile;
        }
    }
}
