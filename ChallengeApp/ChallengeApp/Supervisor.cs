using System.Text.RegularExpressions;

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        List<float> grades = new List<float>();
        public string Name => "Aleksander";
        public string Surname => "Orlicz";

        public Supervisor()
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

        public void AddGrade(double grade)
        {
            float floatGrade = (float)grade;
            AddGrade(floatGrade);
        }

        public void AddGrade(int grade)
        {
            float floatGrade = (float)grade;
            AddGrade(floatGrade);
        }

        public void AddGrade(char grade)
        {
            switch(grade)
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
                    throw new Exception("Wrong character");

            }
        }

        public void AddGrade(string grade)
        {
            

            string pattern1 = @"^[1-6][\+-]$";
            string pattern2 = @"^[\+-][1-6]$";
            string pattern3 = @"^[1-6]$";

            if(Regex.IsMatch(grade,pattern1) || Regex.IsMatch(grade,  pattern2) || Regex.IsMatch(grade, pattern3))
            {
                float modifier = 0;

                if (grade.StartsWith("+") || grade.EndsWith("+"))
                {
                    modifier = 5;
                }
                else if (grade.StartsWith("-") || grade.EndsWith("-"))
                {
                    modifier = -5;
                }
                
                char[] valueToTrim = { '-', '+' };
                string trimmedGrade = grade.Trim(valueToTrim);

                

                    switch (trimmedGrade)
                    {
                        case "6":
                            this.grades.Add(100+ modifier);
                            break;
                        case "5":
                            this.grades.Add(80 + modifier);
                            break;
                        case "4":
                            this.grades.Add(60 + modifier);
                            break;
                        case "3":
                            this.grades.Add(40 + modifier);
                            break;
                        case "2":
                            this.grades.Add(20 + modifier);
                            break;
                        case "1":
                            this.grades.Add(0 + modifier);
                            break;
                        default:
                            throw new Exception("Wrong grade");
                    }                
            }
            else if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if(char.TryParse(grade, out char result2))
            {
                this.AddGrade(result2);
            }
            else
            {
                throw new Exception("wrong format");
            }


            
            // 6 => 100
            // 5 => 80
            // 4 => 60
            // 3 => 40
            // -3 =>35
            // +2 =>25
            // 2+ =>25
            //+/- => +/-5
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
